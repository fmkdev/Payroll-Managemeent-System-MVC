using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface ILedgerDeductionsService
    {
        Task<BaseResponse<bool>> DeductOnLedgerAsync(int ledgerId, PutOnLedgerRequestModel model);
    }
}