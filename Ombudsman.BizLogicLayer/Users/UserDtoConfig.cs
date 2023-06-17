using AutoMapper;

using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.BizLogicLayer.Users;
using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer;

public class UserDtoConfig : Profile
{
    private readonly IAuthService auth;
    public UserDtoConfig()
    {
        CreateMap<User, UserDto>()
            .ForMember(d => d.Role, cfg => cfg.MapFrom(u => u.Role.FullName))
            .ForMember(d => d.Organization, cfg => cfg.MapFrom(u => u.UserOrganization.FullName));
        CreateMap<UserDlDto, User>()
            .ForMember(u => u.UpdatedAt, cfg => cfg.MapFrom(d => DateTime.Now))
            .ForMember(u => u.UpdatedUserId, cfg => cfg.MapFrom(d => auth.User.Id));
        CreateMap<CreateUserDlDto, User>()
            .ForMember(u => u.CreatedAt, cfg => cfg.MapFrom(d => DateTime.Now))
            .ForMember(u => u.CreatedUserId, cfg => cfg.MapFrom(d => auth.User.Id));
    }
}
