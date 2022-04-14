using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayxApi.Interfaces.Services;

namespace PayxApi
{
    public class LedgerController : Controller
    {
        private readonly ILedgerService _ledgerService;
        public LedgerController(ILedgerService ledgerService)
        {
            _ledgerService = ledgerService;
        }

        public async Task<IActionResult> GetLedger(int ledgerId)
        {
            var ledger = await _ledgerService.GetAsync(ledgerId);
            return View(ledger.Data);
        }
    }
}