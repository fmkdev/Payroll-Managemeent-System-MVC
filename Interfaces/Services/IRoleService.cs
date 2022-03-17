using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Services
{
    public interface IRoleService
    {
        Task<BaseResponse<bool>> CreateAsync(CreateRoleRequestModel model);

        Task<BaseResponse<IEnumerable<RoleDTO>>> GetAsync();
    }
}