using PayxApi.Enum;

namespace PayxApi.Models
{
    public class LedgerDeduction : BaseEntity
    {
        public int LedgerId { get; set; }

        public Ledger Ledger { get; set; }
        
        public string  DeductionName { get; set; }

        public decimal Amount { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public BDStatus BDStatus { get; set; }
    }
}