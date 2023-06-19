using AutoMapper;

using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer;

public class SectorDtoConfig : Profile
{
    public SectorDtoConfig()
    {
        CreateMap<CreateSectorDto, Sector>()
            .ForMember(e => e.CreatedAt, cfg => cfg.MapFrom(d => DateTime.Now));
        CreateMap<Sector, SectorDto>();
    }
}
