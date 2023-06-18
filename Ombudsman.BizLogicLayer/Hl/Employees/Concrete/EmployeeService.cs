using AutoMapper;

using Ombudsman.BizLogicLayer.Hl;
using Ombudsman.BizLogicLayer.Hl.Employees;
using Ombudsman.Core.Models;
using Ombudsman.DataLayer;
using Ombudsman.DataLayer.Repositories;

namespace Ombudsman.BizLogicLayer;

internal class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository repository;
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public EmployeeService(
        IEmployeeRepository repository,
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
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
        var deleted = await repository.DeleteAsync(entity);
        unitOfWork.Save();
        return deleted.Id;
    }

    public async ValueTask<Employee> GetEmployeeById(int id)
    {
        return await repository.SelectByIdAsync(id);
    }

    public async ValueTask<IQueryable<Employee>> GetEmployees()
    {
        var query = repository.SelectAll();
        // organizatsiya ni tekshirish kerak.
        return query;
    }

    public async ValueTask<int> Update(UpdateEmployeeDto dto)
    {
        var entity = await repository.SelectByIdAsync(dto.Id);
        entity = mapper.Map(dto, entity);
        await unitOfWork.Save();
        return entity.Id;
    }
}
