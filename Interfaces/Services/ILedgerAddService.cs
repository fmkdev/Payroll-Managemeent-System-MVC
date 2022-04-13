using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface ILedgerAddService
    {
        Task<BaseResponse<bool>> AddToLedgerAsync(int ledgerId, PutOnLedgerRequestModel model);
    }
}