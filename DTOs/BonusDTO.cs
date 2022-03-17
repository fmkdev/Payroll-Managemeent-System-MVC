using System;

namespace PayxApi.DTOs
{
    public class BonusDTO
    {
        public int EmployeeId { get; set; }

        public EmployeeDTO Employee { get; set; }
        
        public string  BonusName { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
    }
    public class CreateBonusRequestModel
    {
        public string  BonusName { get; set; }

        public decimal Amount { get; set; }
    }
}