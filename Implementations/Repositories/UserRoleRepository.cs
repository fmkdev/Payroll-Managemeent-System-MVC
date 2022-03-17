using PayxApi.ContextDb;
using PayxApi.Interfaces.Repositories;
using PayxApi.Models;

namespace PayxApi.Implementations.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ContextApp _context;
        public UserRoleRepository(ContextApp context)
        {
            _context = context;
        }
    }
}