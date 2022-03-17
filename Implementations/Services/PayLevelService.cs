using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class PayLevelService : IPayLevelService
    {
        private readonly IPayLevelRepository _payLevelRepository;
        private readonly IAllowanceRepository _allowanceRepository;

        public PayLevelService(IPayLevelRepository payLevelRepository, IAllowanceRepository allowanceRepository)
        {
            _payLevelRepository = payLevelRepository;
            _allowanceRepository = allowanceRepository;
        }
        public async Task<BaseResponse<PayLevelDTO>> CreateAsync(CreatePayLevelRequestModel model)
        {
            if (model.LevelName == null || model.BasicSalary == 0 || model.Description == null || model.AllowanceIds == null)
            {
                return new BaseResponse<PayLevelDTO>
                {
                    IsSuccess = false,
                    Message = "Entries cant be null",
                    Data = null
                };
            }
            var payLevel = new PayLevel
            {
                LevelName = model.LevelName,
                BasicSalary = model.BasicSalary,
                Description = model.Description,
                MaxRequestDaysPerAnnum = model.MaxRequestDaysPerAnnum,
                TaxPercentage = model.TaxPercentage
            };

            var allowance = await _allowanceRepository.GetAsync(model.AllowanceIds);
            foreach (var item in allowance)
            {
                var AllowancePayLevel = new AllowancePayLevel
                {
                    PayLevelId = payLevel.Id,
                    PayLevel = payLevel,
                    AllowanceId = item.Id,
                    Allowance = item
                };
                payLevel.AllowancePayLevels.Add(AllowancePayLevel);
            }

            await _payLevelRepository.CreateAsync(payLevel);
            return new BaseResponse<PayLevelDTO>
            {
                IsSuccess = true,
                Message = $"Pay Level named {model.LevelName} created successfully",
                Data = new PayLevelDTO
                {
                    LevelName = model.LevelName,
                    BasicSalary = model.BasicSalary,
                    Description = model.Description
                }
            };
        }

        public async Task<BaseResponse<IEnumerable<PayLevelDTO>>> GetAsync()
        {
            var payLevel = await _payLevelRepository.GetAsync();
            return new BaseResponse<IEnumerable<PayLevelDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = payLevel
            };
        }
    }
}