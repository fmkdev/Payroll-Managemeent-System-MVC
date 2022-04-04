using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Services
{
    public interface IPayrollService
    {
        Task<BaseResponse<bool>> GeneratePayrollForBiWeeklyPayee();
        
        Task<BaseResponse<bool>> GeneratePayrollForWeeklyPayee();

        Task<BaseResponse<bool>> GeneratePayrollForMonthlyPayee();

        Task<BaseResponse<IEnumerable<PayrollDTO>>> GetAsync();

        Task<BaseResponse<IEnumerable<PayrollDTO>>> GetAsync(string EmployeeCardId);
    }
}