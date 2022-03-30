using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class BonusController : Controller
    {
        private readonly IBonusService _bonusService;
        private readonly IEmployeeService _employeeService;

        public BonusController(IBonusService bonusService, IEmployeeService employeeService)
        {
            _bonusService = bonusService;
            _employeeService = employeeService;
        }

        [HttpGet("CreateBonus/{employeeId}")]
        public IActionResult CreateBonus()
        {
            return View();
        }

        [HttpPost("CreateBonus/{employeeId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateBonus(int employeeId, CreateBonusRequestModel model)
        {
            await _bonusService.CreateAsync(employeeId, model);
            return RedirectToAction("AllEmployee", "Bonus");
        }

        [HttpPost("{employeeId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetEmployeeBonusByMonth(int employeeId)
        {
            var month = DateTime.UtcNow;
            return View(await _bonusService.GetAsync(employeeId, month.Month));
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AllEmployee()
        {
            return View(await _employeeService.GetAsync());
        }
    }
}