using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IOtherDeductionService
    {
        Task<BaseResponse<bool>> CreateAsync(int employeeId, CreateOtherDeductionRequestModel model);

        Task<BaseResponse<IEnumerable<OtherDeductionDTO>>> GetAsync(int EmployeeId, int month);
    }
}