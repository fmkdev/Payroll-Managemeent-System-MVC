using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentrepository;

        public AppointmentService(IAppointmentRepository appointmentrepository)
        {
            _appointmentrepository = appointmentrepository;
        }
        public async Task<BaseResponse<bool>> CreateAsync(CreateAppointmentRequestModel model)
        {
            var app = await _appointmentrepository.GetAsync(model.AppointmentName);

            if (app != null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Appointment name already exist",
                    Data = false
                };
            }
            var appointment = new Appointment
            {
                AppointmentName = model.AppointmentName,
                Description = model.Description
            };

            await _appointmentrepository.CreateAsync(appointment);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Succesfully Created",
                Data = true
            };
        }

        public async Task<BaseResponse<IEnumerable<AppointmentDTO>>> GetAsync()
        {
            var appointment = await _appointmentrepository.GetAsync();
            return new BaseResponse<IEnumerable<AppointmentDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = appointment
            };
        }
    }
}