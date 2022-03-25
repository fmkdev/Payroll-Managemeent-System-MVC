namespace PayxApi.DTOs
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfEmployees { get; set; }
    }
    public class CreateDepartmentRequestModel
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}