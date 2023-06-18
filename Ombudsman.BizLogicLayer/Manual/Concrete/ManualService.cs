using AutoMapper;

using Microsoft.EntityFrameworkCore;

using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.Core.Models;
using Ombudsman.DataLayer;

namespace Ombudsman.BizLogicLayer.Manual.Concrete;

internal class ManualService : IManualService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    private readonly IAuthService authService;

    public ManualService(
        IMapper mapper,
        IUnitOfWork unitOfWork,
        IAuthService authService)
    {
        this.mapper = mapper;
        this.unitOfWork = unitOfWork;
        this.authService = authService;
    }

    public async ValueTask<IQueryable<DocumentImportanceDto>> GetDocumentImportanceList()
    {
        var query = unitOfWork.Context.Set<DocumentImportance>()
            .Include(d => d.State)
            .Where(d => d.StateId == StateIdConst.ACTIVE)
            .Select(e => mapper.Map<DocumentImportanceDto>(e));
       
        return query;
    }

    public async ValueTask<IQueryable<DocumentRealizerTypeDto>> GetDocumentRealizerTypeList()
    {
        var query = unitOfWork.Context.Set<DocumentRealizerType>()
            .Include(d => d.State)
            .Where(d => d.StateId == StateIdConst.ACTIVE)
            .Select(e => mapper.Map<DocumentRealizerTypeDto>(e));

        return query;
    }

    public async ValueTask<IQueryable<DocumentStateDto>> GetDocumentStateList()
    {
        var query = unitOfWork.Context.Set<DocumentState>()
           .Include(d => d.State)
           .Where(d => d.StateId == StateIdConst.ACTIVE)
           .Select(e => mapper.Map<DocumentStateDto>(e));

        return query;
    }

    public async ValueTask<IQueryable<DocumentTypeDto>> GetDocumentTypeList()
    {
        var query = unitOfWork.Context.Set<DocumentType>()
       .Include(d => d.State)
       .Where(d => d.StateId == StateIdConst.ACTIVE)
       .Select(e => mapper.Map<DocumentTypeDto>(e));

        return query;
    }

    public async ValueTask<IQueryable<GovernmentOrganizationTypeDto>> GetGovernmentOrganizationTypeList()
    {
        var query = unitOfWork.Context.Set<GovernmentOrganizationType>()
        .Include(d => d.State)
        .Where(d => d.StateId == StateIdConst.ACTIVE)
        .Select(e => mapper.Map<GovernmentOrganizationTypeDto>(e));

        return query;
    }

    public async ValueTask<IQueryable<LanguageDto>> GetLanguageList()
    {
        var query = unitOfWork.Context.Set<Language>()
       .Select(e => mapper.Map<LanguageDto>(e));

        return query;
    }

    public async ValueTask<IQueryable<StateDto>> GetStateList()
    {
        var query = unitOfWork.Context.Set<State>()
        .Select(e => mapper.Map<StateDto>(e));

        return query;
    }

    public async ValueTask<IQueryable<UserRoleDto>> GetUserRoleList()
    {
        var query = unitOfWork.Context.Set<UserRole>()
       .Include(d => d.State)
       .Where(d => d.StateId == StateIdConst.ACTIVE)
       .Select(e => mapper.Map<UserRoleDto>(e));

        return query;
    }    
}
