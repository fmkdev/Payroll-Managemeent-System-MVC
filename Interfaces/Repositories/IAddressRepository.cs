using System.Threading.Tasks;
using PayxApi.Models;

namespace PayxApi.Interfaces.Repositories
{
    public interface IAddressRepository
    {
        Task<bool> CreteAsync(Address address);

        Task<bool> UpdateAsync(Address address);

        Task<Address> GetAsync(int Id);
    }
}