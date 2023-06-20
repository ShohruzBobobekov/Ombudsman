using AutoMapper;

using Ombudsman.BizLogicLayer.Auth;
using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer.Manual;

public class ManualServiceConfig : Profile
{
    private readonly IAuthService authService;

/*    public ManualServiceConfig()
    {
    }*/
    public ManualServiceConfig(IAuthService authService)
    {
       this.authService = authService;

        CreateMap<DocumentImportance, DocumentImportanceDto>();
        //.ForMember(dto => dto.FullName, cfg => cfg
        //    .MapFrom(entity => entity.Translates.FirstOrDefault(translate =>
        //        translate.OwnerId == entity.Id &&
        //        translate.LanguageId == authService.User.LanguageId &&
        //        translate.ColumnName == nameof(entity.FullName))));

        CreateMap<DocumentRealizerType, DocumentRealizerTypeDto>();
        //.ForMember(dto => dto.FullName, cfg => cfg
        //    .MapFrom(entity => entity.Translates.FirstOrDefault(translate =>
        //        translate.OwnerId == entity.Id &&
        //        translate.LanguageId == authService.User.LanguageId &&
        //        translate.ColumnName == nameof(entity.FullName))));


        CreateMap<DocumentState, DocumentStateDto>();
           //.ForMember(dto => dto.FullName, cfg => cfg
           //    .MapFrom(entity => entity.Translates.FirstOrDefault(translate =>
           //        translate.OwnerId == entity.Id &&
           //        translate.LanguageId == authService.User.LanguageId &&
           //        translate.ColumnName == nameof(entity.FullName))));


        CreateMap<DocumentType, DocumentTypeDto>();
           //.ForMember(dto => dto.FullName, cfg => cfg
           //    .MapFrom(entity => entity.Translates.FirstOrDefault(translate =>
           //        translate.OwnerId == entity.Id &&
           //        translate.LanguageId == authService.User.LanguageId &&
           //        translate.ColumnName == nameof(entity.FullName))));

        CreateMap<GovernmentOrganizationType, GovernmentOrganizationTypeDto>();
           //.ForMember(dto => dto.FullName, cfg => cfg
           //    .MapFrom(entity => entity.Translates.FirstOrDefault(translate =>
           //        translate.OwnerId == entity.Id &&
           //        translate.LanguageId == authService.User.LanguageId &&
           //        translate.ColumnName == nameof(entity.FullName))));


        CreateMap<State, StateDto>();
           //.ForMember(dto => dto.FullName, cfg => cfg
           //    .MapFrom(entity => entity.Translates.FirstOrDefault(translate =>
           //        translate.OwnerId == entity.Id &&
           //        translate.LanguageId == authService.User.LanguageId &&
           //        translate.ColumnName == nameof(entity.FullName))));

        CreateMap<UserRole, UserRoleDto>();
        CreateMap<Language, LanguageDto>();
        CreateMap<InitiativeType, InitiativeTypeDto>();
    }

}
