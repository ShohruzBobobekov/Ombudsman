using Ombudsman.Core.Models;

namespace Ombudsman.DataLayer.Repositories;

internal class UserRepository : GenericRepository<User, int>, IUserRepository
{
    public UserRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
