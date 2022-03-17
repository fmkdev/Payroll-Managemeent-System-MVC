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

        public async Task<BaseResponse<bool>> ApproveEmployeeRequestAsync(ApproveRequestModel model)
        {
            if(model.ApprovalStatus == ApprovalStatus.Initialized)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Accept Request or Reject",
                    Data = false
                };
            }
            var workingDays = await _workingDaysRepository.GetInitializedApprovalStatusAsync(model.UserCardId);

            if (workingDays == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "User not found",
                    Data = false
                };
            }

            foreach (var item in workingDays)
            {
                if(model.ApprovalStatus == ApprovalStatus.Accept && item.RequestStatus == RequestStatus.Permission)
                {
                    item.ApprovalStatus = ApprovalStatus.Accept;
                    item.WorkStatus = WorkStatus.Permission;
                }
                if(model.ApprovalStatus == ApprovalStatus.Accept && item.RequestStatus == RequestStatus.Leave)
                {
                    item.ApprovalStatus = ApprovalStatus.Accept;
                    item.WorkStatus = WorkStatus.OnLeave;
                }
                if(model.ApprovalStatus == ApprovalStatus.Reject && item.RequestStatus == RequestStatus.Permission)
                {
                    item.ApprovalStatus = ApprovalStatus.Reject;
                    item.WorkStatus = WorkStatus.Abscent;
                }
                if(model.ApprovalStatus == ApprovalStatus.Reject && item.RequestStatus == RequestStatus.Leave)
                {
                    item.ApprovalStatus = ApprovalStatus.Reject;
                    item.WorkStatus = WorkStatus.Abscent;
                }
            }
            await _workingDaysRepository.UpdateAsync(workingDays.ToList());

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

        public async Task<BaseResponse<bool>> MakeRequestAsync(int userId, MakeRequsetModel model)
        {
            var workings = await _workingDaysRepository.GetAsync(userId);
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
            if(workDay.WorkStatus == WorkStatus.OnLeave)
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
    }
}