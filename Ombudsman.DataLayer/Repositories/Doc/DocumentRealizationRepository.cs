using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ombudsman.Core.Models;

namespace Ombudsman.DataLayer;

internal class DocumentRealizationRepository : GenericRepository<DocumentRealization, int>,
    IDocumentRealizationRepository
{
    public DocumentRealizationRepository(AppDbContext appDbContext)
        : base(appDbContext)
    {
    }
}
