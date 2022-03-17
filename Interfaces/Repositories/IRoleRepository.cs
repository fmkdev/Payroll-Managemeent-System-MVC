using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IRoleRepository
    {
        Task<bool> CreateAsync(Role role);

        Task<RoleDTO> GetAsync(int id);
        
        Task<RoleDTO> GetAsync(string name);

        Task<IEnumerable<Role>> GetAsync(IList<int> ids);

        Task<IEnumerable<RoleDTO>> GetAsync();
    }
}