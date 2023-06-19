using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Ombudsman.BizLogicLayer;

namespace Ombudsman.Api.Controllers;

[Authorize]
public class UserController : BaseController
{
    private readonly IUserService userService;
    public UserController(IUserService userService)
    {
        this.userService = userService;
    }

    [HttpPost]
    public async ValueTask<IActionResult> Create(CreateUserDlDto user) =>
        Ok(await userService.Create(user));


    [HttpGet]
    public async ValueTask<IActionResult> GetList() =>
        Ok(await userService.GetList());

    [HttpGet]
    public async ValueTask<IActionResult> GetById(int id) =>
        Ok(await userService.GetById(id));

    [HttpPost]
    public async ValueTask<IActionResult> Update(UpdateUserDlDto user) =>
        Ok(await userService.Update(user));

    [HttpDelete]
    public async ValueTask<IActionResult> Delete(int id) =>
        Ok(await userService.Delete(id));
}
