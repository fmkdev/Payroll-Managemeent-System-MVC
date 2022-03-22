using System.Threading.Tasks;
using PayxApi.DTOs;

namespace PayxApi.Interfaces.Services
{
    public interface IAddressService
    {
        Task<BaseResponse<bool>> UpdateAsync(int id, UpdateAddressRequestModel model);
        Task<BaseResponse<AddressDTO>> GetAsync(int id);
    }
}