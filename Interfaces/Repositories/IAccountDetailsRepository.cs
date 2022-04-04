using System.Threading.Tasks;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IAccountDetailsRepository
    {
        Task<bool> CreateAsync(AccountDetails accountDetails);

        Task<bool> UpdateAsync(AccountDetails accountDetails);

        Task<AccountDetails> GetAsync(int Id);
    }
}