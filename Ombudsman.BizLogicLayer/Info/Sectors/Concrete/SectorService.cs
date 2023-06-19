using AutoMapper;

using Ombudsman.Core.Models;
using Ombudsman.DataLayer;

namespace Ombudsman.BizLogicLayer;

internal class SectorService : ISectorService
{
    private readonly ISectorRepository repository;
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public SectorService(
        ISectorRepository repository,
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async ValueTask<int> Create(CreateSectorDto dto)
    {
        var entity = mapper.Map<Sector>(dto);
        entity.CreatedAt= DateTime.Now;
        entity.StateId = StateIdConst.ACTIVE;
        await repository.InsertAsync(entity);
        await unitOfWork.Save();
        return entity.Id;
    }

    public async ValueTask<int> Delete(int id)
    {
        var entity =await repository.SelectByIdAsync(id);
        entity.StateId = StateIdConst.DELETED;
        await unitOfWork.Save();
        return entity.Id;
    }

    public async ValueTask<SectorDto> GetSectorById(int id)
    {
        var entity =await repository.SelectByIdAsync(id);
        return mapper.Map<SectorDto>(entity);
    }

    public async ValueTask<IQueryable<SectorDto>> GetSectors()
    {
        var query = repository.SelectAll();
        // check org
        return query.Select(e=>mapper.Map<SectorDto>(e));
    }

    public async ValueTask<int> Update(UpdateSectorDto dto)
    {
        var entity =await repository.SelectByIdAsync(dto.Id);
        entity=mapper.Map(dto,entity);
        await unitOfWork.Save();
        return entity.Id;

    }
}
