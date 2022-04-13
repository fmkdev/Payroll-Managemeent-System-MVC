using System;
using PayxApi.Enum;

namespace PayxApi.Models
{
    public class LedgerAdd : BaseEntity
    {
        public int LedgerId { get; set; }

        public Ledger Ledger { get; set; }
        
        public string  AddName { get; set; }

        public decimal Amount { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public BDStatus BDStatus { get; set; }
    }
}