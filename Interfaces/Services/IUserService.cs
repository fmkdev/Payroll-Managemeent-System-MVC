using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;

namespace PayxApi.Interfaces.Services
{
    public interface IUserService
    {
        Task<BaseResponse<UserDTO>> GetAsync(FindUserRequestModel model);

        Task<BaseResponse<UserDTO>> GetAsync(int userId);

        Task<BaseResponse<UserDTO>> LoginAsync(LoginUserRequestModel model);

        Task<BaseResponse<bool>> DeleteAsync(int userId);

        Task<BaseResponse<IEnumerable<UserDTO>>> GetAsync();
    }
}