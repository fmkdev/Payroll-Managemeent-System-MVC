using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi
{
    public class OtherDeductionController : Controller
    {
        private readonly IOtherDeductionService _otherDeductionservice;

        public OtherDeductionController(IOtherDeductionService otherDeductionservice)
        {
            _otherDeductionservice = otherDeductionservice;
        }

        [HttpPost("{employeeId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateOtherDeduction(int employeeId, CreateOtherDeductionRequestModel model)
        {
            var od = await _otherDeductionservice.CreateAsync(employeeId, model);
            return View();
        }

        [HttpPost("{employeeId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetEmployeeDeductionByMonth(int employeeId, DateTime month)
        {
            var od = await _otherDeductionservice.GetAsync(employeeId, month.Month);
            return View(od.Data);
        }
    }
}