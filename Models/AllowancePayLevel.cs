using System;

namespace PayxApi.Models
{
    public class AllowancePayLevel : BaseEntity
    {
        public int PayLevelId { get; set; }

        public PayLevel PayLevel { get; set; }

        public int AllowanceId { get; set; }

        public Allowance Allowance { get; set; }

        public static implicit operator decimal(AllowancePayLevel v)
        {
            throw new NotImplementedException();
        }
    }
}