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
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ContextApp _context;
        public DepartmentRepository(ContextApp context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Department department)
        {
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<DepartmentDTO> GetAsync(int id)
        {
            var department = await _context.Departments
            .SingleOrDefaultAsync(e => e.Id == id);

            return new DepartmentDTO
            {
                Name = department.Name,
                Description = department.Description
            };
        }

        public async Task<DepartmentDTO> GetAsync(string name)
        {
            var department = await _context.Departments
            .SingleOrDefaultAsync(e => e.Name == name);
            if(department == null)
            {
                return null;
            }
            return new DepartmentDTO
            {
                Name = department.Name,
                Description = department.Description
            };
        }

        public async Task<IEnumerable<DepartmentDTO>> GetAsync()
        {
            return await _context.Departments.Where(r => r.IsDeleted == false).Select(r => new DepartmentDTO{
                Id = r.Id,
                Name = r.Name,
                Description = r.Description
            }).ToListAsync();
        }

        public async Task<IEnumerable<DepartmentDTO>> GetEmployeeByDepartmentAsync()
        {
            return await _context.Departments.Include(e => e.Employees).Select(dept => new DepartmentDTO
            {
                Id = dept.Id,
                Name = dept.Name,
                NumberOfEmployees = dept.Employees.Count()
            }).ToListAsync();
        }
    }
}