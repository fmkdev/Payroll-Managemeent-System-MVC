using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<BaseResponse<bool>> CreateAsync(CreateEmployeeRequestModel model);

        Task<BaseResponse<bool>> UpdateAsync(int id, UpdateEmployeeRequestModel model);

        void DeleteAsync(int id);

        Task<BaseResponse<EmployeeDTO>> GetAsync(int id);

        Task<BaseResponse<EmployeeDTO>> GetAsync(string UserCardId);
        
        Task<IEnumerable<EmployeeDTO>> GetAsync();

        Task<BaseResponse<int>> GetAllNumberOfEmployeeAsync();

        Task<BaseResponse<decimal>> GetBiWeeklyReinbursement();

        Task<BaseResponse<decimal>> GetWeeklyReinbursement();
        
        Task<BaseResponse<decimal>> GetMonthlyReinbursement();
    }
}