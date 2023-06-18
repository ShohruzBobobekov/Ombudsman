using AutoMapper;

using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer;

public class EmployeeDtoConfig : Profile
{
    public EmployeeDtoConfig()
    {
        CreateMap<CreateEmployeeDto, Employee>();
    }
}
