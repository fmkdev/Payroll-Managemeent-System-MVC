using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayxApi.Interfaces.Services;

namespace PayxApi.Controllers
{
    public class PayrollController : Controller
    {
        private readonly IPayrollService _payrollService;
        public PayrollController(IPayrollService payrollService)
        {
            _payrollService = payrollService;
        }

        [HttpGet("PresentMonthPayroll")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> PresentMonthPayroll()
        {
            var pay = await _payrollService.GetAsync();
            return View(pay.Data);
        }

        [HttpGet("Payroll/ViewMyPayrolls/{employeeId}")]
        [Authorize]
        public async Task<IActionResult> ViewMyPayrolls(string CardId)
        {
            if (CardId == null)
            {
                var pay = await _payrollService.GetAsync(User.FindFirstValue(ClaimTypes.GivenName));
                return View(pay.Data);
            }
            var pays = await _payrollService.GetAsync(CardId);
            return View(pays.Data);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetPayrollByDate(DateTime Date)
        {
            var pay = await _payrollService.GetAsync(Date);
            return View(pay.Data);
        }

    }
}