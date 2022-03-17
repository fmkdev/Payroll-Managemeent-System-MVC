using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Enum;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IWorkingDaysRepository
    {
        Task<bool> CreateAsync(WorkingDays workingDays);

        Task<bool> UpdateAsync(WorkingDays workingDays);

        Task<bool> UpdateAsync(IList<WorkingDays> workingDays);

        Task<IEnumerable<WorkingDays>> GetAsync(int id);

        Task<WorkingDays> GetAsync(string cardId, DateTime date);

        Task<IEnumerable<WorkingDays>> GetInitializedApprovalStatusAsync(string cardId);

        Task<IEnumerable<WorkingDays>> GetAsync(string cardId);

        Task<IEnumerable<WorkingDaysDTO>> GetAsync(DateTime date);
    }
}