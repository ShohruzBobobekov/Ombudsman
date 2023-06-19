using AutoMapper;

using Ombudsman.Core.Models;

namespace Ombudsman.BizLogicLayer;

public class DocumentRealizationDtoConfig : Profile
{
    public DocumentRealizationDtoConfig()
    {
        CreateMap<CreateDocumentRealizationDto, DocumentRealization>()
            .ForMember(d=>d.SentDate,cfg=>cfg.MapFrom(e=>DateOnly.FromDateTime(e.SentDate)))
            .ForMember(d=>d.DocDate, cfg=>cfg.MapFrom(e=>DateOnly.FromDateTime(e.DocDate.Value)));
        CreateMap<CreateDocumentRealizationTableDto, DocumentRealizationTable>()
            .ForMember(d => d.DateEnteredForVisa, cfg => cfg.MapFrom(e => DateOnly.FromDateTime(e.DateEnteredForVisa)))
            .ForMember(d => d.DateOfVisaIssuance, cfg => cfg.MapFrom(e => DateOnly.FromDateTime(e.DateOfVisaIssuance)));
        CreateMap<CreateInformationLetterDto, InformationLetter>()
            .ForMember(d => d.DocDate, cfg => cfg.MapFrom(e => DateOnly.FromDateTime(e.DocDate.Value)));
        CreateMap<CreateInformationLetterTableDto, InformationLetterTable>()
            .ForMember(d => d.DateEnteredForVisa, cfg => cfg.MapFrom(e => DateOnly.FromDateTime(e.DateEnteredForVisa)))
            .ForMember(d => d.DateOfVisaIssuance, cfg => cfg.MapFrom(e => DateOnly.FromDateTime(e.DateOfVisaIssuance)));
        CreateMap<DocumentRealization, DocumentRealizationDto>();
        CreateMap<DocumentRealizationTable, DocumentRealizationTableDto>()
            .ReverseMap();
        CreateMap<InformationLetterDto,InformationLetter>()
            .ReverseMap();
        CreateMap<InformationLetterTableDto,InformationLetterTable>()
            .ReverseMap();
    }
}
