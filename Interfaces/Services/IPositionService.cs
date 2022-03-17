using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Services
{
    public interface IPositionService
    {
        Task<BaseResponse<bool>> CreateAsync(CreatePositionRequestModel model);

        Task<BaseResponse<IEnumerable<PositionDTO>>> GetAsync();
    }
}