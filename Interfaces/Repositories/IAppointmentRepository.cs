using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IAppointmentRepository
    {
        Task<bool> CreateAsync(Appointment appointment);
        Task<Appointment> GetAsync(string name);
        Task<IEnumerable<AppointmentDTO>> GetAsync();
    }
}