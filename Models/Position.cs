using System.Collections.Generic;

namespace PayxApi.Models
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int MaxRequestDaysPerAnnum { get; set; }

        public ICollection<PositionAllowance> PositionAllowances { get; set; } = new List<PositionAllowance>();

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}