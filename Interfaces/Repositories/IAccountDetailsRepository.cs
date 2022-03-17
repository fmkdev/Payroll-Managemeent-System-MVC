using System.Threading.Tasks;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IAccountDetailsRepository
    {
        Task<bool> CreateAsync(AccountDetails accountDetails);
    }
}