using System.Threading.Tasks;
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

        public async Task<IActionResult> CreatePayLevel()
        {
            var allowance = await _allowanceService.GetAsync();
            ViewData["Allowance"] = new SelectList(allowance.Data, "Id", "AllowanceName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayLevel(CreatePayLevelRequestModel model)
        {
            return View(await _payLevelService.CreateAsync(model));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPayLevel()
        {
            return View(await _payLevelService.GetAsync());
        }
    }
}