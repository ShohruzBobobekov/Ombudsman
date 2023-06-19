using AutoMapper;

using Microsoft.EntityFrameworkCore;

using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.BizLogicLayer.Users;
using Ombudsman.Core.Models;
using Ombudsman.DataLayer;
using Ombudsman.DataLayer.Repositories;

namespace Ombudsman.BizLogicLayer;

internal class UserService : IUserService
{
    private readonly IUserRepository userRepository;
    private readonly IPasswordHasher passwordHasher;
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOgWork;
    private readonly IAuthService authService;
    public UserService(IUserRepository userRepository,
        IMapper mapper,
        IPasswordHasher passwordHasher,
        IUnitOfWork unitOgWork,
        IAuthService authService)
    {
        this.userRepository = userRepository;
        this.mapper = mapper;
        this.passwordHasher = passwordHasher;
        this.unitOgWork = unitOgWork;
        this.authService = authService;
    }

    public async ValueTask<int> Create(CreateUserDlDto dto)
    {

        var entity = mapper.Map<User>(dto);
        entity.Salt = Guid.NewGuid().ToString();
        entity.PasswordHash = passwordHasher.CreatePasswordHash(dto.Password, entity.Salt);
        entity.CreatedAt = DateTime.Now;
        entity = await userRepository.InsertAsync(entity);
        await unitOgWork.Save();
        return entity.Id;
    }

    public async ValueTask<int> Delete(int id)
    {
        var entity = await userRepository.SelectByIdAsync(id);
        entity.StateId = StateIdConst.DELETED;
        await unitOgWork.Save();
        return entity.Id;
    }

    public async ValueTask<UserDto> GetById(int id)
    {
        var entity = await userRepository.SelectByIdAsync(id);
        if(entity.OrganizationId == authService.User.OrganizationId)
            return mapper.Map<UserDto>(entity);
        else
            throw new Exception("User not found with given id");
    }

    public async ValueTask<List<UserDto>> GetList()
    {
        var entities = userRepository.SelectAll();
        if(authService.User.RoleId != RoleIdConst.SUPER_ADMIN)
            entities = entities.Where(u => u.OrganizationId == authService.User.OrganizationId);
        var result = entities.Select(e => mapper.Map<UserDto>(e));
        return await result.ToListAsync();
    }

    public async ValueTask<int> Update(UpdateUserDlDto dto)
    {
        var entity = await userRepository.SelectByIdAsync(dto.Id);
        entity = mapper.Map(dto, entity);
        await userRepository.UpdateAsync(entity);
        return entity.Id;
    }
}
