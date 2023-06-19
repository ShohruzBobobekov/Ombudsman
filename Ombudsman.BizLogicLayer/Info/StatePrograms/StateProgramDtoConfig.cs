using AutoMapper;

using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer;

public class StateProgramDtoConfig : Profile
{
    public StateProgramDtoConfig()
    {
        CreateMap<CreateStateProgramDto, StateProgram>();

        CreateMap<StateProgram, StateProgramDto>();
    }
}
