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
            var ledger = await _context.Ledgers.Include(s => s.Salaries)
            .Include(la => la.LedgerAdds).Include(ld => ld.LedgerDeductions).Include(e => e.Employee).Where(l => l.Id == ledgerId)
            .SingleOrDefaultAsync();
            return ledger;
        }

        public async Task<bool> UpdateAsync(Ledger Ledger)
        {
            _context.Ledgers.Update(Ledger);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}