using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayxApi.DTOs;
using PayxApi.Interfaces.Services;

namespace PayxApi
{
    public class LedgerController : Controller
    {
        private readonly ILedgerService _ledgerService;
        private readonly ILedgerAddService _ledgerAddService;
        public readonly ILedgerDeductionsService _ledgerDeductions;
        public LedgerController(ILedgerService ledgerService, ILedgerAddService ledgerAddService,
            ILedgerDeductionsService ledgerDeductions)
        {
            _ledgerService = ledgerService;
            _ledgerAddService = ledgerAddService;
            _ledgerDeductions = ledgerDeductions;
        }

        public async Task<IActionResult> GetLedger(int ledgerId)
        {
            var ledger = await _ledgerService.GetAsync(ledgerId);
            return View(ledger.Data);
        }

        public IActionResult PutOnLedger()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddToLedger(int ledgerId, PutOnLedgerRequestModel request)
        {
            var result = await _ledgerAddService.AddToLedgerAsync(ledgerId, request);
            return View(result.Data);
        }
        
        [HttpPost]
        public async Task<IActionResult> DeductFromLedger(int ledgerId, PutOnLedgerRequestModel request)
        {
            var result = await _ledgerDeductions.DeductOnLedgerAsync(ledgerId, request);
            return View(result.Data);
        }
        
    }
}