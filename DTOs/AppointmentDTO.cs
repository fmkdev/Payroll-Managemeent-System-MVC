namespace PayxApi.DTOs
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        
        public string AppointmentName { get; set; }

        public string Description { get; set; }
    }
    public class CreateAppointmentRequestModel
    {
        public string AppointmentName { get; set; }

        public string Description { get; set; }
    }
}