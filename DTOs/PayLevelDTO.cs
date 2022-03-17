using System.Collections.Generic;
using PayxApi.Models;

namespace PayxApi.DTOs
{
    public class PayLevelDTO
    {
        public int Id { get; set; }
        
        public string LevelName { get; set; }

        public string Description { get; set; }

        public decimal BasicSalary { get; set; }

        public int MaxRequestDaysPerAnnum { get; set; }

        public double TaxPercentage { get; set; }

        public ICollection<AllowanceDTO> AllowanceDTOs { get; set; } = new List<AllowanceDTO>();
    }
    public class CreatePayLevelRequestModel
    {
        public string LevelName { get; set; }

        public string Description { get; set; }

        public decimal BasicSalary { get; set; }

        public int MaxRequestDaysPerAnnum { get; set; }

        public double TaxPercentage { get; set; }

        public IList<int> AllowanceIds { get; set; } = new List<int>();
    }
}