using System.Linq;
using System.Threading.Tasks;
using PayxApi.DTOs;
using PayxApi.Interfaces.Repositories;
using PayxApi.Interfaces.Services;

namespace PayxApi.Implementations.Services
{
    public class LedgerService : ILedgerService
    {
        private readonly ILedgerRepository _ledgerRepository;
        public LedgerService(ILedgerRepository ledgerRepository)
        {
            _ledgerRepository = ledgerRepository;
        }

        public async Task<BaseResponse<LedgerDTO>> GetAsync(int ledgerId)
        {
            var ledger = await _ledgerRepository.GetAsync(ledgerId);
            if(ledger == null)
            {
                return new BaseResponse<LedgerDTO>
                {
                    IsSuccess = false,
                    Message = "Ledger not found"
                };
            }
            return new BaseResponse<LedgerDTO>
            {
                IsSuccess = true,
                Message = "Success",
                Data = new LedgerDTO
                {
                    Id = ledger.Id,
                    Balance = ledger.Balance,
                    Employee = new EmployeeDTO
                    {
                        Id = ledger.Employee.Id,
                        FullName = $"{ledger.Employee.FirstName} {ledger.Employee.LastName}"
                    },
                    LedgerAdds = ledger.LedgerAdds.Where(b => b.BDStatus == Enum.BDStatus.Given).Select(a => new LedgerAddDTO
                    {
                        Id = a.Id,
                        Amount = a.Amount,
                        AddName = a.AddName,
                        BDStatus = a.BDStatus,
                    }).ToList(),
                    LedgerDeductions = ledger.LedgerDeductions.Where(b => b.BDStatus == Enum.BDStatus.Given).Select(d => new LedgerDeductionDTO
                    {
                        Id = d.Id,
                        Amount = d.Amount,
                        DeductionName = d.DeductionName,
                        BDStatus = d.BDStatus,
                    }).ToList(),
                    Salaries = ledger.Salaries.Where(b => b.BDStatus == Enum.BDStatus.Given).Select(s => new SalaryDTO
                    {
                        Id = s.Id,
                        Amount = s.Amount,
                        Narration = s.Narration,
                        BDStatus = s.BDStatus
                    }).ToList()
                }
            };
        }
    }
}