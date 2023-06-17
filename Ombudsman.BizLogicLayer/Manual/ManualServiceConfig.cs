using AutoMapper;

using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer.Manual;

public class ManualServiceConfig : Profile
{
    public ManualServiceConfig()
    {
        CreateMap<DocumentImportance, DocumentImportanceDto>();
            
    }
}
