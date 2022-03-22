using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class AllowanceController : Controller
    {
        private readonly IAllowanceService _allowanceService;

        public AllowanceController(IAllowanceService allowanceService)
        {
            _allowanceService = allowanceService;
        }

        public IActionResult CreateAllowance()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateAllowance(CreateAllowanceRequestModel model)
        {
            var allow = await _allowanceService.CreateAsync(model);
            return View();
        }
        
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAllAllowance()
        {
            var allow = await _allowanceService.GetAsync();
            return View();
        }
    }
}