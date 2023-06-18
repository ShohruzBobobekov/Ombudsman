using Ombudsman.Core.Models;

namespace Ombudsman.DataLayer.Repositories;

internal class EmployeeRepository : GenericRepository<Employee, int>, IEmployeeRepository
{
    public EmployeeRepository(AppDbContext appDbContext)
        : base(appDbContext)
    {
    }
}
