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
}