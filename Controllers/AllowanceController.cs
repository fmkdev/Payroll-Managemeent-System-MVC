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

        [HttpPost]
        public async Task<IActionResult> CreateAllowance(CreateAllowanceRequestModel model)
        {
            return Ok(await _allowanceService.CreateAsync(model));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAllowance()
        {
            return Ok(await _allowanceService.GetAsync());
        }
    }
}