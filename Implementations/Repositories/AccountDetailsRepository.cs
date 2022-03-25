using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PayxApi.ContextDb;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class AccountDetailsRepository : IAccountDetailsRepository
    {
        private readonly ContextApp _context;

        public AccountDetailsRepository(ContextApp contextApp)
        {
            _context = contextApp;
        }
        public async Task<bool> CreateAsync(AccountDetails accountDetails)
        {
            await _context.AccountDetails.AddAsync(accountDetails);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<AccountDetails> GetAsync(int Id)
        {
            return await _context.AccountDetails.SingleOrDefaultAsync(b => b.EmployeeId == Id);
        }

        public async Task<bool> UpdateAsync(AccountDetails accountDetails)
        {
            _context.AccountDetails.Update(accountDetails);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}