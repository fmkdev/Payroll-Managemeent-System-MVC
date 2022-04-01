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

        public Task<IEnumerable<PayrollDTO>> GetAsync(DateTime month)
        {
           return null;
        }

        public async Task<IEnumerable<PayrollDTO>> GetAsync()
        { 
            var month = DateTime.UtcNow.Month;
            return await _context.Payrolls.Where(b => b.Month == month).Select(payroll => new PayrollDTO
            {
                Id = payroll.Id,
                TransactionId = payroll.TransactionId,
                EmployeeCardId = payroll.EmployeeCardId,
                EmployeeBasicPay = payroll.EmployeeBasicPay,
                OtherDeduction = payroll.OtherDeduction,
                Tax = payroll.Tax,
                TotalAllowance = payroll.TotalAllowance,
                TotalBonus = payroll.TotalBonus,
                GrossPay = payroll.GrossPay,
                ReinbursementDate = payroll.ReinbursementDate  
            }).ToListAsync();
        }

        public async Task<IEnumerable<PayrollDTO>> GetAsync(string EmployeeCardId)
        {
            return await _context.Payrolls.Where(b => b.EmployeeCardId == EmployeeCardId).Select(payroll => new PayrollDTO
            {
                Id = payroll.Id,
                TransactionId = payroll.TransactionId,
                EmployeeCardId = payroll.EmployeeCardId,
                EmployeeBasicPay = payroll.EmployeeBasicPay,
                OtherDeduction = payroll.OtherDeduction,
                Tax = payroll.Tax,
                TotalAllowance = payroll.TotalAllowance,
                TotalBonus = payroll.TotalBonus,
                GrossPay = payroll.GrossPay,
                ReinbursementDate = payroll.ReinbursementDate  
            }).ToListAsync();
        }
    }
}