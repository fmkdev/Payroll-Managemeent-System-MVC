using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayxApi.ContextDb;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly ContextApp _context;

        public AppointmentRepository(ContextApp contextApp)
        {
            _context = contextApp;
        }
        public async Task<bool> CreateAsync(Appointment appointment)
        {
            await _context.Appointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Appointment> GetAsync(string name)
        {
            return await _context.Appointments.SingleOrDefaultAsync(a => a.AppointmentName == name && a.IsDeleted == false);
        }

        public async Task<IEnumerable<AppointmentDTO>> GetAsync()
        {
            return await _context.Appointments.Select(appointment => new AppointmentDTO
            {
                Id = appointment.Id,
                AppointmentName = appointment.AppointmentName,
                Description = appointment.Description
            }).ToListAsync();
        }
    }
}