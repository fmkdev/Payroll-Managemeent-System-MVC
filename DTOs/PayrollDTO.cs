using System;

namespace PayxApi.DTOs
{
    public class PayrollDTO
    {
        public int Id { get; set; }
        
        public string TransactionId { get; set; }

        public int EmployeeId { get; set; }

        public int? LedgerId { get; set; }

        public string EmployeeCardId { get; set; }

        public decimal EmployeeBasicPay { get; set; }

        public decimal TotalAllowance { get; set; }

        public decimal TotalBonus { get; set; }

        public decimal Tax { get; set; }

        public decimal OtherDeduction { get; set; }

        public decimal? GrossPay { get; set; }

        public DateTime ReinbursementDate { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
    }
}