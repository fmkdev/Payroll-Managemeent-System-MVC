using System.Collections.Generic;
using PayxApi.Enum;

namespace PayxApi.DTOs
{
    public class LedgerDTO
    {
        public int Id { get; set; }
        
        public int EmployeeId { get; set; }

        public EmployeeDTO Employee { get; set; }
        
        public string Narration { get; set; }

        public decimal? Balance { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public bool IsPaid { get; set; } = false;

        public ICollection<LedgerAddDTO> LedgerAdds = new List<LedgerAddDTO>();

        public ICollection<LedgerDeductionDTO> LedgerDeductions = new List<LedgerDeductionDTO>();

        public ICollection<SalaryDTO> Salaries = new List<SalaryDTO>();
    }
    public class PutOnLedgerRequestModel
    {
        public string Narration { get; set; }

        public decimal Balance { get; set; }
    }
    public class LedgerAddDTO
    {
        public int Id { get; set; }
        
        public string  AddName { get; set; }

        public decimal Amount { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public BDStatus BDStatus { get; set; }
    }
    public class LedgerDeductionDTO
    {
        public int Id { get; set; }
        
        public string  DeductionName { get; set; }

        public decimal Amount { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public BDStatus BDStatus { get; set; }
    }
}