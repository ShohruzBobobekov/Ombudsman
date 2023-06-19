using AutoMapper;

using Ombudsman.Core.Models;
using Ombudsman.DataLayer;

namespace Ombudsman.BizLogicLayer;

internal class StateProgramService : IStateProgramService
{
    private readonly IStateProgramRepository repository;
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public StateProgramService(
        IStateProgramRepository repository,
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async ValueTask<int> Create(CreateStateProgramDto dto)
    {
        var entity = mapper.Map<StateProgram>(dto);
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

    public async ValueTask<StateProgramDto> GetStateProgramById(int id)
    {
        var entity = await repository.SelectByIdAsync(id);
        return mapper.Map<StateProgramDto>(entity);
    }

    public async ValueTask<IQueryable<StateProgramDto>> GetStatePrograms()
    {
        var query = repository.SelectAll();
        return query.Select(sp => mapper.Map<StateProgramDto>(sp));
    }

    public async ValueTask<int> Update(UpdateStateProgramDto dto)
    {
        var entity = await repository.SelectByIdAsync(dto.Id);
        entity = mapper.Map(dto, entity);
        await unitOfWork.Save();
        return entity.Id;
    }
}
