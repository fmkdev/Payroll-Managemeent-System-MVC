using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public async Task<BaseResponse<bool>> CreateAsync(CreateRoleRequestModel model)
        {
            var position = await _roleRepository.GetAsync(model.Name);
            if(position != null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Successfull"
                };
            }
            var role = new Role
            {
                Name = model.Name,
                Description = model.Description
            };
            await _roleRepository.CreateAsync(role);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Created Successfully"
            };
        }

        public async Task<BaseResponse<IEnumerable<RoleDTO>>> GetAsync()
        {
            var role = await _roleRepository.GetAsync();
            return new BaseResponse<IEnumerable<RoleDTO>>
            {
                IsSuccess = true,
                Message = "success",
                Data = role
            };
        }
    }
}