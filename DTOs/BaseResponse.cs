namespace PayxApi.DTOs
{
    public class BaseResponse<T>
    {
        public bool IsSuccess { get; set; }
        
        public string Message { get; set; }
        
        public T Data { get; set; }
        
    }
    public class LoginResponse<T>
    {
        public bool IsSuccess { get; set; }
        
        public string Message { get; set; }
        
        public T Data { get; set; }

        public string Token { get; set; }
    }
    public class Datas<T>
    {
        public int TotalEmployee { get; set; }
        public decimal TotalBiWeekly { get; set; }
        public T Act { get; set; }
    }
}