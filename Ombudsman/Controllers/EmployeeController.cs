using Microsoft.AspNetCore.Mvc;

using Ombudsman.BizLogicLayer;
using Ombudsman.BizLogicLayer.Hl;
using Ombudsman.BizLogicLayer.Hl.Employees;
using Ombudsman.Core.Models;

namespace Ombudsman.Api.Controllers;

public class EmployeeController : BaseController
{
    private readonly IEmployeeService service;

    public EmployeeController(IEmployeeService service)
    {
        this.service = service;
    }

    [HttpPost]
    public async ValueTask<ActionResult<int>> Create(CreateEmployeeDto dto) =>
        Ok(await service.Create(dto));
    [HttpGet]
    public async ValueTask<ActionResult<Employee>> GetEmployees() =>
         Ok(await service.GetEmployees());
    [HttpGet]
    public async ValueTask<ActionResult<Employee>> GetEmployeeById(int id) =>
        Ok(await service.GetEmployeeById(id));
    [HttpPost]
    public async ValueTask<ActionResult<int>> Update(UpdateEmployeeDto dto) =>
        Ok(await service.Update(dto));
    [HttpDelete]
    public async ValueTask<ActionResult<int>> Delete(int id) =>
        Ok(await service.Delete(id));
}
