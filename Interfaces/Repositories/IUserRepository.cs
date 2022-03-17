using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<bool> CreateAsync(User user);

        Task<bool> UpdateAsync(User user);

        Task<UserDTO> GetDtoAsync(int userId);

        Task<User> GetAsync(int id);
        
        Task<UserDTO> GetAsync(string UserId);

        Task<IEnumerable<UserDTO>> GetAsync();
    }
}