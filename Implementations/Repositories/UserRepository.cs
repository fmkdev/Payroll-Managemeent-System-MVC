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
    public class UserRepository : IUserRepository
    {
        private readonly ContextApp _context;
        public UserRepository(ContextApp context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<UserDTO> GetDtoAsync(int userId)
        {
             var user = await _context.Users
            .Include(a => a.Employee)
            .ThenInclude(p => p.Position)
            .Include(ae => ae.Employee)
            .ThenInclude(d => d.Department)
            .Include(u => u.UserRoles)
            .ThenInclude(r => r.Role)
            .Include(c => c.Employee)
            .ThenInclude(d => d.Address)
            .Include(c => c.Employee)
            .ThenInclude(d => d.AccountDetails)
            .Include(c => c.Employee)
            .ThenInclude(d => d.PayLevel)
            .SingleOrDefaultAsync(e => e.Id == userId && e.IsDeleted == false);
            if(user == null)
            {
                return null;
            }
            return new UserDTO
            {
                Id = user.Id,
                FullName = $"{user.FirstName} {user.LastName}",
                Password = user.Password,
                Email = user.Email,
                EmployeeCardId = user.EmployeeCardId,
                Employee = new EmployeeDTO
                {
                    FirstName = user.Employee.FirstName,
                    LastName = user.Employee.LastName,
                    Email = user.Employee.Email,
                    EmployeeCardId = user.Employee.CardId,
                    PositionName = user.Employee.Position.Name,
                    DepartmentName = user.Employee.Department.Name
                },
                Account = new AccountDetailsDTO
                {
                    AccountNumber = user.Employee.AccountDetails.AccountNumber,
                    BankName = user.Employee.AccountDetails.BankName
                },
                Address = new AddressDTO
                {
                    HouseNumber = user.Employee.Address.HouseNumber,
                    StreetName = user.Employee.Address.StreetName,
                    City = user.Employee.Address.City,
                    State = user.Employee.Address.State,
                    Nationality = user.Employee.Address.Nationality,
                    HomeNumber = user.Employee.Address.HomeNumber,
                    LocalGovernment = user.Employee.Address.LocalGovernment,
                },
                UserRoles = user.UserRoles.Select(role => new RoleDTO
                {
                    Name = role.Role.Name
                }).ToList()
            };
        }

        public async Task<UserDTO> GetAsync(string userEmailOrCardId)
        {
            var user = await _context.Users
            .Include(a => a.Employee)
            .ThenInclude(p => p.Position)
            .Include(ae => ae.Employee)
            .ThenInclude(d => d.Department)
            .Include(u => u.UserRoles)
            .ThenInclude(r => r.Role)
            .Include(c => c.Employee)
            .ThenInclude(d => d.Address)
            .Include(c => c.Employee)
            .ThenInclude(d => d.AccountDetails)
            .Include(c => c.Employee)
            .ThenInclude(d => d.PayLevel)
            .SingleOrDefaultAsync(e => (e.Email == userEmailOrCardId || e.EmployeeCardId == userEmailOrCardId) && e.IsDeleted == false);
            if(user == null)
            {
                return null;
            }
            return new UserDTO
            {
                Id = user.Id,
                FullName = $"{user.FirstName} {user.LastName}",
                Password = user.Password,
                Email = user.Email,
                EmployeeCardId = user.EmployeeCardId,
                Employee = new EmployeeDTO
                {
                    FirstName = user.Employee.FirstName,
                    LastName = user.Employee.LastName,
                    Email = user.Employee.Email,
                    EmployeeCardId = user.Employee.CardId,
                    PositionName = user.Employee.Position.Name,
                    DepartmentName = user.Employee.Department.Name
                },
                Account = new AccountDetailsDTO
                {
                    AccountNumber = user.Employee.AccountDetails.AccountNumber,
                    BankName = user.Employee.AccountDetails.BankName
                },
                Address = new AddressDTO
                {
                    HouseNumber = user.Employee.Address.HouseNumber,
                    StreetName = user.Employee.Address.StreetName,
                    City = user.Employee.Address.City,
                    State = user.Employee.Address.State,
                    Nationality = user.Employee.Address.Nationality,
                    HomeNumber = user.Employee.Address.HomeNumber,
                    LocalGovernment = user.Employee.Address.LocalGovernment,
                },
                UserRoles = user.UserRoles.Select(role => new RoleDTO
                {
                    Name = role.Role.Name
                }).ToList()
            };
        }

        public async Task<User> GetAsync(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<bool> UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<UserDTO>> GetAsync()
        {
            return await _context.Users
            .Include(a => a.Employee)
            .ThenInclude(p => p.Position)
            .Include(ae => ae.Employee)
            .ThenInclude(d => d.Department)
            .Include(u => u.UserRoles)
            .ThenInclude(r => r.Role)
            .Include(c => c.Employee)
            .ThenInclude(d => d.Address)
            .Include(c => c.Employee)
            .ThenInclude(d => d.AccountDetails)
            .Include(c => c.Employee)
            .ThenInclude(d => d.PayLevel)
            .Where(u => u.IsDeleted == false).Select(user => new UserDTO
            {
                Id = user.Id,
                EmployeeCardId = user.EmployeeCardId,
                FullName = $"{user.FirstName} {user.LastName}",
                DepartmentName = user.Employee.Department.Name,
                PositionName = user.Employee.Position.Name

            }).ToListAsync();
        }
    }
}