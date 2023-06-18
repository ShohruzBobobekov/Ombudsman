using AutoMapper;

using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer;

public class OrganizationDtoConfig : Profile
{
    public OrganizationDtoConfig()
    {
        CreateMap<Organization, OrganizationDto>();
        CreateMap<CreateOrganizationDto, Organization>();
    }
}
