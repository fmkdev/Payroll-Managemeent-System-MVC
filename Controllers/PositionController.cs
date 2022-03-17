using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;
        private readonly IAllowanceService _allowanceService;

        public PositionController(IPositionService positionService, IAllowanceService allowanceService)
        {
            _positionService = positionService;
            _allowanceService = allowanceService;
        }

        public async Task<IActionResult> CreatePosition()
        {
            var allowance = await _allowanceService.GetAsync();
            ViewData["Allowance"] = new SelectList(allowance.Data, "Id", "AllowanceName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePosition(CreatePositionRequestModel model)
        { 
            return View(await _positionService.CreateAsync(model));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPosition()
        {
            return View(await _positionService.GetAsync());
        }
    }
}