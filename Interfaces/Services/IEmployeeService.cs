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
        
        Task<IEnumerable<EmployeeDTO>> GetAsync();
    }
}