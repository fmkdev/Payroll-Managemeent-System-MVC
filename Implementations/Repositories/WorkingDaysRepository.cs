using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayxApi.ContextDb;
using PayxApi.DTOs;
using PayxApi.Enum;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class WorkingDaysRepository : IWorkingDaysRepository
    {
        private readonly ContextApp _context;

        public WorkingDaysRepository(ContextApp context)
        {
            _context = context;
        }
        public async Task<bool> CreateAsync(WorkingDays workingDays)
        {
            await _context.workingDays.AddAsync(workingDays);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<WorkingDays>> GetAsync(int id)
        {
            return await _context.workingDays.Where(u => u.EmployeeId == id && u.IsDeleted == false).ToListAsync();
        }

        public async Task<WorkingDays> GetAsync(string cardId, DateTime date)
        {
            return await _context.workingDays.SingleOrDefaultAsync(u => u.EmployeeCardId == cardId && u.WorkDate == date.Date);
        }

        public async Task<IEnumerable<WorkingDays>> GetAsync(string cardId)
        {
            return await _context.workingDays.Where(e => e.EmployeeCardId == cardId && e.IsDeleted == false).ToListAsync();
        }

        public async Task<IEnumerable<WorkingDaysDTO>> GetAsync(DateTime date)
        {
            return await _context.workingDays.Where(c => c.WorkDate == date.Date && c.IsDeleted ==false)
            .Select(w => new WorkingDaysDTO
            {
                EmployeeFullName = w.EmployeeFullName,
                EmployeeCardId = w.EmployeeCardId,
                WorkDate = w.WorkDate,
                WorkStatus = w.WorkStatus,
                DayStatus = w.DayStatus,
                SignInTime = w.SignInTime,
                SigOutTime = w.SigOutTime,
                RequestStatus = w.RequestStatus,
                Request = w.Request
            }).ToListAsync();
        }

        public async Task<IEnumerable<WorkingDays>> GetInitializedApprovalStatusAsync(string cardId)
        {
            return await _context.workingDays.Where(e => e.EmployeeCardId == cardId && 
            e.ApprovalStatus == ApprovalStatus.Initialized && e.IsDeleted == false).ToListAsync();
        }

        public async Task<bool> UpdateAsync(WorkingDays workingDays)
        {
            _context.workingDays.Update(workingDays);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(IList<WorkingDays> workingDays)
        {
            _context.workingDays.UpdateRange(workingDays);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
