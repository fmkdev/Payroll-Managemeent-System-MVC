using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<BaseResponse<bool>> CreateAsync(CreateEmployeeRequestModel model);

        Task<BaseResponse<bool>> UpdateAsync(int id, UpdateEmployeeRequestModel model);

        Task<BaseResponse<bool>> DeleteAsync(int id);

        Task<BaseResponse<bool>> UnDeleteAsync(int id);

        Task<BaseResponse<EmployeeDTO>> GetAsync(int id);

        Task<BaseResponse<EmployeeDTO>> GetAsync(string UserCardId);
        
        Task<BaseResponse<IEnumerable<EmployeeDTO>>> GetAsync();

        Task<BaseResponse<IEnumerable<EmployeeDTO>>> GetDeletedAsync();

        Task<BaseResponse<int>> GetAllNumberOfEmployeeAsync();

        Task<BaseResponse<decimal?>> GetBiWeeklyReinbursement();

        Task<BaseResponse<decimal?>> GetWeeklyReinbursement();
        
        Task<BaseResponse<decimal?>> GetMonthlyReinbursement();

        Task<BaseResponse<EmployeeDTO>> GetEmployeeGivenBonus(int id);

        Task<BaseResponse<EmployeeDTO>> GetEmployeeGivenDeductions(int id);

        Task<BaseResponse<EmployeeDTO>> GetEmployeePaidBonus(int id);

        Task<BaseResponse<EmployeeDTO>> GetEmployeePaidDeductions(int id);

        Task<BaseResponse<EmployeeDTO>> GetGivenDeductionsAndBonus(int id);

        Task<BaseResponse<EmployeeDTO>> GetEmployeeAllowance(int id);
    }
}