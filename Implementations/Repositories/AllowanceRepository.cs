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
    public class AllowanceRepository : IAllowanceRepository
    {
        private readonly ContextApp _context;

        public AllowanceRepository(ContextApp contextApp)
        {
            _context = contextApp;
        }
        public async Task<bool> Create(Allowance allowance)
        {
            await _context.Allowances.AddAsync(allowance);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<IEnumerable<Allowance>> GetAsync(IList<int> ids)
        {
            return await _context.Allowances.Where(d => ids.Contains(d.Id) && d.IsDeleted == false).ToListAsync();
        }

        public async Task<IEnumerable<AllowanceDTO>> GetAsync()
        {
            return await _context.Allowances.Where(b => b.IsDeleted == false)
            .Select(a => new AllowanceDTO
            {
                Id = a.Id,
                AllowanceName = a.AllowanceName,
                Amount = a.Amount
            }).ToListAsync();
        }
    }
}