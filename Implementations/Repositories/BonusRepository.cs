using System;
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
    public class BonusRepository : IBonusRepository
    {
        private readonly ContextApp _contextApp;

        public BonusRepository(ContextApp contextApp)
        {
            _contextApp = contextApp;
        }

        public async Task<bool> CreateAsync(Bonus bonus)
        {
            await _contextApp.Bonus.AddAsync(bonus);
            await _contextApp.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<BonusDTO>> GetAsync(int EmployeeId, int month)
        {
            return await _contextApp.Bonus.Where(b => b.EmployeeId == EmployeeId && b.Month == month)
            .Select(bonus => new BonusDTO
            {
                BonusName = bonus.BonusName,
                Amount = bonus.Amount,
                Date = bonus.Date
            }).ToListAsync();
        }
    }
}