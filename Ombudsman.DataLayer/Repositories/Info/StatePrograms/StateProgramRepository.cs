using Ombudsman.Core.Models;

namespace Ombudsman.DataLayer;

internal class StateProgramRepository : GenericRepository<StateProgram, int>
    , IStateProgramRepository
{
    public StateProgramRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
