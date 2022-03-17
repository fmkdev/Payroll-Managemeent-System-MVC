using System;

namespace PayxApi.Models
{
    public class Bonus : BaseEntity
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        
        public string  BonusName { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public int Month { get; set; }
    }
}