using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<BaseResponse<bool>> CreateAsync(CreateDepartmentRequestModel model)
        {
            var department = await _departmentRepository.GetAsync(model.Name);
            if (department != null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Already Exist"
                };
            }
            var dept = new Department
            {
                Name = model.Name,
                Description = model.Description
            };
            await _departmentRepository.CreateAsync(dept);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Created Successfully"
            };
        }

        public async Task<BaseResponse<IEnumerable<DepartmentDTO>>> GetAsync()
        {
            var department = await _departmentRepository.GetAsync();
            return new BaseResponse<IEnumerable<DepartmentDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = department
            };
        }
    }
}