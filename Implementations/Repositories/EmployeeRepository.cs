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
            .Include(b => b.AccountDetails)
            .Include(c => c.Address)
            .Include(e => e.PayLevel)
            .Include(f => f.Appointment).SingleOrDefaultAsync(b => b.Id == id && b.IsDeleted == false);

            return new EmployeeDTO
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                EmployeeCardId = employee.CardId,
                FullName = $"{employee.FirstName} {employee.LastName}",
                PhoneNumber = employee.PhoneNumber,
                Email = employee.Email,
                Gender = employee.Gender,
                MaritalStatus = employee.MaritalStatus,
                AppointmentName = employee.Appointment.AppointmentName,
                PaymentType = employee.PaymentType,
                PayLevelName = employee.PayLevel.LevelName,
                PositionName = employee.Position.Name,
                DepartmentName = employee.Department.Name,

                BankName = employee.AccountDetails.BankName,
                AccountNumber = employee.AccountDetails.AccountNumber,

                HouseNumber = employee.Address.HomeNumber,
                StreetName = employee.Address.StreetName,
                City = employee.Address.City,
                State = employee.Address.City,
                Nationality = employee.Address.Nationality,
                HomeNumber = employee.Address.HomeNumber,
                LocalGovernment = employee.Address.LocalGovernment
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
            return await _context.Employees.Include(b => b.WorkingDays).Include(l => l.Ledger).SingleOrDefaultAsync(e => e.Id == id && e.IsDeleted == false);
        }
        public async Task<Employee> GetDeletedAsync(int id)
        {
            return await _context.Employees.Include(b => b.WorkingDays).SingleOrDefaultAsync(e => e.Id == id && e.IsDeleted == true);
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAsync()
        {
            return await _context.Employees
            .Include(a => a.Position)
            .Include(d => d.Department)
            .Include(b => b.AccountDetails)
            .Include(c => c.Address)
            .Include(e => e.PayLevel)
            .Include(f => f.Appointment)
            .Include(l => l.Ledger)
            .Where(e => e.IsDeleted == false).Select(employee => new EmployeeDTO
            {
                LedgerId = employee.Ledger.Id,
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                EmployeeCardId = employee.CardId,
                FullName = $"{employee.FirstName} {employee.LastName}",
                PhoneNumber = employee.PhoneNumber,
                Email = employee.Email,
                Gender = employee.Gender,
                MaritalStatus = employee.MaritalStatus,
                AppointmentName = employee.Appointment.AppointmentName,
                PaymentType = employee.PaymentType,
                PayLevelName = employee.PayLevel.LevelName,
                PositionName = employee.Position.Name,
                DepartmentName = employee.Department.Name,

                BankName = employee.AccountDetails.BankName,
                AccountNumber = employee.AccountDetails.AccountNumber,

                HouseNumber = employee.Address.HomeNumber,
                StreetName = employee.Address.StreetName,
                City = employee.Address.City,
                State = employee.Address.City,
                Nationality = employee.Address.Nationality,
                HomeNumber = employee.Address.HomeNumber,
                LocalGovernment = employee.Address.LocalGovernment
            }).ToListAsync();

        }

        public async Task<EmployeeDTO> GetAsync(string UserCardId)
        {
            var employee = await _context.Employees
            .Include(a => a.Position)
            .Include(d => d.Department)
            .Include(b => b.AccountDetails)
            .Include(c => c.Address)
            .Include(e => e.PayLevel)
            .Include(f => f.Appointment)
            .SingleOrDefaultAsync(e => e.CardId == UserCardId && e.IsDeleted == false);

            return new EmployeeDTO
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                EmployeeCardId = employee.CardId,
                FullName = $"{employee.FirstName} {employee.LastName}",
                PhoneNumber = employee.PhoneNumber,
                Email = employee.Email,
                Gender = employee.Gender,
                MaritalStatus = employee.MaritalStatus,
                AppointmentName = employee.Appointment.AppointmentName,
                PaymentType = employee.PaymentType,
                PayLevelName = employee.PayLevel.LevelName,
                PositionName = employee.Position.Name,
                DepartmentName = employee.Department.Name,

                BankName = employee.AccountDetails.BankName,
                AccountNumber = employee.AccountDetails.AccountNumber,

                HouseNumber = employee.Address.HomeNumber,
                StreetName = employee.Address.StreetName,
                City = employee.Address.City,
                State = employee.Address.City,
                Nationality = employee.Address.Nationality,
                HomeNumber = employee.Address.HomeNumber,
                LocalGovernment = employee.Address.LocalGovernment
            };
        }

        public async Task<int> GetAllNumberOfEmployeeAsync()
        {
            return await _context.Employees.CountAsync(b => b.IsDeleted == false);
        }

        public async Task<IEnumerable<EmployeeDTO>> GetLastBiWeekReinBursement()
        {
            var ANY = await _context.Employees.Include(p => p.Payrolls)
            .Where(p => p.PaymentType == PaymentType.BiWeekly && p.Payrolls.Count() > 0)
            .AnyAsync();

            if (ANY == true)
            {
                var amp = await _context.Employees.Include(p => p.Payrolls)
                .Where(pa => pa.PaymentType == PaymentType.BiWeekly && pa.IsDeleted == false)
                .Select(emp => new EmployeeDTO
                {
                    BiWeeklyReinbursementAmount = emp.Payrolls.OrderBy(b => b.Id).LastOrDefault().GrossPay
                }).ToListAsync();
                return amp;
            }
            return null;

        }

        public async Task<IEnumerable<EmployeeDTO>> GetLastWeekReinBursement()
        {
            var ANY = await _context.Employees.Include(p => p.Payrolls)
            .Where(p => p.PaymentType == PaymentType.weekly && p.Payrolls.Count() > 0)
            .AnyAsync();

            if (ANY == true)
            {
                var amp = await _context.Employees.Include(p => p.Payrolls)
                .Where(pa => pa.PaymentType == PaymentType.weekly && pa.IsDeleted == false)
                .Select(emp => new EmployeeDTO
                {
                    BiWeeklyReinbursementAmount = emp.Payrolls.OrderBy(b => b.Id).LastOrDefault().GrossPay
                }).ToListAsync();
                return amp;
            }
            return null;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetLastMonthReinBursement()
        {
            var ANY = await _context.Employees.Include(p => p.Payrolls)
            .Where(p => p.PaymentType == PaymentType.Monthly && p.Payrolls.Count() > 0)
            .AnyAsync();
            
            if (ANY == true)
            {
                var amp = await _context.Employees.Include(p => p.Payrolls)
                .Where(pa => pa.PaymentType == PaymentType.Monthly && pa.IsDeleted == false)
                .Select(emp => new EmployeeDTO
                {
                    BiWeeklyReinbursementAmount = emp.Payrolls.OrderBy(b => b.Id).LastOrDefault().GrossPay
                }).ToListAsync();
                return amp;
            }
            return null;
        }

        public async Task<IEnumerable<EmployeeDTO>> GetDeletedEmployee()
        {
            return await _context.Employees.Where(b => b.IsDeleted == true)
            .Select(employee => new EmployeeDTO
            {
                Id = employee.Id,
                EmployeeCardId = employee.CardId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                PhoneNumber = employee.PhoneNumber,
                Email = employee.Email,
                PositionName = employee.Position.Name,
                DepartmentName = employee.Department.Name
            }).ToListAsync();
        }

        public async Task<EmployeeDTO> GetGivenBonus(int id)
        {
            var bonus = await _context.Employees.Include(b => b.Bonus)
            .Where(e => e.Id == id && e.IsDeleted == false)
            .Select(employee => new EmployeeDTO
            {
                FullName = $"{employee.FirstName} {employee.LastName}",
                EmployeeCardId = employee.CardId,
                Bonuses = employee.Bonus.Where(s => s.BDStatus == Enum.BDStatus.Given)
                .Select(bonus => new BonusDTO
                {
                    BonusName = bonus.BonusName,
                    Amount = bonus.Amount
                }).ToList()
            }).SingleOrDefaultAsync();
            return bonus;
        }

        public async Task<EmployeeDTO> GetGivenDeductions(int id)
        {
            var bonus = await _context.Employees.Include(b => b.OtherDeductions)
            .Where(e => e.Id == id && e.IsDeleted == false)
            .Select(employee => new EmployeeDTO
            {
                FullName = $"{employee.FirstName} {employee.LastName}",
                EmployeeCardId = employee.CardId,
                OtherDeductions = employee.OtherDeductions.Where(s => s.BDStatus == Enum.BDStatus.Given)
                .Select(bonus => new OtherDeductionDTO
                {
                    DeductionName = bonus.DeductionName,
                    Amount = bonus.Amount
                }).ToList()
            }).SingleOrDefaultAsync();
            return bonus;
        }

        public async Task<EmployeeDTO> GetPaidBonus(int id)
        {
            var bonus = await _context.Employees.Include(b => b.OtherDeductions)
            .Where(e => e.Id == id && e.IsDeleted == false)
            .Select(employee => new EmployeeDTO
            {
                FullName = $"{employee.FirstName} {employee.LastName}",
                EmployeeCardId = employee.CardId,
                OtherDeductions = employee.OtherDeductions.Where(s => s.BDStatus == Enum.BDStatus.Given)
                .Select(bonus => new OtherDeductionDTO
                {
                    DeductionName = bonus.DeductionName,
                    Amount = bonus.Amount
                }).ToList()
            }).SingleOrDefaultAsync();
            return bonus;
        }

        public async Task<EmployeeDTO> GetPaidDeductions(int id)
        {
            var bonus = await _context.Employees.Include(b => b.OtherDeductions)
            .Where(e => e.Id == id && e.IsDeleted == false)
            .Select(employee => new EmployeeDTO
            {
                FullName = $"{employee.FirstName} {employee.LastName}",
                EmployeeCardId = employee.CardId,
                OtherDeductions = employee.OtherDeductions.Where(s => s.BDStatus == Enum.BDStatus.Given)
                .Select(bonus => new OtherDeductionDTO
                {
                    DeductionName = bonus.DeductionName,
                    Amount = bonus.Amount
                }).ToList()
            }).SingleOrDefaultAsync();
            return bonus;
        }
    }
}