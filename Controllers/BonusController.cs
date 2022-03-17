using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class BonusController : Controller
    {
        private readonly IBonusService _bonusService;

        public BonusController(IBonusService bonusService)
        {
            _bonusService = bonusService;
        }

        [HttpPost("{employeeId}")]
        public async Task<IActionResult> CreateBonus(int employeeId, CreateBonusRequestModel model)
        {
            return View(await _bonusService.CreateAsync(employeeId, model));
        }

        [HttpPost("{employeeId}")]
        public async Task<IActionResult> GetEmployeeBonusByMonth(int employeeId, DateTime month)
        {
            return View(await _bonusService.GetAsync(employeeId, month.Month));
        }
    }
}