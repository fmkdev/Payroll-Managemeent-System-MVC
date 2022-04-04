using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IDepartmentRepository
    {
        Task<bool> CreateAsync(Department department);

        Task<IEnumerable<DepartmentDTO>> GetAsync();

        Task<IEnumerable<DepartmentDTO>> GetEmployeeByDepartmentAsync();

        Task<DepartmentDTO> GetAsync(int id);
        
        Task<DepartmentDTO> GetAsync(string name);
    }
}