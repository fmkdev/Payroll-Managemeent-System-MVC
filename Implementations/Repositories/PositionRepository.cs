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
    public class PositionRepository : IPositionRepository
    {
        private readonly ContextApp _context;
        public PositionRepository(ContextApp context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Position position)
        {
            await _context.Positions.AddAsync(position);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<PositionDTO> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PositionDTO> GetAsync(string name)
        {
        
            var position = await _context.Departments
            .SingleOrDefaultAsync(e => e.Name == name && e.IsDeleted == false);
            if(position == null)
            {
                return null;
            }
            return new PositionDTO
            {
                Name = position.Name,
                Description = position.Description
            };        
        }
        public async Task<IEnumerable<Allowance>> GetAsync(IList<int> ids)
        {
            return await _context.Allowances.Where(d => ids.Contains(d.Id) && d.IsDeleted == false).ToListAsync();
        }

        public async Task<IEnumerable<PositionDTO>> GetAsync()
        {
            return await _context.Positions.Where(p => p.IsDeleted == false).Select(p => new PositionDTO
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description
            }).ToListAsync();
        }
    }
}