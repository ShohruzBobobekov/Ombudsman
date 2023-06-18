using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ombudsman.Core.Models;

namespace Ombudsman.DataLayer;

internal class OrganizationRepository : GenericRepository<Organization, int>
    , IOrganizationRepository
{
    public OrganizationRepository(AppDbContext appDbContext) : base(appDbContext)
    {
    }
}
