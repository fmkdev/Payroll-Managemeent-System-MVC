using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class AllowanceService : IAllowanceService
    {
        private readonly IAllowanceRepository _allowanceRepository;

        public AllowanceService(IAllowanceRepository allowanceRepository)
        {
            _allowanceRepository = allowanceRepository;
        }
        public async Task<BaseResponse<AllowanceDTO>> CreateAsync(CreateAllowanceRequestModel model)
        {
            if (model.AllowanceName == null && model.Amount == 0)
            {
                return new BaseResponse<AllowanceDTO>
                {
                    IsSuccess = false,
                    Message = $"Inputs needed!",
                    Data = null
                };
            }
            var allowance = new Allowance
            {
                AllowanceName = model.AllowanceName,
                Amount = model.Amount
            };
            await _allowanceRepository.Create(allowance);
            return new BaseResponse<AllowanceDTO>
            {
                IsSuccess = true,
                Message = $"{model.AllowanceName} Created successfully!",
                Data = new AllowanceDTO
                {
                    AllowanceName = model.AllowanceName,
                    Amount = model.Amount
                }
            };
        }

        public async Task<BaseResponse<IEnumerable<AllowanceDTO>>> GetAsync()
        {
            var allowance = await _allowanceRepository.GetAsync();
            return new BaseResponse<IEnumerable<AllowanceDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = allowance
            };
        }
    }
}