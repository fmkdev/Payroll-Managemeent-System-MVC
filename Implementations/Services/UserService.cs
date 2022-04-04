using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;

namespace PayxApi.Implementations.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;
        public UserService(IUserRepository userRepository, IEmployeeRepository employeeRepository,
        IDepartmentRepository departmentRepository)
        {
            _userRepository = userRepository;
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }

        public async Task<BaseResponse<bool>> DeleteAsync(int userId)
        {
            var user = await _userRepository.GetAsync(userId);
            if(user == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Deleted",
                    Data = false
                };
            }
            user.IsDeleted = false;
            await _userRepository.UpdateAsync(user);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Deleted",
                Data = true
            };
        }

        public async Task<BaseResponse<UserDTO>> GetAsync(FindUserRequestModel model)
        {
            var user = await _userRepository.GetAsync(model.UserEmailOrCardId);
            if (user == null)
            {
                return new BaseResponse<UserDTO>
                {
                    IsSuccess = false,
                    Message = "user not found",
                    Data = null
                };
            }
            return new BaseResponse<UserDTO>
            {
                IsSuccess = true,
                Message = "Successful",
                Data = user
            };
        }

        public async Task<BaseResponse<UserDTO>> GetAsync(int userId)
        {
            var user = await _userRepository.GetDtoAsync(userId);
            return new BaseResponse<UserDTO>
            {
                IsSuccess = true,
                Message = "Success",
                Data = user
            };
        }

        public async Task<BaseResponse<IEnumerable<UserDTO>>> GetAsync()
        {
            var user = await _userRepository.GetAsync();
            return new BaseResponse<IEnumerable<UserDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = user
            };
        }


        public async Task<BaseResponse<UserDTO>> LoginAsync(LoginUserRequestModel model)
            {
                var user = await _userRepository.GetAsync(model.userEmailOrCardId);

                if (user == null)
                {
                    return new BaseResponse<UserDTO>
                    {
                        IsSuccess = false,
                        Message = "Email or password does not exist",
                        Data = null
                    };
                }
                var verify =  BCrypt.Net.BCrypt.Verify(model.Password, user.Password);
                if (verify == false)
                {
                    return new BaseResponse<UserDTO>
                    {
                        IsSuccess = false,
                        Message = "Email or password does not exist",
                        Data = null
                    };
                }
                return new BaseResponse<UserDTO>
                {
                    IsSuccess = true,
                    Message = "Login Successful",
                    Data = user
                };
            }
        }
    }