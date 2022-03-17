using System.Threading.Tasks;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface ITaxRepository
    {
        Task<bool> CreateAsync(Tax tax);
    }
}