using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        //[Authorize(Roles = "Admin")]
        public IActionResult CreateAppointment()
        {
            return View();
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateAppointment(CreateAppointmentRequestModel model)
        { 
            var appo = await _appointmentService.CreateAsync(model);
            if(appo.IsSuccess == true)
            {
                ViewBag.Success = " Created Successfully";
            }
            ViewBag.Success = "Not Created ";
            return View();
        }
    }
}