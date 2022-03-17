using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayxApi.ContextDb;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ContextApp _context;
        public RoleRepository(ContextApp context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Role role)
        {
            await _context.Roles.AddAsync(role);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<RoleDTO> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<RoleDTO> GetAsync(string name)
        {
            var role = await _context.Roles
            .SingleOrDefaultAsync(e => e.Name == name && e.IsDeleted == false);
            if(role == null)
            {
                return null;
            }
            return new RoleDTO
            {
                Name = role.Name,
                Description = role.Description
            };
        }
        public async Task<IEnumerable<Role>> GetAsync(IList<int> ids)
        {
            return await _context.Roles.Where(d => ids.Contains(d.Id) && d.IsDeleted == false).ToListAsync();
        }

        public async Task<IEnumerable<RoleDTO>> GetAsync()
        {
            return await _context.Roles.Where(r => r.IsDeleted == false).Select(r => new RoleDTO{
                Id = r.Id,
                Name = r.Name,
                Description = r.Description
            }).ToListAsync();
        }
    }
}