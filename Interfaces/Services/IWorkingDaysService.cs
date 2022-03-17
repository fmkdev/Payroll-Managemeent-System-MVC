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

        Task<BaseResponse<bool>> MakeRequestAsync(int id, MakeRequsetModel model);

        Task<BaseResponse<bool>> ApproveEmployeeRequestAsync(ApproveRequestModel model);

        Task<BaseResponse<IEnumerable<WorkingDaysDTO>>> GetAsync(DateTime date);
    }
}