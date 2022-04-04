using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi
{
    public class OtherDeductionController : Controller
    {
        private readonly IOtherDeductionService _otherDeductionservice;
        private readonly IEmployeeService _employeeService;

        public OtherDeductionController(IOtherDeductionService otherDeductionservice, IEmployeeService employeeService)
        {
            _otherDeductionservice = otherDeductionservice;
            _employeeService = employeeService;
        }
        
        [HttpGet("CreateOtherDeduction/{employeeId}")]
        public IActionResult CreateOtherDeduction()
        {
            return View();
        }

        [HttpPost("CreateOtherDeduction/{employeeId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateOtherDeduction(int employeeId, CreateOtherDeductionRequestModel model)
        {
            var od = await _otherDeductionservice.CreateAsync(employeeId, model);
            if(od.IsSuccess == true)
            {
                ViewBag.Success = " Created Successfully";
            }
            ViewBag.Success = "Not Created ";
            return RedirectToAction("AllEmployee", "OtherDeduction");
        }

        [HttpPost("{employeeId}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetEmployeeDeductionByMonth(int employeeId, DateTime month)
        {
            var od = await _otherDeductionservice.GetAsync(employeeId, month.Month);
            return View(od.Data);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AllEmployee()
        {
            return View(await _employeeService.GetAsync());
        }
    }
}