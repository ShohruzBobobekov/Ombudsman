using AutoMapper;
using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.Core.Models;
using Ombudsman.DataLayer;
using Ombudsman.DataLayer.Repositories;

namespace Ombudsman.BizLogicLayer;

internal class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository repository;
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    private readonly IAuthService authService;

    public EmployeeService(
        IEmployeeRepository repository,
        IUnitOfWork unitOfWork,
        IMapper mapper,
        IAuthService authService)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
        this.authService = authService;
    }

    public async ValueTask<int> Create(CreateEmployeeDto dto)
    {
        var employee = mapper.Map<Employee>(dto);
        var entity = await repository.InsertAsync(employee);
        await unitOfWork.Save();
        return entity.Id;
    }

    public async ValueTask<int> Delete(int id)
    {
        var entity = await repository.SelectByIdAsync(id);
        if(entity.OrganizationId != authService.User.OrganizationId)
            throw new Exception("You have't permission for this user.");
        var deleted = await repository.DeleteAsync(entity);
        unitOfWork.Save();
        return deleted.Id;
    }

    public async ValueTask<Employee> GetEmployeeById(int id)
    {
        var employee= await repository.SelectByIdAsync(id);

        if(employee.OrganizationId != authService.User.OrganizationId)
            throw new Exception("Employee Not found for given id");

        return employee;
    }

    public async ValueTask<IQueryable<Employee>> GetEmployees()
    {
        var query = repository.SelectAll();
        query = query.Where(e => e.OrganizationId == authService.User.OrganizationId);
        return query;
    }

    public async ValueTask<int> Update(UpdateEmployeeDto dto)
    {
        var entity = await repository.SelectByIdAsync(dto.Id);
        if(entity.OrganizationId != authService.User.OrganizationId )
            throw new Exception("Employee Not found for given id");
        entity = mapper.Map(dto, entity);
        await unitOfWork.Save();
        return entity.Id;
    }
}
