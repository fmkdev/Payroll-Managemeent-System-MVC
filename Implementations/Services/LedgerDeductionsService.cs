using System;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class LedgerDeductionsService : ILedgerDeductionsService
    {
        private readonly ILedgerDeductionsRepository _ledgerDeductions;
        private readonly ILedgerRepository _ledger;
        public LedgerDeductionsService(ILedgerDeductionsRepository ledgerDeductions, ILedgerRepository ledger)
        {
            _ledgerDeductions = ledgerDeductions;
            _ledger = ledger;
        }
        public async Task<BaseResponse<bool>> DeductOnLedgerAsync(int ledgerId, PutOnLedgerRequestModel model)
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

            var deduction = new LedgerDeduction
            {
                DeductionName = model.Narration,
                Amount = model.Balance,
                BDStatus = Enum.BDStatus.Given,
                Ledger = ledger,
                LedgerId = ledgerId,
                Month = DateTime.UtcNow.Month,
                Year = DateTime.UtcNow.Year
            };
            await _ledgerDeductions.CreateAsync(deduction);
            ledger.LedgerDeductions.Add(deduction);
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