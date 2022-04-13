using System.Threading.Tasks;
using PayxApi.ContextDb;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class LedgerDeductionsRepository : ILedgerDeductionsRepository
    {
        private readonly ContextApp _context;
        public LedgerDeductionsRepository(ContextApp context)
        {
            _context = context;
        }
        public async Task<bool> CreateAsync(LedgerDeduction LedgerDeductions)
        {
            await _context.LedgerDeductions.AddAsync(LedgerDeductions);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}