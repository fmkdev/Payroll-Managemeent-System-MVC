using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IAllowanceRepository _allowanceRepository;

        public PositionService(IPositionRepository positionRepository,
        IAllowanceRepository allowanceRepository)
        {
            _positionRepository = positionRepository;
            _allowanceRepository = allowanceRepository;
        }
        public async Task<BaseResponse<bool>> CreateAsync(CreatePositionRequestModel model)
        {
            var position = await _positionRepository.GetAsync(model.PositionName);
            if (position != null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Successfull"
                };
            }
            var post = new Position
            {
                Name = model.PositionName,
                Description = model.Description,
                MaxRequestDaysPerAnnum = model.MaxRequestDaysPerAnnum
            };

            var allowance = await _allowanceRepository.GetAsync(model.Allowances);
            foreach (var item in allowance)
            {
                var positionAllowance = new PositionAllowance
                {
                    PositionId = post.Id,
                    Position = post,
                    Allowance = item,
                    AllowanceId = item.Id
                };
                post.PositionAllowances.Add(positionAllowance);
            }
            
            await _positionRepository.CreateAsync(post);

            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Created Successfully"
            };
        }

        public async Task<BaseResponse<IEnumerable<PositionDTO>>> GetAsync()
        {
            var position = await _positionRepository.GetAsync();
            return new BaseResponse<IEnumerable<PositionDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = position
            };
        }
    }
}