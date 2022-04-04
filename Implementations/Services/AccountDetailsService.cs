using System;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class AccountDetailsService : IAccountDetailsService
    {
        private readonly IAccountDetailsRepository _accountDetailsRepository;

        public AccountDetailsService(IAccountDetailsRepository accountDetailsRepository)
        {
            _accountDetailsRepository = accountDetailsRepository;
        }

        public async Task<BaseResponse<AccountDetailsDTO>> GetAsync(int id)
        {
            var acd = await _accountDetailsRepository.GetAsync(id);
            return new BaseResponse<AccountDetailsDTO>
            {
                IsSuccess = true,
                Message = "Success",
                Data = new AccountDetailsDTO
                {
                    Id = acd.Id,
                    AccountNumber = acd.AccountNumber,
                    BankName = acd.BankName
                }
            };
        }

        public async Task<BaseResponse<bool>> UpdateeAsync(int id, UpdateAccountDetailsRequestModel model)
        {
            if (model.AccountNumber == null || model.BankName == null)
            {
                return new BaseResponse<bool>
                {
                    IsSuccess = false,
                    Message = "Entries Cant be Null",
                    Data = false
                };
            }
            var employee = await _accountDetailsRepository.GetAsync(id);
            employee.AccountNumber = model.AccountNumber;
            employee.BankName = model.BankName;
            employee.Modified = DateTime.UtcNow;

            await _accountDetailsRepository.UpdateAsync(employee);
            return new BaseResponse<bool>
            {
                IsSuccess = true,
                Message = "Success",
                Data = true
            };
        }
    }
}