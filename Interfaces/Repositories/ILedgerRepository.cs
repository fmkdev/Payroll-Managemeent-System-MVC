using System.Threading.Tasks;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface ILedgerRepository
    {
        Task<bool> CreateAsync(Ledger Ledger);

        Task<bool> UpdateAsync(Ledger Ledger);
    }
}