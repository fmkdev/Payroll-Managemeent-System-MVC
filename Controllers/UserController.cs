using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayxApi.Auth;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        
        public UserController(IUserService userService, IEmployeeService employeeService, 
        IDepartmentService departmentService)
        {
            _userService = userService;
            _employeeService = employeeService;
            _departmentService = departmentService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var weekly = await _employeeService.GetWeeklyReinbursement();
            var biweek = await _employeeService.GetBiWeeklyReinbursement();
            var month = await _employeeService.GetMonthlyReinbursement();
            var employees = await _employeeService.GetAllNumberOfEmployeeAsync();

            var deptemp = await _departmentService.GetEmployeeByDepartmentAsync();

            var numbrofdepartment = deptemp.Data.Count();
            List<string> deptNames = new List<string>();
            List<int> empNumbers = new List<int>();

            foreach(var item in deptemp.Data)
            {
                deptNames.Add(item.Name);
                empNumbers.Add(item.NumberOfEmployees);
            }
            var dpN = deptNames;
            var epnum = empNumbers;
            
            ViewBag.DEPARTMENTNAMES = dpN;
            ViewBag.EMPLOYEENUMBERS = empNumbers;
            

            


            ViewBag.WEEKLY = weekly.Data;
            ViewBag.BIWEEK = biweek.Data;
            ViewBag.MONTHLY = month.Data;
            ViewBag.EMPLOYEES = employees.Data;
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetASync(FindUserRequestModel model)
        {
            var user = await _userService.GetAsync(model);
            if(user.IsSuccess == false)
            {
                return NotFound();
            }
            return View(user.Data);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserRequestModel model)
        {
            var response = await _userService.LoginAsync(model);
            if (response.IsSuccess == true)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, response.Data.FullName),
                    new Claim(ClaimTypes.Email, response.Data.Email),
                    new Claim(ClaimTypes.NameIdentifier, response.Data.Id.ToString()),
                    new Claim(ClaimTypes.GivenName, response.Data.EmployeeCardId),
                };
                
                foreach(var role in response.Data.UserRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Name));
                }

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authenticationProperties = new AuthenticationProperties();
                var principal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                return RedirectToAction("Index", "User");
            }
            else
            {
                ViewBag.error = "Invalid Username or Password";
                return View();
            }

        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetUser(int userId)
        {
            var user = await _userService.GetAsync(userId);
            return View(user.Data);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var user = await _userService.DeleteAsync(userId);
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAllUser()
        {
            var user = await _userService.GetAsync();
            return View(user.Data);
        }
   
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var userId = User.FindFirst(ClaimTypes.GivenName).Value;
            var user = await _employeeService.GetAsync(userId);
            return View(user.Data);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    
     
    
    }
}