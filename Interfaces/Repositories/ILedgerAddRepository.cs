using System.Threading.Tasks;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface ILedgerAddRepository
    {
        Task<bool> CreateAsync(LedgerAdd LedgerAdd);
    }
}