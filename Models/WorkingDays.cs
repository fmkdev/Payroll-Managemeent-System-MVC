using System;
using PayxApi.Enum;

namespace PayxApi.Models
{
    public class WorkingDays : BaseEntity
    {
        public string EmployeeCardId { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeFullName { get; set; }

        public Employee Employee { get; set; }

        public DateTime WorkDate { get; set; }

        public DateTime? SignInTime { get; set; }

        public DateTime? SigOutTime { get; set; }

        public WorkStatus WorkStatus { get; set; } = WorkStatus.Abscent;

        public string Request { get; set; }

        public RequestStatus RequestStatus { get; set; } = RequestStatus.None;

        public ApprovalStatus ApprovalStatus { get; set; } = ApprovalStatus.Initialized;

        public DayStatus DayStatus { get; set; } = DayStatus.Workday;
    }
}