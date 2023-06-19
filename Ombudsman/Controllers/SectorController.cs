using Microsoft.AspNetCore.Mvc;

using Ombudsman.BizLogicLayer;

namespace Ombudsman.Api.Controllers;

public class SectorController : BaseController
{
    private readonly ISectorService service;

    public SectorController(ISectorService service)
    {
        this.service = service;
    }
    [HttpPost]
    public async ValueTask<ActionResult<int>> Create(CreateSectorDto dto) =>
        Ok(await service.Create(dto));
    [HttpDelete]
    public async ValueTask<ActionResult<int>> Delete(int id) =>
        Ok(await service.Delete(id));
    [HttpGet]
    public async ValueTask<ActionResult<SectorDto>> GetSectorById(int id) =>
        Ok(await service.GetSectorById(id));
    [HttpGet]
    public async ValueTask<ActionResult<IQueryable<SectorDto>>> GetSectors() =>
        Ok(await service.GetSectors());
    [HttpPost]
    public async ValueTask<ActionResult<int>> Update(UpdateSectorDto dto) =>
        Ok(await service.Update(dto));
}
