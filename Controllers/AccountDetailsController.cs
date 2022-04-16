using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class AccountDetailsController : Controller
    {
        private readonly IAccountDetailsService _accountDetailsService;

        public AccountDetailsController(IAccountDetailsService accountDetailsService)
        {
            _accountDetailsService = accountDetailsService;
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet("UpdateAccountDetails/{employeeId}")]
        public async Task<IActionResult> UpdateAccountDetails(int employeeId)
        {
            var employee = await _accountDetailsService.GetAsync(employeeId);
            return View(employee.Data);
        }
        //[Authorize(Roles = "Admin")]
        [HttpPost("UpdateAccountDetails/{employeeId}")]
        public async Task<IActionResult> UpdateAccountDetails(int employeeId, UpdateAccountDetailsRequestModel model)
        {
            var acc = await _accountDetailsService.UpdateeAsync(employeeId, model);
            return RedirectToAction("GetAllEmployee", "Employee");
        }

    }
}