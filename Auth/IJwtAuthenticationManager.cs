using PayxApi.DTOs;

namespace PayxApi.Auth
{
    public interface IJwtAuthenticationManager
    {
        string GenerateToken(UserDTO user);
    }
}