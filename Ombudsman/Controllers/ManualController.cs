using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Ombudsman.BizLogicLayer;
using Ombudsman.BizLogicLayer.Manual;

namespace Ombudsman.Api.Controllers;
public class ManualController : BaseController
{
    private readonly IManualService service;

    public ManualController(IManualService service)
    {
        this.service = service;
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetDocumentImportanceList()
    {
        return Ok(await service.GetDocumentImportanceList());
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetDocumentRealizerTypeList()
    {
        return Ok(await service.GetDocumentRealizerTypeList());
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetDocumentStateList()
    {
        return Ok(await service.GetDocumentStateList());
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetDocumentTypeList()
    {
        return Ok(await service.GetDocumentTypeList());
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetGovernmentOrganizationTypeList()
    {
        return Ok(await service.GetGovernmentOrganizationTypeList());
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetLanguageList()
    {
        return Ok(await service.GetLanguageList());
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetStateList()
    {
        return Ok(await service.GetStateList());
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetUserRoleList()
    {
        return Ok(await service.GetUserRoleList());
    }
    [HttpGet]
    public async ValueTask<IActionResult> GetInitiativeTypeList()
    {
        return Ok(await service.GetInitiativeTypeList());
    }
}
