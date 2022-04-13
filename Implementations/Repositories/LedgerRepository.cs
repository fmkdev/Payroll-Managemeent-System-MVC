using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayxApi.ContextDb;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class LedgerRepository : ILedgerRepository
    {
        private readonly ContextApp _context;
        public LedgerRepository(ContextApp context)
        {
            _context = context;
        }
        public async Task<bool> CreateAsync(Ledger Ledger)
        {
            await _context.Ledgers.AddAsync(Ledger);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Ledger> GetAsync(int ledgerId)
        {
            return await _context.Ledgers.Include(e => e.Employee)
            .Where(l => l.Id == ledgerId).SingleOrDefaultAsync();
        }

        public async Task<bool> UpdateAsync(Ledger Ledger)
        {
            _context.Ledgers.Update(Ledger);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}