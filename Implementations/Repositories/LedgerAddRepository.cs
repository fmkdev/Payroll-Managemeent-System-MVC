using System;
using System.Threading.Tasks;
using PayxApi.ContextDb;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class LedgerAddRepository : ILedgerAddRepository
    {
        private readonly ContextApp _context;
        public LedgerAddRepository(ContextApp context)
        {
            _context = context;
        }
        public async Task<bool> CreateAsync(LedgerAdd LedgerAdd)
        {
            await _context.LedgerAdds.AddAsync(LedgerAdd);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}