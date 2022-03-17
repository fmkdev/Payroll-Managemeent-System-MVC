using System.Collections.Generic;
using PayxApi.Interfaces.Repositories;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;
using PayxApi.Models;
using System.Threading.Tasks;
using System;
using BCrypt.Net;

namespace PayxApi.Implementations.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IWorkingDaysRepository _workingDaysRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IAccountDetailsRepository _accountDetailsRepository;
        public EmployeeService(IEmployeeRepository employeeRepository, IUserRepository userRepository,
        IRoleRepository roleRepository, IAccountDetailsRepository accountDetailsRepository,
        IWorkingDaysRepository workingDaysRepository, IAddressRepository addressRepository)
        {
            _employeeRepository = employeeRepository;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _workingDaysRepository = workingDaysRepository;
            _addressRepository = addressRepository;
            _accountDetailsRepository = accountDetailsRepository;
        }

        public async Task<BaseResponse<bool>> CreateAsync(CreateEmployeeRequestModel model)
        {
            var use = await _userRepository.GetAsync(model.Email);
            if (use != null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Email Already Exist"
                };
            }
            var user = new User
            {
                FirstName = model.FirstName.ToUpper(),
                LastName = model.LastName.ToUpper(),
                Email = model.Email.ToUpper(),
                PhoneNumber = model.PhoneNumber,
                Password = BCrypt.Net.BCrypt.HashPassword(model.Password),
                CreatedBy = model.FirstName
            };

            var role = await _roleRepository.GetAsync(model.RoleIds);
            foreach (var item in role)
            {
                var userRole = new UserRole
                {
                    User = user,
                    UserId = user.Id,
                    Role = item,
                    RoleId = item.Id,
                    CreatedBy = model.FirstName
                };
                user.UserRoles.Add(userRole);
            }

            var employee = new Employee
            {
                CardId = $"PAYX-{Guid.NewGuid().ToString().Substring(0, 9).Replace("-", "").Trim().ToUpper()}",
                FirstName = model.FirstName.ToUpper(),
                LastName = model.LastName.ToUpper(),
                Email = model.Email.ToUpper(),
                PhoneNumber = model.PhoneNumber,
                UserId = user.Id,
                User = user,
                DepartmentId = model.DepartmentId,
                PositionId = model.PositionId,
                AppointmentId = model.AppointmentId,
                CreatedBy = model.FirstName,
                MaritalStatus = model.MaritalStatus,
                Gender = model.Gender,
                PaymentType = model.PaymentType,
                ResumptionDate = model.ResumptionDate,
                PayLevelId = model.PayLevelId
            };

            await _userRepository.CreateAsync(user);
            await _employeeRepository.CreateAsync(employee);

            var Address = new Address
            {
                HouseNumber = model.HouseNumber,
                StreetName = model.StreetName,
                City = model.City,
                State = model.State,
                Nationality = model.Nationality,
                HomeNumber = model.HomeNumber,
                LocalGovernment = model.LocalGovernment,
                EmployeeId = employee.Id,
                Employee = employee
            };

            var AccountDetails = new AccountDetails
            {
                AccountNumber = model.AccountNumber,
                BankName = model.BankName,
                EmployeeId = employee.Id,
                Employee = employee
            };

            await _addressRepository.CreteAsync(Address);
            await _accountDetailsRepository.CreateAsync(AccountDetails);

            var startDate = DateTime.UtcNow.Date;

            for (int d = 0; d < 365; d++)
            {
                var newDate = startDate.AddDays(d);

                if (newDate.DayOfWeek.Equals(DayOfWeek.Saturday) || newDate.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    continue;
                }
                var calendar = new WorkingDays
                {
                    EmployeeId = employee.Id,
                    EmployeeCardId = employee.CardId,
                    EmployeeFullName = $"{employee.FirstName} {employee.LastName}",
                    Employee = employee,
                    WorkDate = newDate
                };
                employee.WorkingDays.Add(calendar);
                await _workingDaysRepository.CreateAsync(calendar);
            }

            var us = await _userRepository.GetAsync(user.Id);
            us.Employee = employee;
            us.EmployeeCardId = employee.CardId;
            await _userRepository.UpdateAsync(us);

            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Created Successfully"
            };
        }

        public void DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BaseResponse<EmployeeDTO>> GetAsync(int id)
        {
            var employee = await _employeeRepository.GetAsync(id);
            if (employee == null)
            {
                return new BaseResponse<EmployeeDTO>
                {
                    IsSuccess = false,
                    Message = "not found",
                    Data = null
                };
            }
            return new BaseResponse<EmployeeDTO>
            {
                IsSuccess = true,
                Message = "Success",
                Data = new EmployeeDTO
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    PhoneNumber = employee.PhoneNumber,
                    Email = employee.Email,
                }
            };
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAsync()
        {
            return await _employeeRepository.GetAsync();
        }

        public async Task<BaseResponse<bool>> UpdateAsync(int id, UpdateEmployeeRequestModel model)
        {
            var user = await _userRepository.GetAsync(id);

            if (user == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Successfull",
                    Data = false
                };
            }
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PhoneNumber = model.PhoneNumber;
            user.Modified = DateTime.UtcNow;
            user.ModifiedBy = model.FirstName;

            var employee = await _employeeRepository.GetAsync(user.Employee.Id);
            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            employee.PhoneNumber = model.PhoneNumber;
            employee.Modified = DateTime.UtcNow;
            employee.ModifiedBy = model.FirstName;

            await _userRepository.UpdateAsync(user);
            await _employeeRepository.UpdateAsync(employee);

            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Created Successfully",
                Data = true
            };
        }
    }
}