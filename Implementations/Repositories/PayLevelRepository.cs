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
    public class PayLevelRepository : IPayLevelRepository
    {
        private readonly ContextApp _context;

        public PayLevelRepository(ContextApp contextApp)
        {
            _context = contextApp;
        }
        public async Task<bool> CreateAsync(PayLevel payLevel)
        {
            await _context.PayLevels.AddAsync(payLevel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<PayLevelDTO>> GetAsync()
        {
            return await _context.PayLevels
            .Include(a => a.AllowancePayLevels)
            .ThenInclude(b => b.Allowance)
            .Where(p => p.IsDeleted == false).Select(pay => new PayLevelDTO
            {
                Id = pay.Id,
                LevelName = pay.LevelName,
                Description = pay.Description,
                BasicSalary = pay.BasicSalary,
                AllowanceDTOs = pay.AllowancePayLevels.Select(a => new AllowanceDTO
                {
                    Id = a.Allowance.Id,
                    AllowanceName = a.Allowance.AllowanceName,
                    Amount = a.Allowance.Amount
                }).ToList()
            }).ToListAsync();
        }
    }
}