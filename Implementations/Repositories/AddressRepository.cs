using System.Threading.Tasks;
using PayxApi.ContextDb;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ContextApp _context;

        public AddressRepository(ContextApp contextApp)
        {
            _context = contextApp;
        }
        public async Task<bool> CreteAsync(Address address)
        {
            await _context.Addresses.AddAsync(address);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}