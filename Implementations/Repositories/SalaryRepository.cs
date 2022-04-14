using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayxApi.ContextDb;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class SalaryRepository : ISalaryRepository
    {
        private readonly ContextApp _context;

        public SalaryRepository(ContextApp context)
        {
            _context = context;
        }
        public async Task<bool> CreateAsync(Salary salary)
        {
            await _context.Salaries.AddAsync(salary);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Salary> GetAsync(DateTime date)
        {
            return await _context.Salaries.Where(m => m.Month == date.Month).SingleOrDefaultAsync();
        }

        public async Task<bool> UpdateAsync(Salary salary)
        {
            _context.Salaries.Update(salary);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}