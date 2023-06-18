using Microsoft.AspNetCore.Mvc;

using Ombudsman.BizLogicLayer;

namespace Ombudsman.Api.Controllers;


public class OrganizationController : BaseController
{
    private readonly IOrganizationService service;

    public OrganizationController(IOrganizationService service)
    {
        this.service = service;
    }

    public async ValueTask<ActionResult<int>> Create(CreateOrganizationDto dto)=>
        Ok(await service.Create(dto));
    public async ValueTask<ActionResult<IQueryable<OrganizationDto>>> GetOrganizations()=>
        Ok(await service.GetOrganizations());
    public async ValueTask<ActionResult<OrganizationDto>> GetOrganizationById(int id)=>
        Ok(await service.GetOrganizationById(id));
    public async ValueTask<ActionResult<int>> Update(UpdateOrganizationDto dto)=>
        Ok(await service.Update(dto));
    public async ValueTask<ActionResult<int>> Delete(int id)=>
        Ok(await service.Delete(id));
}
