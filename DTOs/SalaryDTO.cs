using System;
using PayxApi.Enum;

namespace PayxApi.DTOs
{
    public class SalaryDTO
    {
        public int Id { get; set; }

        public LedgerDTO Ledger { get; set; }

        public string Narration { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public BDStatus BDStatus { get; set; }
    }
}