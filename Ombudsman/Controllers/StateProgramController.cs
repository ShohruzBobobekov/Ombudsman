using Microsoft.AspNetCore.Mvc;

using Ombudsman.BizLogicLayer;

namespace Ombudsman.Api.Controllers;

public class StateProgramController : BaseController
{
    private readonly IStateProgramService service;

    public StateProgramController(IStateProgramService service)
    {
        this.service = service;
    }
    [HttpPost]
    public async ValueTask<ActionResult<int>> Create(CreateStateProgramDto dto)
    {
        return Ok(await service.Create(dto));
    }
    [HttpDelete]
    public async ValueTask<ActionResult<int>> Delete(int id)
    {
        return Ok(await service.Delete(id));
    }
    [HttpGet]
    public async ValueTask<ActionResult<StateProgramDto>> GetStateProgramById(int id)
    {
        return Ok(await service.GetStateProgramById(id));
    }
    [HttpGet]
    public async ValueTask<ActionResult<IQueryable<StateProgramDto>>> GetStatePrograms()
    {
        return Ok(await service.GetStatePrograms());
    }
    [HttpPost]
    public async ValueTask<ActionResult<int>> Update(UpdateStateProgramDto dto)
    {
        return Ok(await service.Update(dto));
    }
}
