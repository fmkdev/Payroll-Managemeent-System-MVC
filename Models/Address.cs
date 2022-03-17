namespace PayxApi.Models
{
    public class Address : BaseEntity
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        
        public string HouseNumber { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Nationality { get; set; }

        public string LocalGovernment { get; set; }

        public string HomeNumber { get; set; }
    }
}