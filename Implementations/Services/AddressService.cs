using System;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IUserRepository _userRepository;

        public AddressService(IAddressRepository addressRepository, IUserRepository userRepository)
        {
            _addressRepository = addressRepository;
            _userRepository = userRepository;
        }

        public async Task<BaseResponse<AddressDTO>> GetAsync(int id)
        {
            var address = await _addressRepository.GetAsync(id);
            return new BaseResponse<AddressDTO>
            {
                IsSuccess = true,
                Message = "Success",
                Data = new AddressDTO
                {
                    HouseNumber = address.HouseNumber,
                    StreetName = address.StreetName,
                    LocalGovernment = address.LocalGovernment,
                    City = address.City,
                    State = address.State,
                    Nationality = address.Nationality,
                    HomeNumber = address.HomeNumber
                }
            };
        }

        public async Task<BaseResponse<bool>> UpdateAsync(int id, UpdateAddressRequestModel model)
        {
            if (model.HomeNumber == null || model.StreetName == null || model.LocalGovernment == null || model.City == null ||
            model.State == null || model.Nationality == null || model.HouseNumber == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Entries Cant be Null",
                    Data = false
                };
            }
            var employee = await _addressRepository.GetAsync(id);
            
            employee.HouseNumber = model.HouseNumber;
            employee.StreetName = model.StreetName;
            employee.City = model.City;
            employee.State = model.State;
            employee.LocalGovernment = model.LocalGovernment;
            employee.Nationality = model.Nationality;
            employee.HomeNumber = model.HomeNumber;
            employee.Modified = DateTime.UtcNow;

            await _addressRepository.UpdateAsync(employee);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Success",
                Data = true
            };
        }
    }
}