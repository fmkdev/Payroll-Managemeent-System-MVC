using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class PayLevelController : Controller
    {
        private readonly IPayLevelService _payLevelService;
        private readonly IAllowanceService _allowanceService;

        public PayLevelController(IPayLevelService payLevelService, IAllowanceService allowanceService)
        {
            _payLevelService = payLevelService;
            _allowanceService =allowanceService;
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreatePayLevel()
        {
            var allowance = await _allowanceService.GetAsync();
            ViewData["Allowance"] = new SelectList(allowance.Data, "Id", "AllowanceName");

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreatePayLevel(CreatePayLevelRequestModel model)
        {
            var pl = await _payLevelService.CreateAsync(model);
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllPayLevel()
        {
            var pl = await _payLevelService.GetAsync();
            return View(pl.Data);
        }
    }
}