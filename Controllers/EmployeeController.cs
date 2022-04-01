using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeRequestModel model)
        {
            var employee = await _employeeService.CreateAsync(model);
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Get(int id)
        {
            var emp = await _employeeService.GetAsync(id);
            return View(emp.Data);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllEmployee()
        {
            var emp = await _employeeService.GetAsync();
            return View(emp);
        }
    
        [HttpGet("UpdateEmployee/{employeeId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateEmployee(int employeeId)
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

            var employee = await _employeeService.GetAsync(employeeId);

            return View(employee.Data);
        }
        [HttpPost("UpdateEmployee/{employeeId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateEmployee(int employeeId, UpdateEmployeeRequestModel model)
        {
            var acc = await _employeeService.UpdateAsync(employeeId, model);
            return Redirect("GetAllEmployee");
        }

        [HttpPost("Delete/{employeeId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int employeeId)
        {
            var emp = await _employeeService.DeleteAsync(employeeId);
            ViewBag.Success = "Successfully Deleted";
            return RedirectToAction("GetAllEmployee");
        }
    
        [HttpGet("GetDeletedEmployee")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetDeletedEmployee()
        {
            var emp = await _employeeService.GetDeletedAsync();
            return View(emp.Data);
        }
    
    }
}