using System.Collections.Generic;

namespace PayxApi.DTOs
{
    public class LedgerDTO
    {
        public int Id { get; set; }
        
        public int EmployeeId { get; set; }

        public EmployeeDTO Employee { get; set; }
        
        public string Narration { get; set; }

        public decimal Balance { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public bool IsPaid { get; set; } = false;

        public ICollection<OtherDeductionDTO> OtherDeductions = new List<OtherDeductionDTO>();

        public ICollection<BonusDTO> Bonus = new List<BonusDTO>();
    }
}