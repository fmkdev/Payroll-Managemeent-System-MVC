using System;
using System.Threading.Tasks;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface ISalaryRepository
    {
        Task<bool> CreateAsync(Salary salary);
        Task<bool> UpdateAsync(Salary salary);
        Task<Salary> GetAsync(DateTime date);
    }
}