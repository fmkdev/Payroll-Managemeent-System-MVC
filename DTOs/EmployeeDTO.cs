using System;
using System.Collections.Generic;
using PayxApi.Enum;
using PayxApi.Models;

namespace PayxApi.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string EmployeeCardId { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string DepartmentName { get; set; }

        public string PositionName { get; set; }

        public PaymentType PaymentType { get; set; }

        public int PositionId { get; set; }

        public decimal BasicPay { get; set; }

        public int PositionRequestDays { get; set; }

        public int PayLevelRequestDays { get; set; }

        public decimal Bonus { get; set; }

        public decimal PositionAllowance { get; set; }

        public double EmployeeTaxPercentage { get; set; }

        public decimal PayLevelAllowance { get; set; }

        public decimal EmployeeBonus { get; set; }

        public decimal EmployeeOtherDeduction { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
    public class CreateEmployeeRequestModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public int DepartmentId { get; set; }

        public int PositionId { get; set; }

        public int AppointmentId { get; set; }

        public int PayLevelId { get; set; }

        public PaymentType PaymentType { get; set; }

        public DateTime ResumptionDate { get; set; }



        public string HouseNumber { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Nationality { get; set; }

        public string LocalGovernment { get; set; }

        public string HomeNumber { get; set; }


        public string AccountNumber { get; set; }

        public string BankName { get; set; }


        public IList<int> RoleIds { get; set; } = new List<int>();
    }
    public class UpdateEmployeeRequestModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }
    }
}