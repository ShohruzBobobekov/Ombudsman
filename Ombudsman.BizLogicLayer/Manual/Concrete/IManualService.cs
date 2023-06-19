using Ombudsman.BizLogicLayer.Manual;

namespace Ombudsman.BizLogicLayer;

public interface IManualService
{
    ValueTask<IQueryable<DocumentImportanceDto>> GetDocumentImportanceList();
    ValueTask<IQueryable<DocumentRealizerTypeDto>> GetDocumentRealizerTypeList();
    ValueTask<IQueryable<DocumentStateDto>> GetDocumentStateList();
    ValueTask<IQueryable<DocumentTypeDto>> GetDocumentTypeList();
    ValueTask<IQueryable<GovernmentOrganizationTypeDto>> GetGovernmentOrganizationTypeList();
    ValueTask<IQueryable<LanguageDto>> GetLanguageList();
    ValueTask<IQueryable<StateDto>> GetStateList();
    ValueTask<IQueryable<UserRoleDto>> GetUserRoleList();
    ValueTask<IQueryable<InitiativeTypeDto>> GetInitiativeTypeList();
}
