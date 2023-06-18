namespace Ombudsman.BizLogicLayer;

public interface IUserService
{
    ValueTask<int>Create(CreateUserDlDto dto);
    ValueTask<List<UserDto>> GetList();
    ValueTask<UserDto> GetById(int id);
    ValueTask<int>Update(UpdateUserDlDto dto);
    ValueTask<int>Delete(int id);
}
