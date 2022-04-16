using System;
using System.Collections.Generic;
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
        private readonly ILedgerRepository _ledgerRepository;
        private readonly ISalaryRepository _salary;

        public PayrollService(IPayrollRepository payrollRepository, IEmployeeRepository employeeRepository,
        ITaxRepository taxRepository, ILedgerRepository ledgerRepository, ISalaryRepository salary)
        {
            _payrollRepository = payrollRepository;
            _employeeRepository = employeeRepository;
            _taxRepository = taxRepository;
            _ledgerRepository = ledgerRepository;
            _salary = salary;
        }

        public async Task<BaseResponse<bool>> GeneratePayrollForBiWeeklyPayee()
        {
            var employees = await _employeeRepository.GetAllPaysAsync();
            if (employees == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Success",
                    Data = false
                };
            }

            var biWeeklyPayee = employees.Where(e => e.PaymentType == PaymentType.BiWeekly);
            if (biWeeklyPayee.Count() == 0)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Success",
                    Data = false
                };
            }

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

                var salary = new Salary
                {
                    LedgerId = emp.Ledger.Id,
                    Ledger = emp.Ledger,
                    Narration = $"The amount entering {emp.FirstName} {emp.LastName} ledger account for the Month: {payroll.Month}, Year: {payroll.Year} is {payroll.GrossPay}",
                    Month = payroll.Month,
                    Year = payroll.Year,
                    Date = payroll.ReinbursementDate
                };

                await _payrollRepository.CreateAsync(payroll);
                await _taxRepository.CreateAsync(tax);
                await _salary.CreateAsync(salary);

                emp.Ledger.Balance = salary.Amount;
                emp.Ledger.Salaries.Add(salary);
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
            if (employees == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Success",
                    Data = false
                };
            }

            var monthlyPayee = employees.Where(e => e.PaymentType == PaymentType.Monthly);
            if (monthlyPayee == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Success",
                    Data = false
                };
            }

            foreach (var employee in monthlyPayee)
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
                var salary = new Salary
                {
                    LedgerId = emp.Ledger.Id,
                    Ledger = emp.Ledger,
                    Narration = $"The amount entering {emp.FirstName} {emp.LastName} ledger account for the Month: {payroll.Month}, Year: {payroll.Year} is {payroll.GrossPay}",
                    Month = payroll.Month,
                    Year = payroll.Year,
                    Date = payroll.ReinbursementDate
                };

                await _payrollRepository.CreateAsync(payroll);
                await _taxRepository.CreateAsync(tax);
                await _salary.CreateAsync(salary);

                emp.Ledger.Balance = salary.Amount;
                emp.Ledger.Salaries.Add(salary);
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
            if (employees == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Success",
                    Data = false
                };
            }

            var weeklyPayee = employees.Where(e => e.PaymentType == PaymentType.weekly);
            if (weeklyPayee == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Success",
                    Data = false
                };
            }

            foreach (var employee in employees)
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
                var salary = new Salary
                {
                    LedgerId = emp.Ledger.Id,
                    Ledger = emp.Ledger,
                    Narration = $"The amount entering {emp.FirstName} {emp.LastName} ledger account for the Month: {payroll.Month}, Year: {payroll.Year} is {payroll.GrossPay}",
                    Month = payroll.Month,
                    Year = payroll.Year,
                    Date = payroll.ReinbursementDate
                };

                await _payrollRepository.CreateAsync(payroll);
                await _taxRepository.CreateAsync(tax);
                await _salary.CreateAsync(salary);

                emp.Ledger.Balance = salary.Amount;
                emp.Ledger.Salaries.Add(salary);
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

        public async Task<BaseResponse<IEnumerable<PayrollDTO>>> GetAsync()
        {
            var pay = await _payrollRepository.GetAsync();
            return new BaseResponse<IEnumerable<PayrollDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = pay
            };
        }

        public async Task<BaseResponse<IEnumerable<PayrollDTO>>> GetAsync(string EmployeeCardId)
        {
            var pay = await _payrollRepository.GetAsync(EmployeeCardId);
            return new BaseResponse<IEnumerable<PayrollDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = pay
            };
        }

        public async Task<BaseResponse<IEnumerable<PayrollDTO>>> GetAsync(DateTime date)
        {
            var pay = await _payrollRepository.GetAsync(date);
            return new BaseResponse<IEnumerable<PayrollDTO>>
            {
                IsSuccess = true,
                Message = "Success",
                Data = pay
            };
        }
    }
}