using Microsoft.AspNetCore.Mvc;

using Ombudsman.BizLogicLayer;

namespace Ombudsman.Api.Controllers;

[Route("[controller]/[action]")]
public class UserController : BaseController
{
    private readonly IUserService userService;

    public UserController(IUserService userService)
    {
        this.userService=userService;
    }

    [HttpPost]
    public IActionResult Create(CreateUserDlDto user)
    {
        return Ok(userService.Create(user));
    }

    [HttpGet]
    public IActionResult GetList() => Ok(userService.GetList());

    [HttpGet]
    public IActionResult GetById(int id) => Ok(userService.GetById(id));

    [HttpPost]
    public IActionResult Update(UpdateUserDlDto user) => Ok(userService.Update(user));

    [HttpDelete]
    public IActionResult Delete(int id) => Ok(userService.Delete(id));
}
