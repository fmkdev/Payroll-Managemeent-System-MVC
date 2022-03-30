using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IBonusService
    {
        Task<BaseResponse<bool>> CreateAsync(int Id, CreateBonusRequestModel model);

        Task<BaseResponse<IEnumerable<BonusDTO>>> GetAsync(int EmployeeId, int month);
    }
}