using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class WorkingDaysController : Controller
    {
        private readonly IWorkingDaysService _workingDaysService;

        public WorkingDaysController(IWorkingDaysService workingDaysService)
        {
            _workingDaysService = workingDaysService;
        }

        [HttpPatch("{userId}")]
        public async Task<IActionResult> MakeRequest([FromRoute] int userId, [FromBody] MakeRequsetModel model)
        {
            return Ok(await _workingDaysService.MakeRequestAsync(userId, model));
        }

        [HttpPatch]
        public async Task<IActionResult> SignIn(SignRequestModel model)
        {

            return Ok(await _workingDaysService.SignInAsync(model.UserCardId));
        }
        
        [HttpPatch]
        public async Task<IActionResult> SignOut(SignRequestModel model)
        {

            return Ok(await _workingDaysService.SignOutAsync(model.UserCardId));
        }

        [HttpPatch]
        public async Task<IActionResult> ConfirmRequest(ApproveRequestModel model)
        {

            return Ok(await _workingDaysService.ApproveEmployeeRequestAsync(model));
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployeeCalendarByDate()
        {
            var date = DateTime.UtcNow;
            return Ok(await _workingDaysService.GetAsync(date));
        }
    }
}