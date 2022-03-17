using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task<bool> CreateAsync(Employee employee);

        Task<bool> UpdateAsync(Employee employee);

        void DeleteAsync(Employee employee);

        Task<EmployeeDTO> GetDtoAsync(int id);

        Task<Employee> GetAsync(int id);

        Task<IEnumerable<EmployeeDTO>> GetAsync();
        
        Task<IEnumerable<EmployeeDTO>> GetAllPaysAsync();
    }
}