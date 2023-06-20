using AutoMapper;

using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.Core.Models;
using Ombudsman.DataLayer;

namespace Ombudsman.BizLogicLayer;

internal class OrganizationService : IOrganizationService
{
    private readonly IOrganizationRepository repository;
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    private readonly IAuthService auth;

    public OrganizationService(
        IOrganizationRepository repository,
        IUnitOfWork unitOfWork,
        IMapper mapper,
        IAuthService auth)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        this.auth = auth;
    }

    public async ValueTask<int> Create(CreateOrganizationDto dto)
    {
        var entity = mapper.Map<Organization>(dto);
        entity.CreatedAt = DateTime.Now;
        entity.CreatedUserId = auth.User.Id;
        entity.StateId = StateIdConst.ACTIVE;
        entity = await repository.InsertAsync(entity);
        await unitOfWork.Save();
        return entity.Id;
    }

    public async ValueTask<int> Delete(int id)
    {
        var entity = await repository.SelectByIdAsync(id);

        entity.StateId = StateIdConst.DELETED;
        await unitOfWork.Save();
        return entity.Id;
    }

    public async ValueTask<OrganizationDto> GetOrganizationById(int id)
    {
        var entity = await repository.SelectByIdAsync(id);
        return mapper.Map<OrganizationDto>(entity);
    }

    public async ValueTask<IQueryable<OrganizationDto>> GetOrganizations()
    {
        var query = repository.SelectAll();
        return query.Select(e => mapper.Map<OrganizationDto>(e));
    }

    public async ValueTask<int> Update(UpdateOrganizationDto dto)
    {
        var entity = await repository.SelectByIdAsync(dto.Id);
        entity = mapper.Map(dto, entity);
        entity.UpdatedUserId = auth.User.Id;
        entity.UpdatedAt = DateTime.Now;
        await unitOfWork.Save();
        return entity.Id;
    }
}
