namespace Ombudsman.BizLogicLayer;

public interface ISectorService
{
    ValueTask<int> Create(CreateSectorDto dto);
    ValueTask<IQueryable<SectorDto>> GetSectors();
    ValueTask<SectorDto> GetSectorById(int id);
    ValueTask<int> Update(UpdateSectorDto dto);
    ValueTask<int> Delete(int id);
}
