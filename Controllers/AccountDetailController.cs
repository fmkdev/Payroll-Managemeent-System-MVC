using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class AccountDetailController : Controller
    {
        private readonly IAccountDetailsService _accountDetailsService;

        public AccountDetailController(IAccountDetailsService accountDetailsService)
        {
            _accountDetailsService = accountDetailsService;
        }

    }
}