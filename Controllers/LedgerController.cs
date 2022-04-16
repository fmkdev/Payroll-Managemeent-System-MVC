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

        [HttpGet("Ledger/GetLedger/")]
        public async Task<IActionResult> GetLedger(int ledgerId)
        {
            var ledger = await _ledgerService.GetAsync(ledgerId);
            return View(ledger.Data);
        }

        [HttpGet("Ledger/PutOnLedger/")]
        public IActionResult PutOnLedger()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddToLedger(int ledgerId, PutOnLedgerRequestModel request)
        {
            var result = await _ledgerAddService.AddToLedgerAsync(ledgerId, request);
            return RedirectToAction("FinancialLife", "Employee");
        }
        
        [HttpPost]
        public async Task<IActionResult> DeductFromLedger(int ledgerId, PutOnLedgerRequestModel request)
        {
            var result = await _ledgerDeductions.DeductOnLedgerAsync(ledgerId, request);
            return RedirectToAction("FinancialLife", "Employee");
        }
        
    }
}