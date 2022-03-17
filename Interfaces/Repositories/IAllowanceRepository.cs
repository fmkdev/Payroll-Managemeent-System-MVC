using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IAllowanceRepository
    {
        Task<bool> Create(Allowance allowance);

        Task<IEnumerable<Allowance>> GetAsync(IList<int> ids);
        
        Task<IEnumerable<AllowanceDTO>> GetAsync();
    }
}