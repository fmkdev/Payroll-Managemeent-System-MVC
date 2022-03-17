using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IOtherDeductionRepository
    {
        Task<bool> CreateAsync(OtherDeduction otherDeduction);

        Task<IEnumerable<OtherDeductionDTO>> GetAsync(int EmployeeId, int month);
    }
}