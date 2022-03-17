using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IAppointmentService
    {
        Task<BaseResponse<bool>> CreateAsync(CreateAppointmentRequestModel model);
        Task<BaseResponse<IEnumerable<AppointmentDTO>>> GetAsync();
    }
}