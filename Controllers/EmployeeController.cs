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
            ViewData["Department"] = new SelectList(department.Data, "Id", "Name");

            var appointment = await _appointmentService.GetAsync();
            ViewData["Appointment"] = new SelectList(appointment.Data, "Id", "AppointmentName");

            var position = await _positionService.GetAsync();
            ViewData["Position"] = new SelectList(position.Data, "Id", "Name");

            var payLevel = await _payLevelService.GetAsync();
            ViewData["PayLevel"] = new SelectList(payLevel.Data, "Id", "LevelName");

            var role = await _roleService.GetAsync();
            ViewData["RoleIds"] = new SelectList(role.Data, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeRequestModel model)
        {
            var employee = await _employeeService.CreateAsync(model);
            return View(employee.Message);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return View(await _employeeService.GetAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return View(await _employeeService.GetAsync());
        }
    }
}