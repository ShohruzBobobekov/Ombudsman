using AutoMapper;

using Ombudsman.BizLogicLayer.Users;
using Ombudsman.Core.Models;
using Ombudsman.DataLayer.Repositories;

namespace Ombudsman.BizLogicLayer;

internal class UserService : IUserService
{
    private readonly IUserRepository userRepository;
    private readonly IPasswordHasher passwordHasher;
    private readonly IMapper mapper;
    public UserService(IUserRepository userRepository,
        IMapper mapper,
        IPasswordHasher passwordHasher)
    {
        this.userRepository = userRepository;
        this.mapper = mapper;
        this.passwordHasher = passwordHasher;
    }

    public async ValueTask<int> Create(CreateUserDlDto dto)
    {

        var entity = mapper.Map<User>(dto);
        entity.Salt = Guid.NewGuid().ToString();
        entity.PasswordHash = passwordHasher.CreatePasswordHash(dto.Password, entity.Salt);
        entity = await userRepository.InsertAsync(entity);
        return entity.Id;
    }

    public async ValueTask<int> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserDto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<List<UserDto>> GetList()
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> Update(UpdateUserDlDto dto)
    {
        throw new NotImplementedException();
    }
}
