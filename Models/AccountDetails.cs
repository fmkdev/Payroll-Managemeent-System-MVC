namespace PayxApi.Models
{
    public class AccountDetails : BaseEntity
    {
        public string AccountNumber { get; set; }

        public string BankName { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}