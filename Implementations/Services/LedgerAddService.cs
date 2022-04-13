using System;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class LedgerAddService : ILedgerAddService
    {
        private readonly ILedgerRepository _ledger;
        private readonly ILedgerAddRepository _ledgerAddRepository;
        public LedgerAddService(ILedgerRepository ledger, ILedgerAddRepository ledgerAddRepository)
        {
            _ledger = ledger;
            _ledgerAddRepository = ledgerAddRepository;
        }
        public async Task<BaseResponse<bool>> AddToLedgerAsync(int ledgerId, PutOnLedgerRequestModel model)
        {
            var ledger = await _ledger.GetAsync(ledgerId);
            if (ledger == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Not Found",
                    Data = false
                };
            }

            var deduction = new LedgerAdd
            {
                AddName = model.Narration,
                Amount = model.Balance,
                BDStatus = Enum.BDStatus.Given,
                Ledger = ledger,
                LedgerId = ledgerId,
                Month = DateTime.UtcNow.Month,
                Year = DateTime.UtcNow.Year
            };
            await _ledgerAddRepository.CreateAsync(deduction);
            ledger.LedgerAdds.Add(deduction);
            ledger.Balance -= model.Balance;
            await _ledger.UpdateAsync(ledger);

            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Success",
                Data = true 
            };
        }
    }
}