using AutoMapper;

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.Core.Models;
using Ombudsman.DataLayer;

namespace Ombudsman.BizLogicLayer;

internal class DocumentRealizationService : IDocumentRealizationService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IDocumentRealizationRepository repository;
    private readonly IMapper mapper;
    private readonly IAuthService auth;

    public DocumentRealizationService(
        IUnitOfWork unitOfWork,
        IDocumentRealizationRepository repository,
        IMapper mapper,
        IAuthService auth)
    {
        this.unitOfWork = unitOfWork;
        this.repository = repository;
        this.mapper = mapper;
        this.auth = auth;
    }

    public async ValueTask<int> Create(CreateDocumentRealizationDto dto)
    {
        Validate(dto);
        DocumentRealization insertedDoc;
        var exStrategy = unitOfWork.Context.Database.CreateExecutionStrategy();
        return await exStrategy.ExecuteAsync(async () =>
             {
                 using var transaction = await unitOfWork.BeginTransaction();
                 try
                 {
                     // Document inserting...
                     var doc = mapper.Map<DocumentRealization>(dto);
                     doc.CreatedAt = DateTime.Now;
                     doc.CreatedUserId = auth.User.Id;
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
                 }
                 catch(Exception ex)
                 {
                     transaction.Rollback();
                     throw ex;
                 }
                 transaction.Commit();
                 return insertedDoc.Id;
             });
    }

    public async ValueTask<int> Update(UpdateDocumentRealizationDto dto)
    {
        Validate(dto);
        await unitOfWork.BeginTransaction();
        try
        {
            var doc = await repository.SelectByIdWithDetailsAsync(
                expression: d => d.Id == dto.Id
                && d.OrganizationId == auth.User.OrganizationId,
               new string[]
               {
                   nameof(DocumentRealization.InformationLetters),
                   nameof(InformationLetter.Tables),
                   nameof(DocumentRealization.Tables)
               });

            doc = mapper.Map(dto, doc);
            doc.UpdatedAt = DateTime.Now;
            doc.UpdatedUserId = auth.User.Id;
            if(dto.InformationLetter != null)
            {
                var letter = doc.InformationLetters.FirstOrDefault();
                mapper.Map(dto.InformationLetter, letter);
                await unitOfWork.Save();
                foreach(var item in dto.InformationLetter.InformationLetterTables)
                {
                    if(item.Id == null)
                    {
                        var table = mapper.Map<InformationLetterTable>(item);
                        table.OwnerId = letter.Id;
                        unitOfWork.Context.InformationLetterTables.Add(table);
                    }
                    else
                    {
                        var table = doc.InformationLetters.FirstOrDefault()
                            .Tables.FirstOrDefault(t => t.Id == item.Id);
                        table = mapper.Map(item, table);
                    }
                }
            }
            foreach(var item in dto.DocumentRealizationTables)
            {
                if(item.Id == null)
                {
                    var table = mapper.Map<DocumentRealizationTable>(item);
                    table.OwnerId = doc.Id;
                    unitOfWork.Context.DocumentRealizationTables.Add(table);
                }
                else
                {
                    var table = doc.InformationLetters.FirstOrDefault()
                        .Tables.FirstOrDefault(t => t.Id == item.Id);
                    table = mapper.Map(item, table);
                }
            }
            await unitOfWork.Save();

            await unitOfWork.Commit();
            return doc.Id;

        }
        catch(Exception ex)
        {
            await unitOfWork.Rollback();
        }
        return 0;

    }
    private void Validate(CreateDocumentRealizationDto dto)
    {
        if(dto == null)
            throw new ArgumentNullException(nameof(dto));

        if(dto.DocumentStateId == DocumentStateIdConst.LOYIHALANGAN
           && (dto.DocNumber == null || dto.DocDate == null))
            throw new Exception("Your document is not designed");
        if(dto.DocumentTypeId == 6
            && dto.InformationLetter != null)
            throw new Exception("Your document type is Memorandum, and " +
                "it dosn't contain Information Letter ");
        if(dto.DocumentTypeId != 6
            && dto.InformationLetter == null)
            throw new Exception("Information Letter can not be null");

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
                doc.File.Id.ToString() +
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
        if(dto != null && dto.FileId != null)
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

    public async ValueTask<IQueryable<DocumentRealizationDto>> GetDocumentRealizationList()
    {
        var query = repository.SelectAll()
           .Where(d => d.OrganizationId == auth.User.OrganizationId);
        return query.Select(d => mapper.Map<DocumentRealizationDto>(d));
    }


}
