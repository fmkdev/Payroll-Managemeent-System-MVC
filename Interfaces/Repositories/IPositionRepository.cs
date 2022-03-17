using System.Collections.Generic;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IPositionRepository
    {
        Task<bool> CreateAsync(Position position);

        Task<PositionDTO> GetAsync(int id);
        
        Task<PositionDTO> GetAsync(string name);

        Task<IEnumerable<PositionDTO>> GetAsync();

        Task<IEnumerable<Allowance>> GetAsync(IList<int> ids);
    }
}