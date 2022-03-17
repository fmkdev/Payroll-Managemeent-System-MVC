using System.Collections.Generic;

namespace PayxApi.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string EmployeeCardId { get; set; }

        public string Password { get; set; }

        public Employee Employee { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}