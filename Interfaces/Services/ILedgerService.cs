using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface ILedgerService
    {
        Task<BaseResponse<LedgerDTO>> GetAsync(int ledgerId); 
    }
}