using System;
using PayxApi.Enum;
using PayxApi.Models;

namespace PayxApi.DTOs
{
    public class WorkingDaysDTO
    {
        public string EmployeeCardId { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeFullName { get; set; }

        public DateTime WorkDate { get; set; }

        public DateTime? SignInTime { get; set; }

        public DateTime? SigOutTime { get; set; }

        public WorkStatus WorkStatus { get; set; }

        public string Request { get; set; }

        public RequestStatus RequestStatus { get; set; }

        public ApprovalStatus ApprovalStatus { get; set; }

        public DayStatus DayStatus { get; set; }
    }
    public class MakeRequsetModel 
    {
        public string Request { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public RequestStatus RequestStatus { get; set; }
    }
    public class SignRequestModel
    {
        public string UserCardId { get; set; }
    }
    public class ApproveRequestModel
    {
        public string UserCardId { get; set; }

        public ApprovalStatus ApprovalStatus { get; set; }
    }
}