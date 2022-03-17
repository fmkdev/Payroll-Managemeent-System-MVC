using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class PayLevelController : Controller
    {
        private readonly IPayLevelService _payLevelService;

        public PayLevelController(IPayLevelService payLevelService)
        {
            _payLevelService = payLevelService;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePayLevel(CreatePayLevelRequestModel model)
        {
            return Ok(await _payLevelService.CreateAsync(model));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPayLevel()
        {
            return Ok(await _payLevelService.GetAsync());
        }
    }
}