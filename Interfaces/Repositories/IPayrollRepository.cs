using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IPayrollRepository
    {
        Task<bool> CreateAsync(Payroll payroll);

        Task<bool> UpdateAsync(Payroll payroll);

        Task<IEnumerable<PayrollDTO>> GetAsync(DateTime month);

        Task<IEnumerable<PayrollDTO>> GetAsync();
        
        Task<IEnumerable<PayrollDTO>> GetAsync(string EmployeeCardId);
    }
}