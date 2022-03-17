using System.Threading.Tasks;
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
        public async Task<IActionResult> Create(CreateRoleRequestModel model)
        {
            return View(await _roleService.CreateAsync(model));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRole()
        {
            return View(await _roleService.GetAsync());
        }
    }
}