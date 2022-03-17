using System;

namespace PayxApi.Models
{
    public class Tax : BaseEntity
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public decimal Amount { get; set; }

        public double TaxPercentage { get; set; }
        
        public DateTime PaidFor { get; set; }

        public int Month { get; set; }
    }
}