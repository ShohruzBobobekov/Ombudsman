using Microsoft.AspNetCore.Mvc;

using Ombudsman.BizLogicLayer;

namespace Ombudsman.Api.Controllers;

public class DocumentRealizationController : BaseController
{
    private readonly IDocumentRealizationService service;

    public DocumentRealizationController(IDocumentRealizationService service)
    {
        this.service = service;
    }

    [HttpPost]
    public async ValueTask<ActionResult<int>> Create(CreateDocumentRealizationDto dto) =>
        Ok(await service.Create(dto));

    [HttpGet]
    public async ValueTask<ActionResult<DocumentRealizationDto>> GetDocumentRealizationById(int id) =>
        Ok(await service.GetDocumentRealizationById(id));

    [HttpGet]
    public async ValueTask<ActionResult> DownloadFile(int documentId)
    {
        var filePath = await service.GetDocumentRealizationFilePath(documentId);
        if(!System.IO.File.Exists(filePath))
            return NotFound();


        var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        return File(fileStream, "application/octet-stream", filePath);
    }

    [HttpPost]
    public async ValueTask<ActionResult<Guid>> UploadFile(int documentId, IFormFile file)
    {
        return await service.UploadFile(documentId, file);
    }
}
