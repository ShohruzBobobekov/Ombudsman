using Ombudsman.BizLogicLayer.User;
namespace Ombudsman.BizLogicLayer;

public interface IUserService
{
    ValueTask<int>Create(UserDlDto dto);

    ValueTask<int>Update(UpdateUserDlDto dto);
    ValueTask<int>Delete(int id);
}
