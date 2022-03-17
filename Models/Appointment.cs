using System;
using System.Collections.Generic;

namespace PayxApi.Models
{
    public class Appointment : BaseEntity
    {
        public string AppointmentName { get; set; }

        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}