using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class OtherDeductionService : IOtherDeductionService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IOtherDeductionRepository _otherDeductionRepository;

        public OtherDeductionService(IOtherDeductionRepository otherDeductionRepository, IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            _otherDeductionRepository = otherDeductionRepository;
        }
        public async Task<BaseResponse<bool>> CreateAsync(int employeeId, CreateOtherDeductionRequestModel model)
        {
            var employee = await _employeeRepository.GetAsync(employeeId);
            var otherDeduction = new OtherDeduction
            {
                EmployeeId = employeeId,
                Employee = employee,
                DeductionName = model.DeductionName,
                Amount = model.Amount,
                Date = DateTime.UtcNow,
                Month = DateTime.UtcNow.Month
            };
            await _otherDeductionRepository.CreateAsync(otherDeduction);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = $"{model.DeductionName} for {employee.FirstName} created successfully",
                Data = true
            };
        }

        public async Task<BaseResponse<IEnumerable<OtherDeductionDTO>>> GetAsync(int EmployeeId, int month)
        {
            if (EmployeeId == 0)
            {
                return new BaseResponse<IEnumerable<OtherDeductionDTO>>
                {
                    IsSuccess = false,
                    Message = "Null Id",
                    Data = null
                };
            }
            var otherDeduction = await _otherDeductionRepository.GetAsync(EmployeeId, month);
            return new BaseResponse<IEnumerable<OtherDeductionDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = otherDeduction
            };
        }
    }
}