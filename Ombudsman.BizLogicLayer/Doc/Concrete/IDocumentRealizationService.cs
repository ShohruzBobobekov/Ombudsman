using Microsoft.AspNetCore.Http;

namespace Ombudsman.BizLogicLayer;

public interface IDocumentRealizationService
{
    ValueTask<int> Create(CreateDocumentRealizationDto dto);
    ValueTask<DocumentRealizationDto> GetDocumentRealizationById(int id);
    ValueTask<IQueryable<DocumentRealizationDto>> GetDocumentRealizationList();
    ValueTask<int> Update(UpdateDocumentRealizationDto dto);
    ValueTask<int> Delete(int id);
    ValueTask<string> GetDocumentRealizationFilePath(int id);
    ValueTask<Guid> UploadFile(int documentId, IFormFile file);

}
