using System.Collections.Generic;

namespace PayxApi.Models
{
    public class Allowance : BaseEntity
    {
        public string AllowanceName { get; set; }

        public decimal Amount { get; set; }

        public ICollection<AllowancePayLevel> AccountLevels { get; set; } = new List<AllowancePayLevel>();

        public ICollection<PositionAllowance> PositionAllowances { get; set; } = new List<PositionAllowance>();
    }
}