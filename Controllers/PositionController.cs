using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePositionRequestModel model)
        { 
            return Ok(await _positionService.CreateAsync(model));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPosition()
        {
            return Ok(await _positionService.GetAsync());
        }
    }
}