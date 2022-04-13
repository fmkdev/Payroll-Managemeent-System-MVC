using System;
using System.Collections.Generic;
namespace PayxApi.Models
{
    public class Ledger : BaseEntity
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        
        public string Narration { get; set; }

        public decimal? Balance { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public bool IsPaid { get; set; } = false;

        public ICollection<LedgerAdd> LedgerAdds = new List<LedgerAdd>();

        public ICollection<LedgerDeduction> LedgerDeductions = new List<LedgerDeduction>();
    }
}