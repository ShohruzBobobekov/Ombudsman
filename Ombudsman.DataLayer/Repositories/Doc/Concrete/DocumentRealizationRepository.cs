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
