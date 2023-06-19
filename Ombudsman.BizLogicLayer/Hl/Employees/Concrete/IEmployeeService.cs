using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer;

public interface IEmployeeService
{
    ValueTask<int> Create(CreateEmployeeDto dto);
    ValueTask<IQueryable<Employee>> GetEmployees();
    ValueTask<Employee> GetEmployeeById(int id);
    ValueTask<int> Update(UpdateEmployeeDto dto);
    ValueTask<int> Delete(int id);
}
