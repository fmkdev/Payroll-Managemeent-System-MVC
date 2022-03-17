using PayxApi.Models;

namespace PayxApi.DTOs
{
    public class AddressDTO
    {
        public int EmployeeId { get; set; }

        public EmployeeDTO Employee { get; set; }
        
        public string HouseNumber { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Nationality { get; set; }

        public string LocalGovernment { get; set; }

        public string HomeNumber { get; set; }
    }
    public class CreateAddressRequestModel
    {
        public int EmployeeId { get; set; }
        
        public string HouseNumber { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Nationality { get; set; }

        public string LocalGovernment { get; set; }

        public string HomeNumber { get; set; }
    }
}