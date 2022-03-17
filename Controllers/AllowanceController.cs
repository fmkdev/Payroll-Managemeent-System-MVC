using System.Threading.Tasks;
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

        [HttpPost]
        public async Task<IActionResult> CreateAllowance(CreateAllowanceRequestModel model)
        {
            return View(await _allowanceService.CreateAsync(model));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAllowance()
        {
            return View(await _allowanceService.GetAsync());
        }
    }
}