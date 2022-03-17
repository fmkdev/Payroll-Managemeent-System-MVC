using System.Collections.Generic;

namespace PayxApi.Models
{
    public class PayLevel : BaseEntity
    {
        public string LevelName { get; set; }

        public string Description { get; set; }

        public decimal BasicSalary { get; set; }

        public int MaxRequestDaysPerAnnum { get; set; }

        public double TaxPercentage { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public ICollection<AllowancePayLevel> AllowancePayLevels { get; set; } = new List<AllowancePayLevel>();
    }
}