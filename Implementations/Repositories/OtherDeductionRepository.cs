using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayxApi.ContextDb;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi
{
    public class OtherDeductionRepository : IOtherDeductionRepository
    {
        private readonly ContextApp _contextApp;

        public OtherDeductionRepository(ContextApp contextApp)
        {
            _contextApp = contextApp;
        }

        public async Task<bool> CreateAsync(OtherDeduction otherDeduction)
        {
            await _contextApp.OtherDeductions.AddAsync(otherDeduction);
            await _contextApp.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<OtherDeductionDTO>> GetAsync(int EmployeeId, int month)
        {
            return await _contextApp.OtherDeductions.Where(o => o.EmployeeId == EmployeeId && o.Month == month)
            .Select(otherDeduction => new OtherDeductionDTO
            {
                DeductionName = otherDeduction.DeductionName,
                Amount = otherDeduction.Amount,
                Date = otherDeduction.Date
            }).ToListAsync();
        }
    }
}