using System;

namespace PayxApi.DTOs
{
    public class OtherDeductionDTO
    {
        public int EmployeeId { get; set; }

        public EmployeeDTO Employee { get; set; }
        
        public string  DeductionName { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
    }
    public class CreateOtherDeductionRequestModel
    {
        public string  DeductionName { get; set; }

        public decimal Amount { get; set; }
    }
}