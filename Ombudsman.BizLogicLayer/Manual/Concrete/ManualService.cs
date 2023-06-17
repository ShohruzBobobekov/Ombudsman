using AutoMapper;

using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.DataLayer;

namespace Ombudsman.BizLogicLayer.Manual.Concrete;

internal class ManualService : IManualService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    private readonly IAuthService authService;

    public ValueTask<IQueryable<DocumentImportanceDto>> GetDocumentImportanceList()
    {
        throw new NotImplementedException();
    }

    public ValueTask<IQueryable<DocumentRealizerTypeDto>> GetDocumentRealizerTypeList()
    {
        throw new NotImplementedException();
    }

    public ValueTask<IQueryable<DocumentStateDto>> GetDocumentStateList()
    {
        throw new NotImplementedException();
    }

    public ValueTask<IQueryable<DocumentTypeDto>> GetDocumentTypeList()
    {
        throw new NotImplementedException();
    }

    public ValueTask<IQueryable<GovernmentOrganizationTypeDto>> GetGovernmentOrganizationTypeList()
    {
        throw new NotImplementedException();
    }

    public ValueTask<IQueryable<LanguageDto>> GetLanguageList()
    {
        throw new NotImplementedException();
    }

    public ValueTask<IQueryable<StateDto>> GetStateList()
    {
        throw new NotImplementedException();
    }

    public ValueTask<IQueryable<UserRoleDto>> GetUserRoleList()
    {
        throw new NotImplementedException();
    }
}
