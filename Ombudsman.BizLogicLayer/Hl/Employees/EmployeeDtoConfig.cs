using AutoMapper;

using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer.Hl.Employees;

public class EmployeeDtoConfig : Profile
{
    public EmployeeDtoConfig()
    {
        CreateMap<CreateEmployeeDto, Employee>();
    }
}
