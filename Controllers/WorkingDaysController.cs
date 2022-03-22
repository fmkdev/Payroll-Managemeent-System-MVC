using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public IActionResult MakeRequest()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> MakeRequest( MakeRequsetModel model)
        {
            var userCardId = User.FindFirstValue(ClaimTypes.GivenName);
            var user = await _workingDaysService.MakeRequestAsync(userCardId, model);
            return RedirectToAction("Index", "User");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult SignOrSignOut()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SignIn(SignRequestModel model)
        {

            return Ok(await _workingDaysService.SignInAsync(model.UserCardId));
        }
        
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SignOut(SignRequestModel model)
        {

            return Ok(await _workingDaysService.SignOutAsync(model.UserCardId));
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApproveRequest(int employeeId)
        {
            var us = await _workingDaysService.ApproveRequestAsync(employeeId);

            return RedirectToAction("ViewAllRequest");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RejectRequest(int employeeId)
        {
            var us = await _workingDaysService.RejectRequestAsync(employeeId);

            return RedirectToAction("ViewAllRequest");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> TodaysAttendance()
        {
            var users = await _workingDaysService.GetAsync(DateTime.UtcNow);
            return View(users.Data);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ViewAllRequest()
        {
            var users = await _workingDaysService.GetAllRequestAsync();
            return View(users.Data);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ViewMyCalendar()
        {
            var cal = await _workingDaysService.ViewMyCalendar(User.FindFirstValue(ClaimTypes.GivenName));
            return View(cal.Data);
        }
    }
}