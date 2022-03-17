using PayxApi.ContextDb;
using PayxApi.Models;
using PayxApi.Interfaces.Repositories;
using System.Threading.Tasks;
using PayxApi.DTOs;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace PayxApi.Implementations.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ContextApp _context;
        public EmployeeRepository(ContextApp context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return true;
        }

        public async void DeleteAsync(Employee employee)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeDTO> GetDtoAsync(int id)
        {
            var employee = await _context.Employees
            .Include(a => a.Position)
            .Include(d => d.Department)
            .SingleOrDefaultAsync(e => e.Id == id && e.IsDeleted == false);
            return new EmployeeDTO
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PhoneNumber = employee.PhoneNumber,
                Email = employee.Email,
                PositionName = employee.Position.Name,
                DepartmentName = employee.Department.Name
            };
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllPaysAsync()
        {
            var monthNow = DateTime.UtcNow.Month;
            var pays = await _context.Employees
            .Include(a => a.Position)
            .ThenInclude(b => b.PositionAllowances)
            .ThenInclude(c => c.Allowance)
            .Include(f => f.PayLevel)
            .ThenInclude(e => e.AllowancePayLevels)
            .ThenInclude(g => g.Allowance)
            .Include(h => h.Bonus)
            .Include(i => i.OtherDeductions)
            .Where(e => e.IsDeleted == false)
            .Select(employee => new EmployeeDTO
            {
                Id = employee.Id,
                EmployeeCardId = employee.CardId,
                BasicPay = employee.PayLevel.BasicSalary,
                EmployeeTaxPercentage = employee.PayLevel.TaxPercentage,
                PaymentType = employee.PaymentType,
                PayLevelAllowance = employee.PayLevel.AllowancePayLevels.Sum(p => p.Allowance.Amount),
                PositionAllowance = employee.Position.PositionAllowances.Sum(s => s.Allowance.Amount),
                EmployeeBonus = employee.Bonus.Where(b => b.Month == monthNow).Sum(b => b.Amount),
                EmployeeOtherDeduction = employee.OtherDeductions.Where(o => o.Month == monthNow).Sum(t => t.Amount)
            }).ToListAsync();

            return pays;
        }

        public async Task<bool> UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Employee> GetAsync(int id)
        {
            return await _context.Employees.SingleOrDefaultAsync(e => e.Id == id && e.IsDeleted == false);
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAsync()
        {
            return await _context.Employees
            .Include(a => a.Position)
            .Include(d => d.Department)
            .Where(e => e.IsDeleted == false).Select( employee => new EmployeeDTO
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PhoneNumber = employee.PhoneNumber,
                Email = employee.Email,
                PositionName = employee.Position.Name,
                DepartmentName = employee.Department.Name
            }).ToListAsync();
           
        }
    }
}