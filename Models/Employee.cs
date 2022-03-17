using System;
using System.Collections.Generic;
using PayxApi.Enum;

namespace PayxApi.Models
{
    public class Employee : BaseEntity
    {
        public string CardId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Address Address { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public int PositionId { get; set; }

        public Position Position { get; set; }

        public PaymentType PaymentType { get; set; }
        
        public int AppointmentId { get; set; }

        public Appointment Appointment { get; set; }

        public DateTime ResumptionDate { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public AccountDetails AccountDetails { get; set; }

        public int PayLevelId { get; set; }

        public PayLevel PayLevel { get; set; }

        public ICollection<WorkingDays> WorkingDays { get; set; } = new List<WorkingDays>();

        public ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();

        public ICollection<Bonus> Bonus { get; set; } = new List<Bonus>();

        public ICollection<OtherDeduction> OtherDeductions { get; set; } = new List<OtherDeduction>();

        public ICollection<Tax> Taxes { get; set; } = new List<Tax>();
    }
}