using System.Collections.Generic;

namespace PayxApi.DTOs
{
    public class PositionDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int MaxRequestDaysPerAnnum { get; set; }

        public IList<AllowanceDTO> Allowances { get; set; } = new List<AllowanceDTO>();
    }
    public class CreatePositionRequestModel
    {
        public string PositionName { get; set; }

        public string Description { get; set; }

        public int MaxRequestDaysPerAnnum { get; set; }

        public IList<int> Allowances { get; set; } = new List<int>();
    }
}