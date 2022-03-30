using System;
using System.Linq;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class PayrollService : IPayrollService
    {
        private readonly IPayrollRepository _payrollRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ITaxRepository _taxRepository;

        public PayrollService(IPayrollRepository payrollRepository, IEmployeeRepository employeeRepository,
        ITaxRepository taxRepository)
        {
            _payrollRepository = payrollRepository;
            _employeeRepository = employeeRepository;
            _taxRepository = taxRepository;
        }

        public async Task<BaseResponse<bool>> GeneratePayrollForBiWeeklyPayee()
        {
            var employees = await _employeeRepository.GetAllPaysAsync();

            var biWeeklyPayee = employees.Where(e => e.PaymentType == PaymentType.BiWeekly);

            foreach (var employee in biWeeklyPayee)
            {
                var totalTax = ((decimal)employee.EmployeeTaxPercentage / 100) * employee.BasicPay;
                var emp = await _employeeRepository.GetAsync(employee.Id);

                var payroll = new Payroll
                {
                    TransactionId = $"EMP-PAY-{Guid.NewGuid().ToString().Substring(0, 9).Replace("-", "").Trim()}",
                    EmployeeId = emp.Id,
                    EmployeeCardId = emp.CardId,
                    EmployeeBasicPay = employee.BasicPay,
                    TotalAllowance = employee.PayLevelAllowance + employee.PositionAllowance,
                    OtherDeduction = employee.EmployeeOtherDeduction,
                    TotalBonus = employee.EmployeeBonus,
                    Tax = totalTax,
                    GrossPay = (employee.BasicPay + employee.PayLevelAllowance + employee.PositionAllowance + employee.EmployeeBonus) - (employee.EmployeeOtherDeduction + totalTax),
                    Day = DateTime.UtcNow.Day,
                    Month = DateTime.UtcNow.Month,
                    Year = DateTime.UtcNow.Year,
                    ReinbursementDate = DateTime.UtcNow
                };
                var tax = new Tax
                {
                    EmployeeId = emp.Id,
                    Employee = emp,
                    Amount = totalTax,
                    PaidFor = DateTime.UtcNow,
                    TaxPercentage = employee.EmployeeTaxPercentage,
                    Month = DateTime.UtcNow.Month
                };

                await _payrollRepository.CreateAsync(payroll);
                await _taxRepository.CreateAsync(tax);

                emp.Payrolls.Add(payroll);
                emp.Taxes.Add(tax);

                await _employeeRepository.UpdateAsync(emp);
                totalTax = 0;
            }
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Generated Successfully",
                Data = true
            };
        }

        public async Task<BaseResponse<bool>> GeneratePayrollForMonthlyPayee()
        {
            var employees = await _employeeRepository.GetAllPaysAsync();

            var monthlyPayee = employees.Where(e => e.PaymentType == PaymentType.BiWeekly);

            foreach (var employee in monthlyPayee)
            {
                var totalTax = ((decimal)employee.EmployeeTaxPercentage / 100) * employee.BasicPay;
                var emp = await _employeeRepository.GetAsync(employee.Id);

                var payroll = new Payroll
                {
                    TransactionId = $"EmpPay{Guid.NewGuid().ToString().Substring(0, 9).Replace("-", "").Trim()}",
                    EmployeeId = emp.Id,
                    EmployeeCardId = emp.CardId,
                    EmployeeBasicPay = employee.BasicPay,
                    TotalAllowance = employee.PayLevelAllowance + employee.PositionAllowance,
                    OtherDeduction = employee.EmployeeOtherDeduction,
                    TotalBonus = employee.EmployeeBonus,
                    Tax = totalTax,
                    GrossPay = (employee.BasicPay + employee.PayLevelAllowance + employee.PositionAllowance + employee.EmployeeBonus) - (employee.EmployeeOtherDeduction + totalTax),
                    Day = DateTime.UtcNow.Day,
                    Month = DateTime.UtcNow.Month,
                    Year = DateTime.UtcNow.Year,
                    ReinbursementDate = DateTime.UtcNow
                };
                var tax = new Tax
                {
                    EmployeeId = emp.Id,
                    Employee = emp,
                    Amount = totalTax,
                    PaidFor = DateTime.UtcNow,
                    TaxPercentage = employee.EmployeeTaxPercentage,
                    Month = DateTime.UtcNow.Month
                };

                await _payrollRepository.CreateAsync(payroll);
                await _taxRepository.CreateAsync(tax);

                emp.Payrolls.Add(payroll);
                emp.Taxes.Add(tax);

                await _employeeRepository.UpdateAsync(emp);
                totalTax = 0;
            }
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Generated Successfully",
                Data = true
            };
        }

        public async Task<BaseResponse<bool>> GeneratePayrollForWeeklyPayee()
        {
            var employees = await _employeeRepository.GetAllPaysAsync();

            var weeklyPayee = employees.Where(e => e.PaymentType == PaymentType.weekly);

            foreach (var employee in employees)
            {
                var totalTax = ((decimal)employee.EmployeeTaxPercentage / 100) * employee.BasicPay;
                var emp = await _employeeRepository.GetAsync(employee.Id);

                var payroll = new Payroll
                {
                    TransactionId = $"EmpPay{Guid.NewGuid().ToString().Substring(0, 9).Replace("-", "").Trim()}",
                    EmployeeId = emp.Id,
                    EmployeeCardId = emp.CardId,
                    EmployeeBasicPay = employee.BasicPay,
                    TotalAllowance = employee.PayLevelAllowance + employee.PositionAllowance,
                    OtherDeduction = employee.EmployeeOtherDeduction,
                    TotalBonus = employee.EmployeeBonus,
                    Tax = totalTax,
                    GrossPay = (employee.BasicPay + employee.PayLevelAllowance + employee.PositionAllowance + employee.EmployeeBonus) - (employee.EmployeeOtherDeduction + totalTax),
                    Day = DateTime.UtcNow.Day,
                    Month = DateTime.UtcNow.Month,
                    Year = DateTime.UtcNow.Year,
                    ReinbursementDate = DateTime.UtcNow
                };
                var tax = new Tax
                {
                    EmployeeId = emp.Id,
                    Employee = emp,
                    Amount = totalTax,
                    PaidFor = DateTime.UtcNow,
                    TaxPercentage = employee.EmployeeTaxPercentage,
                    Month = DateTime.UtcNow.Month
                };

                await _payrollRepository.CreateAsync(payroll);
                await _taxRepository.CreateAsync(tax);

                emp.Payrolls.Add(payroll);
                emp.Taxes.Add(tax);

                await _employeeRepository.UpdateAsync(emp);
                totalTax = 0;
            }
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Generated Successfully",
                Data = true
            };
        }
    }
}