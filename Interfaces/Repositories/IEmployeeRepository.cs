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

        Task<EmployeeDTO> GetAsync(string UserCardId);

        Task<Employee> GetAsync(int id);

        Task<Employee> GetDeletedAsync(int id);

        Task<IEnumerable<EmployeeDTO>> GetAsync();

        Task<int> GetAllNumberOfEmployeeAsync();
        
        Task<IEnumerable<EmployeeDTO>> GetAllPaysAsync();

        Task<IEnumerable<EmployeeDTO>> GetLastBiWeekReinBursement();

        Task<IEnumerable<EmployeeDTO>> GetLastWeekReinBursement();
        
        Task<IEnumerable<EmployeeDTO>> GetLastMonthReinBursement();

        Task<IEnumerable<EmployeeDTO>> GetDeletedEmployee();

        Task<EmployeeDTO> GetGivenBonus(int id);

        Task<EmployeeDTO> GetGivenDeductions(int id);

        Task<EmployeeDTO> GetPaidBonus(int id);

        Task<EmployeeDTO> GetPaidDeductions(int id);
    }
}