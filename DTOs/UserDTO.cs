using System.Collections.Generic;
using PayxApi.Models;

namespace PayxApi.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }
        
        public string Email { get; set; }

        public string EmployeeCardId { get; set; }

        public string userEmailOrCardId { get; set; }

        public string Password { get; set; }

        public string PositionName { get; set; }

        public string DepartmentName { get; set; }

        public int EmployeeId { get; set; }

        public EmployeeDTO Employee { get; set; }

        public AddressDTO Address { get; set; }

        public AccountDetailsDTO Account { get; set; }

        public ICollection<RoleDTO> UserRoles { get; set; } = new List<RoleDTO>();
    }
    public class GetByEmailRequestModel
    {
        public string Email { get; set; }
    }
    public class LoginUserRequestModel
    {
        public string userEmailOrCardId { get; set; }

        public string Password { get; set; }
    }
    public class FindUserRequestModel
    {
        public string UserEmailOrCardId { get; set; }
    }
}