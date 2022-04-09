using System;
using PayxApi.Enum;

namespace PayxApi.Models
{
    public class OtherDeduction : BaseEntity
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        
        public string  DeductionName { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public int Month { get; set; }

        public BDStatus BDStatus { get; set; }
    }
}