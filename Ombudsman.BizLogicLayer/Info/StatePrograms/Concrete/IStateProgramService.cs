namespace Ombudsman.BizLogicLayer;

public interface IStateProgramService
{
    ValueTask<int> Create(CreateStateProgramDto dto);
    ValueTask<IQueryable<StateProgramDto>> GetStatePrograms();
    ValueTask<StateProgramDto> GetStateProgramById(int id);
    ValueTask<int> Update(UpdateStateProgramDto dto);
    ValueTask<int> Delete(int id);
}
