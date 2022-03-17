using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        private readonly IPositionService _positionService;
        private readonly IAppointmentService _appointmentService;
        private readonly IPayLevelService _payLevelService;
        private readonly IRoleService _roleService;
        public EmployeeController(IEmployeeService employeeService, IDepartmentService departmentService,
        IPositionService positionService, IAppointmentService appointmentService, IPayLevelService payLevelService,
        IRoleService roleService)
        {
            _employeeService = employeeService;
            _appointmentService = appointmentService;
            _departmentService = departmentService;
            _positionService = positionService;
            _payLevelService = payLevelService;
            _roleService = roleService;
        }

        public async Task<IActionResult> CreateEmployee()
        {
            var department = await _departmentService.GetAsync();
            ViewData["Departments"] = new SelectList(department.Data, "Id", "Name");
            var appointment = await _appointmentService.

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeRequestModel model)
        {
            return Ok(await _employeeService.CreateAsync(model));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _employeeService.GetAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _employeeService.GetAsync());
        }
    }
}