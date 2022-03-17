using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class BonusService : IBonusService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IBonusRepository _bonusRepository;

        public BonusService(IBonusRepository bonusRepository, IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _bonusRepository = bonusRepository;
        }
        public async Task<BaseResponse<bool>> CreateAsync(int employeeId, CreateBonusRequestModel model)
        {
            var employee = await _employeeRepository.GetAsync(employeeId);
            var bonus = new Bonus
            {
                EmployeeId = employeeId,
                Employee = employee,
                BonusName = model.BonusName,
                Amount = model.Amount,
                Date = DateTime.UtcNow,
                Month = DateTime.UtcNow.Month
            };
            await _bonusRepository.CreateAsync(bonus);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = $"{model.BonusName} for {employee.FirstName} created successfully",
                Data = true
            };
        }

        public async Task<BaseResponse<IEnumerable<BonusDTO>>> GetAsync(int EmployeeId, int month)
        {
            if (EmployeeId == 0)
            {
                return new BaseResponse<IEnumerable<BonusDTO>>
                {
                    IsSuccess = false,
                    Message = "Null Id",
                    Data = null
                };
            }
            var bonus = await _bonusRepository.GetAsync(EmployeeId, month);
            return new BaseResponse<IEnumerable<BonusDTO>>
            {
                IsSuccess = false,
                Message = "Null Id",
                Data = bonus
            };
        }
    }
}