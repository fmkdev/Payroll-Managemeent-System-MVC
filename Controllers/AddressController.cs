using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> UpdateAddress(int employeeId)
        {
            var emp = await _addressService.GetAsync(employeeId);
            return View(emp.Data);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateAddress(int id, UpdateAddressRequestModel model)
        {
            var acc = await _addressService.UpdateAsync(id, model);
            return RedirectToAction("GetAllEmployee", "Employee");
        }
    }
}