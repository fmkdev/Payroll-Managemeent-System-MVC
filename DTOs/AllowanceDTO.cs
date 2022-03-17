namespace PayxApi.DTOs
{
    public class AllowanceDTO
    {
        public int Id { get; set; }
        
        public string AllowanceName { get; set; }

        public decimal Amount { get; set; }
    }
    public class CreateAllowanceRequestModel
    {
        public string AllowanceName { get; set; }

        public decimal Amount { get; set; }
    }
}