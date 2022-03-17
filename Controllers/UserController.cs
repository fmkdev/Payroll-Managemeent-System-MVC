using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayxApi.Auth;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IJwtAuthenticationManager _jwtAuthenticationManager;
        public UserController(IUserService userService, IJwtAuthenticationManager jwtAuthenticationManager)
        {
            _userService = userService;
            _jwtAuthenticationManager = jwtAuthenticationManager;
        }

        [HttpPost]
        public async Task<IActionResult> GetASync(FindUserRequestModel model)
        {
            var user = await _userService.GetAsync(model);
            if(user.IsSuccess == false)
            {
                return NotFound(user);
            }
            return Ok(user);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserRequestModel model)
        {
            var response = await _userService.LoginAsync(model);
            if(response.IsSuccess == false)
            {
                return View();
            }

            var token = _jwtAuthenticationManager.GenerateToken(response.Data);

            var user = new LoginResponse<UserDTO>
            {
                IsSuccess = true,
                Message = "Login Successfully",
                Data = response.Data,
                Token = token
            };
            return RedirectToAction("Index", "Home");
        }
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(int userId)
        {
            return Ok(await _userService.GetAsync(userId));
        }
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            return Ok(await _userService.DeleteAsync(userId));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            return Ok(await _userService.GetAsync());
        }
   
        [HttpGet]
        public async Task<IActionResult> GetLoggedInUser()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            return Ok(await _userService.GetAsync(userId));
        }
    }
}