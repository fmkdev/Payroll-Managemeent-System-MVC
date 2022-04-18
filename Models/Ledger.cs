using System;
using System.Collections.Generic;
namespace PayxApi.Models
{
    public class Ledger : BaseEntity
    {
        public int EmployeeId { get; set; }
        
        public Employee Employee { get; set; }

        public decimal? Balance { get; set; }

        public ICollection<Salary> Salaries { get; set; } = new List<Salary>();

        public ICollection<LedgerAdd> LedgerAdds { get; set; } = new List<LedgerAdd>();

        public ICollection<LedgerDeduction> LedgerDeductions { get; set; } = new List<LedgerDeduction>();
    }
}