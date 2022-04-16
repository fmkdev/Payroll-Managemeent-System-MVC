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
        
        //[Authorize(Roles = "Admin")]
        public IActionResult CreateDepartment()
        {
            return View();
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateDepartment(CreateDepartmentRequestModel model)
        { 
            var dept = await _departmentService.CreateAsync(model);
            if(dept.IsSuccess == true)
            {
                ViewBag.Success = " Created Successfully";
            }
            ViewBag.Success = "Not Created ";
            return View();
        }

        [HttpGet]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllDepartment()
        {
            var dept = await _departmentService.GetAsync();
            return View(dept.Data);
        }
    }
}