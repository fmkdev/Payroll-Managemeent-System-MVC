namespace PayxApi.Models
{
    public class PositionAllowance : BaseEntity
    {
        public int PositionId { get; set; }

        public Position Position { get; set; }

        public int AllowanceId { get; set; }

        public Allowance Allowance { get; set; }
    }
}