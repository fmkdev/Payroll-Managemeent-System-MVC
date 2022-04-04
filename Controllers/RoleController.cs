using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateRole(CreateRoleRequestModel model)
        {
            var role = await _roleService.CreateAsync(model);
            if(role.IsSuccess == true)
            {
                ViewBag.Success = " Created Successfully";
            }
            ViewBag.Success = "Not Created";
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllRole()
        {
            var role = await _roleService.GetAsync();
            return View(role.Data);
        }
    }
}