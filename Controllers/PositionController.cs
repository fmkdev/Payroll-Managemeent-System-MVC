using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreatePosition()
        {
            var allowance = await _allowanceService.GetAsync();
            ViewData["Allowance"] = new SelectList(allowance.Data, "Id", "AllowanceName");

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreatePosition(CreatePositionRequestModel model)
        { 
            var pos = await _positionService.CreateAsync(model);
            if(pos.IsSuccess == true)
            {
                ViewBag.Success = " Created Successfully";
            }
            ViewBag.Success = "Not Created ";
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllPosition()
        {
            var pos = await _positionService.GetAsync();
            return View(pos.Data);
        }
    }
}