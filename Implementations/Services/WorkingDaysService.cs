using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Enum;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class WorkingDaysService : IWorkingDaysService
    {
        private readonly IWorkingDaysRepository _workingDaysRepository;

        public WorkingDaysService(IWorkingDaysRepository workingDaysRepository)
        {
            _workingDaysRepository = workingDaysRepository;
        }

        public async Task<BaseResponse<bool>> ApproveRequestAsync(int employeeId)
        {
            var workingDays = await _workingDaysRepository.GetAsync(employeeId);
            var init = workingDays.Where(i => (i.RequestStatus == RequestStatus.Permission || i.RequestStatus == RequestStatus.Leave) && i.ApprovalStatus == ApprovalStatus.Initialized);

            foreach (var item in init)
            {
                item.ApprovalStatus = ApprovalStatus.Accept;
            }
            await _workingDaysRepository.UpdateAsync(init.ToList());

            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Request Submitted",
                Data = true
            };
        }
        public async Task<BaseResponse<bool>> RejectRequestAsync(int employeeId)
        {
            var workingDays = await _workingDaysRepository.GetAsync(employeeId);
            var init = workingDays.Where(i => (i.RequestStatus == RequestStatus.Permission || i.RequestStatus == RequestStatus.Leave) && i.ApprovalStatus == ApprovalStatus.Initialized);

            foreach (var item in init)
            {
                item.ApprovalStatus = ApprovalStatus.Reject;
                item.WorkStatus = WorkStatus.Abscent;
            }
            await _workingDaysRepository.UpdateAsync(init.ToList());

            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Request Submitted",
                Data = true
            };
        }

        public async Task<BaseResponse<IEnumerable<WorkingDaysDTO>>> GetAsync(DateTime date)
        {
            var calendar = await _workingDaysRepository.GetAsync(date);
            return new BaseResponse<IEnumerable<WorkingDaysDTO>>
            {
                IsSuccess = true,
                Message = "Successful",
                Data = calendar
            };
        }

        public async Task<BaseResponse<bool>> MakeRequestAsync(string userCardId, MakeRequsetModel model)
        {
            var workings = await _workingDaysRepository.GetAsync(userCardId);
            if (workings == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "User not found",
                    Data = false
                };
            }

            var wDays = workings.Where(w => w.WorkDate >= model.From.Date && w.WorkDate <= model.To.Date);

            foreach (var day in wDays)
            {
                day.RequestStatus = model.RequestStatus;
                day.Request = model.Request;
            }


            await _workingDaysRepository.UpdateAsync(wDays.ToList());

            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Request Submitted",
                Data = true
            };
        }

        public async Task<BaseResponse<bool>> SignInAsync(string cardId)
        {
            var workDay = await _workingDaysRepository.GetAsync(cardId, DateTime.UtcNow.Date);

            if (workDay == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "User not Found",
                    Data = false
                };
            }
            if (workDay.WorkStatus == WorkStatus.OnLeave)
            {
                var calendar = await _workingDaysRepository.GetAsync(cardId);
                var addLeavePlusOne = calendar.LastOrDefault(u => u.WorkStatus == WorkStatus.OnLeave);
                var nextOneToChange = addLeavePlusOne.Id;
                var NextOnChange = calendar.SingleOrDefault(n => n.Id == nextOneToChange);
                NextOnChange.WorkStatus = WorkStatus.OnLeave;
                await _workingDaysRepository.UpdateAsync(NextOnChange);
            }
            workDay.SignInTime = DateTime.UtcNow;
            workDay.WorkStatus = Enum.WorkStatus.Present;

            await _workingDaysRepository.UpdateAsync(workDay);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Updated Successfully",
                Data = true
            };
        }

        public async Task<BaseResponse<bool>> SignOutAsync(string cardId)
        {
            var workDay = await _workingDaysRepository.GetAsync(cardId, DateTime.UtcNow.Date);
            if (workDay == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Can't SignOut, Have you signIn??",
                    Data = false
                };
            }
            workDay.SigOutTime = DateTime.UtcNow;

            await _workingDaysRepository.UpdateAsync(workDay);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Updated Successfully",
                Data = true
            };
        }

        public async Task<BaseResponse<IEnumerable<WorkingDaysDTO>>> GetAllRequestAsync()
        {
            var request = await _workingDaysRepository.GetAllRequestAsync();
            return new BaseResponse<IEnumerable<WorkingDaysDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = request
            };
        }

        public async Task<BaseResponse<IEnumerable<WorkingDaysDTO>>> ViewMyCalendar(string userCardId)
        {
            var emp = await _workingDaysRepository.GetAsync(userCardId);
            return new BaseResponse<IEnumerable<WorkingDaysDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = emp.Select(w => new WorkingDaysDTO
                {
                    Id = w.Id,
                    EmployeeFullName = w.EmployeeFullName,
                    EmployeeCardId = w.EmployeeCardId,
                    EmployeeId = w.EmployeeId,
                    WorkDate = w.WorkDate,
                    WorkStatus = w.WorkStatus,
                    DayStatus = w.DayStatus,
                    SignInTime = w.SignInTime,
                    SigOutTime = w.SigOutTime,
                    RequestStatus = w.RequestStatus,
                    Request = w.Request
                }).ToList()
            };
        }

        public async Task<BaseResponse<int>> CalcPermissionDays(int employeeId)
        {
            var employee = await _workingDaysRepository.GetAsync(employeeId);

            var requestDays = employee.Where(e => e.Request != null && e.ApprovalStatus == ApprovalStatus.Accept && e.RequestStatus == RequestStatus.Permission).Count();
            return new BaseResponse<int>
            {
                IsSuccess = true,
                Message = "Success",
                Data = requestDays
            };
        }

        public async Task<BaseResponse<int>> CalcLeaveDays(int employeeId)
        {
            var employee = await _workingDaysRepository.GetAsync(employeeId);

            var leaveDays = employee.Where(e => e.Request != null && e.ApprovalStatus == ApprovalStatus.Accept && e.RequestStatus == RequestStatus.Leave).Count();
            return new BaseResponse<int>
            {
                IsSuccess = true,
                Message = "Success",
                Data = leaveDays
            };
        }
    }
}