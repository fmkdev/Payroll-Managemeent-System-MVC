using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IPayLevelService
    {
        Task<BaseResponse<PayLevelDTO>> CreateAsync(CreatePayLevelRequestModel model);

        Task<BaseResponse<IEnumerable<PayLevelDTO>>> GetAsync();
    }
}