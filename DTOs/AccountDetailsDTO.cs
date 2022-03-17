using PayxApi.Models;

namespace PayxApi.DTOs
{
    public class AccountDetailsDTO
    {
        public int Id { get; set; }
        
        public string AccountNumber { get; set; }

        public string BankName { get; set; }

        public int EmployeeId { get; set; }

        public EmployeeDTO Employee { get; set; }
    }
    public class CreateAccountDetailsRequestModel
    {
        public string AccountNumber { get; set; }

        public string BankName { get; set; }

        public int EmployeeId { get; set; }
    }
}