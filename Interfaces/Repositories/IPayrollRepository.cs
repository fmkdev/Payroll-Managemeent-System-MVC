using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IPayrollRepository
    {
        Task<bool> CreateAsync(Payroll payroll);

        Task<IEnumerable<Payroll>> GetAsync(DateTime month);
    }
}