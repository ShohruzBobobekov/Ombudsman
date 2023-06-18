namespace Ombudsman.BizLogicLayer;

public interface IOrganizationService
{
    ValueTask<int> Create(CreateOrganizationDto dto);
    ValueTask<IQueryable<OrganizationDto>> GetOrganizations();
    ValueTask<OrganizationDto> GetOrganizationById(int id);
    ValueTask<int> Update(UpdateOrganizationDto dto);
    ValueTask<int> Delete(int id);
}
