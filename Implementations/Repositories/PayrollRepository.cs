using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayxApi.ContextDb;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class PayrollRepository : IPayrollRepository
    {
        private readonly ContextApp _context;

        public PayrollRepository(ContextApp contextApp)
        {
            _context = contextApp;
        }
        public async Task<bool> CreateAsync(Payroll payroll)
        {
            await _context.Payrolls.AddAsync(payroll);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<IEnumerable<Payroll>> GetAsync(DateTime month)
        {
           return null;
        }
    }
}