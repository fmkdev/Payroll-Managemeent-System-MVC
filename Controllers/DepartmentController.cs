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

        public IActionResult CreateDepartment()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment(CreateDepartmentRequestModel model)
        { 
            return View(await _departmentService.CreateAsync(model));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartment()
        {
            return View(await _departmentService.GetAsync());
        }
    }
}