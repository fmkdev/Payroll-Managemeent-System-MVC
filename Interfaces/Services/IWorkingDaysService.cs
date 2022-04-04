using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IWorkingDaysService
    {
        Task<BaseResponse<bool>> SignInAsync(string cardId);

        Task<BaseResponse<bool>> SignOutAsync(string cardId);

        Task<BaseResponse<bool>> MakeRequestAsync(string userCardId, MakeRequsetModel model);

        Task<BaseResponse<bool>> ApproveRequestAsync(int employeeId);

        Task<BaseResponse<bool>> RejectRequestAsync(int employeeId);

        Task<BaseResponse<int>> CalcPermissionDays(int employeeId);
        
        Task<BaseResponse<int>> CalcLeaveDays(int employeeId);

        Task<BaseResponse<IEnumerable<WorkingDaysDTO>>> GetAsync(DateTime date);

        Task<BaseResponse<IEnumerable<WorkingDaysDTO>>> GetAllRequestAsync();

        Task<BaseResponse<IEnumerable<WorkingDaysDTO>>> ViewMyCalendar(string userCardId);
    }
}