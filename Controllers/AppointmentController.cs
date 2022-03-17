using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        public IActionResult CreateAppointment()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppointment(CreateAppointmentRequestModel model)
        { 
            return View(await _appointmentService.CreateAsync(model));
        }
    }
}