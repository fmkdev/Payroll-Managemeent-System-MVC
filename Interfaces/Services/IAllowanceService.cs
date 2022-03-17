using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IAllowanceService
    {
        Task<BaseResponse<AllowanceDTO>> CreateAsync(CreateAllowanceRequestModel model);

        Task<BaseResponse<IEnumerable<AllowanceDTO>>> GetAsync();
    }
}