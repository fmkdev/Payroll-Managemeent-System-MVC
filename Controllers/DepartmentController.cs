using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateDepartmentRequestModel model)
        { 
            return Ok(await _departmentService.CreateAsync(model));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartment()
        {
            return Ok(await _departmentService.GetAsync());
        }
    }
}