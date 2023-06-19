using AutoMapper;

using Microsoft.AspNetCore.Http;

using Ombudsman.Core.Models;
using Ombudsman.DataLayer;

namespace Ombudsman.BizLogicLayer;

internal class DocumentRealizationService : IDocumentRealizationService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IDocumentRealizationRepository repository;
    private readonly IMapper mapper;

    public DocumentRealizationService(
        IUnitOfWork unitOfWork,
        IDocumentRealizationRepository repository,
        IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.repository = repository;
        this.mapper = mapper;
    }

    public async ValueTask<int> Create(CreateDocumentRealizationDto dto)
    {
        DocumentRealization insertedDoc;
      //  using var transaction = await unitOfWork.BeginTransaction();
        try
        {
            // Document inserting...
            var doc = mapper.Map<DocumentRealization>(dto);
            doc.CreatedAt = DateTime.Now;
            insertedDoc = await repository.InsertAsync(doc);
            await unitOfWork.Save();
            // Information Letter inserting...
            var letter = mapper.Map<InformationLetter>(dto.InformationLetter);
            letter.OwnerId = insertedDoc.Id;
            unitOfWork.Context.InformationLetters.Add(letter);

            await unitOfWork.Save();

            // Document Tables inserting...
            foreach(var item in dto.DocumentRealizationTables)
            {
                var table = mapper.Map<DocumentRealizationTable>(item);
                table.OwnerId = insertedDoc.Id;
                unitOfWork.Context.DocumentRealizationTables.Add(table);
            }

            // Information Letter Tables inserting...
            foreach(var item in dto.InformationLetter.InformationLetterTables)
            {
                var table = mapper.Map<InformationLetterTable>(item);
                table.OwnerId = letter.Id;
                unitOfWork.Context.InformationLetterTables.Add(table);
            }
           await unitOfWork.Save();

            // Uploaded File Saving ...


        }
        catch(Exception ex)
        {
            //transaction.Rollback();
            throw ex;
        }

        //transaction.Commit();
        return insertedDoc.Id;
    }
    public async ValueTask<Guid> UploadFile(int documentId, IFormFile file)
    {
        var extension = Path.GetExtension(file.FileName);
        var fileModel = new FileModel()
        {
            Extension = extension,
            Name = file.FileName.Replace(extension, "")
        };

        var doc = await repository.SelectByIdWithDetailsAsync(
            d => d.Id == documentId,
            new string[] { nameof(DocumentRealization.File) });

        if(doc.File != null)
        {
            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Uploads",
                doc.File.Id.ToString()+
                doc.File.Extension);

            using(var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            doc.File.Name = file.FileName;
            await unitOfWork.Save();
            return doc.File.Id;
        }

        fileModel = unitOfWork.Context.FileModels.Add(fileModel).Entity;

        doc.FileId = fileModel.Id;
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");

        if(!Directory.Exists(filePath))
            Directory.CreateDirectory(filePath);

        filePath = Path.Combine(filePath,
            fileModel.Id.ToString()
            + fileModel.Extension);

        using(var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }
        await unitOfWork.Save();
        return fileModel.Id;
    }

    public async ValueTask<int> Delete(int id)
    {
        var doc = await repository.SelectByIdAsync(id);
        doc.StateId = StateIdConst.DELETED;
        await unitOfWork.Save();
        return doc.Id;
    }

    public async ValueTask<DocumentRealizationDto> GetDocumentRealizationById(int id)
    {
        var doc = await repository.SelectByIdWithDetailsAsync(
            expression: dr => dr.Id == id,
            new string[]
            {
                nameof(DocumentRealization.DocumentType),
                nameof(DocumentRealization.File),
                nameof(DocumentRealization.Importance),
                nameof(DocumentRealization.InitiativeType),
                nameof(DocumentRealization.ResponsibleSector),
                nameof(DocumentRealization.State),
                nameof(DocumentRealization.Tables),
                nameof(DocumentRealization.InformationLetters),
                nameof(InformationLetter.Tables)
            });
        var dto = mapper.Map<DocumentRealizationDto>(doc);
        dto.FileName = doc.File.Name + doc.File.Extension;
        return dto;
    }

    public async ValueTask<string> GetDocumentRealizationFilePath(int id)
    {
        var doc = await repository.SelectByIdWithDetailsAsync(
            expression: dr => dr.Id == id,
            new string[] { nameof(DocumentRealization.File) });

        if(doc == null || doc.File == null || doc.StateId == StateIdConst.DELETED)
            throw new Exception("File not found for given id");

        var filePath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Uploads",
            doc.File.Id.ToString()
            + doc.File.Extension);
        return filePath;
    }

    public ValueTask<IQueryable<DocumentRealizationDto>> GetDocumentRealizationList()
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> Update(UpdateDocumentRealizationDto dto)
    {
        throw new NotImplementedException();
    }

}
