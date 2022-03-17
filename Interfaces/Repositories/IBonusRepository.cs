using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IBonusRepository
    {
        Task<bool> CreateAsync(Bonus bonus);

        Task<IEnumerable<BonusDTO>> GetAsync(int EmployeeId, int month);
    }
}