using System;
using System.Collections.Generic;
namespace PayxApi.Models
{
    public class Ledger : BaseEntity
    {
        public int EmployeeId { get; set; }
        
        public Employee Employee { get; set; }

        public decimal? Balance { get; set; }

        public ICollection<Salary> Salaries = new List<Salary>();

        public ICollection<LedgerAdd> LedgerAdds = new List<LedgerAdd>();

        public ICollection<LedgerDeduction> LedgerDeductions = new List<LedgerDeduction>();
    }
}