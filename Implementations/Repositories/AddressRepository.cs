using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Address> GetAsync(int Id)
        {
            return await _context.Addresses.SingleOrDefaultAsync(b => b.EmployeeId == Id);
        }

        public async Task<bool> UpdateAsync(Address address)
        {
            _context.Addresses.Update(address);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}