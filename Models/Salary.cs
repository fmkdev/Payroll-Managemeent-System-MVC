using System;

namespace PayxApi.Models
{
    public class Salary : BaseEntity
    {
        public int? LedgerId { get; set; }  

        public Ledger Ledger { get; set; }

        public string Narration { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
    }
}