using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Services
{
    public interface IAccountDetailsService
    {
        Task<BaseResponse<bool>> UpdateeAsync(int id, UpdateAccountDetailsRequestModel model);
        Task<BaseResponse<AccountDetailsDTO>> GetAsync(int id);
    }
}