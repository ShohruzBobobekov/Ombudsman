using Ombudsman.Core.Models;

namespace Ombudsman.DataLayer;

internal class SectorRepository : GenericRepository<Sector, int>
    , ISectorRepository
{
    public SectorRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
