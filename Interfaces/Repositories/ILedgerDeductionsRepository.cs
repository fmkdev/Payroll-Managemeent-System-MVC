using System.Threading.Tasks;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface ILedgerDeductionsRepository
    {
        Task<bool> CreateAsync(LedgerDeduction LedgerDeductions);
    }
}