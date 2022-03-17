using System.Threading.Tasks;
using PayxApi.ContextDb;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class TaxRepository : ITaxRepository
    {
       private readonly ContextApp _context;
        public TaxRepository(ContextApp context)
        {
            _context = context;
        }
        public async Task<bool> CreateAsync(Tax tax)
        {
            await _context.Taxes.AddAsync(tax);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}