using System;
using System.Threading.Tasks;
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
        public async Task<IActionResult> CreateOtherDeduction(int employeeId, CreateOtherDeductionRequestModel model)
        {
            return Ok(await _otherDeductionservice.CreateAsync(employeeId, model));
        }

        [HttpPost("{employeeId}")]
        public async Task<IActionResult> GetEmployeeDeductionByMonth(int employeeId, DateTime month)
        {
            return Ok(await _otherDeductionservice.GetAsync(employeeId, month.Month));
        }
    }
}