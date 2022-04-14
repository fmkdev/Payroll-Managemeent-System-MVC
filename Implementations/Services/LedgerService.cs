using System.Linq;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;

namespace PayxApi.Implementations.Services
{
    public class LedgerService : ILedgerService
    {
        private readonly ILedgerRepository _ledgerRepository;
        public LedgerService(ILedgerRepository ledgerRepository)
        {
            _ledgerRepository = ledgerRepository;
        }

        public Task<BaseResponse<LedgerDTO>> GetAsync(int ledgerId)
        {
            throw new System.NotImplementedException();
        }

        // public async Task<BaseResponse<LedgerDTO>> GetAsync(int ledgerId)
        // {
        //     var ledger = await _ledgerRepository.GetAsync(ledgerId);
        //     if (ledger == null)
        //     {
        //         return new BaseResponse<LedgerDTO>
        //         {
        //             IsSuccess = false,
        //             Message = "Not Found",
        //             Data = null
        //         };
        //     }
        //     return new BaseResponse<LedgerDTO>
        //     {
        //         IsSuccess = true,
        //         Message = "Success",
        //         Data = new LedgerDTO
        //         {
        //             Id = ledger.Id,
        //             Narration = ledger.Narration,
        //             Balance = ledger.Balance,
        //             LedgerAdds = ledger.LedgerAdds.Select(adds => new LedgerAddDTO
        //             {
        //                 Id = adds.Id,
        //                 AddName = adds.AddName,
        //                 Amount = adds.Amount,
        //                 BDStatus = adds.BDStatus,
        //                 Month = adds.Month,
        //                 Year = adds.Year
        //             }).ToList(),
        //             LedgerDeductions = ledger.LedgerDeductions.Select(deductions => new LedgerDeductionDTO
        //             {
        //                 Id = deductions.Id,
        //                 DeductionName = deductions.DeductionName,
        //                 Amount = deductions.Amount,
        //                 BDStatus = deductions.BDStatus,
        //                 Month = deductions.Month,
        //                 Year = deductions.Year
        //             }).ToList()
        //         }
        //     };
        // }
    }
}