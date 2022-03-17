using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IPayLevelRepository
    {
        Task<bool> CreateAsync(PayLevel payLevel);

        Task<IEnumerable<PayLevelDTO>> GetAsync();
    }
}