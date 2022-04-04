using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IDepartmentService
    {
        Task<BaseResponse<bool>> CreateAsync(CreateDepartmentRequestModel model);

        Task<BaseResponse<IEnumerable<DepartmentDTO>>> GetAsync();

        Task<BaseResponse<IEnumerable<DepartmentDTO>>> GetEmployeeByDepartmentAsync();
    }
}