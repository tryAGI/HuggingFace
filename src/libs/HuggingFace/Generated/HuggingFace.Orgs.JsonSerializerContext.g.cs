
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1, global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2>), TypeInfoPropertyName = "AnyOfPutOrganizationsSettingsSsoCredentialsRequestVariant1PutOrganizationsSettingsSsoCredentialsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, string>), TypeInfoPropertyName = "AnyOfBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?, string>), TypeInfoPropertyName = "AnyOfPatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource), TypeInfoPropertyName = "PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource?, string>), TypeInfoPropertyName = "AnyOfPatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource), TypeInfoPropertyName = "PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutOrganizationsMembersRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestRole), TypeInfoPropertyName = "PutOrganizationsMembersRoleRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroupRole), TypeInfoPropertyName = "PutOrganizationsMembersRoleRequestResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesType), TypeInfoPropertyName = "GetOrganizationsSettingsRepositoriesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesSort), TypeInfoPropertyName = "GetOrganizationsSettingsRepositoriesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection), TypeInfoPropertyName = "GetOrganizationsSettingsRepositoriesDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole), TypeInfoPropertyName = "GetOrganizationsSettingsTokensResponseItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus), TypeInfoPropertyName = "GetOrganizationsSettingsTokensResponseItemAuthorizationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationAuthorizer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrained))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType), TypeInfoPropertyName = "GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission), TypeInfoPropertyName = "GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType), TypeInfoPropertyName = "GetOrganizationsSettingsRepositoriesResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility), TypeInfoPropertyName = "GetOrganizationsSettingsRepositoriesResponseItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsAuditLogExportResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemType), TypeInfoPropertyName = "GetOrganizationsAuditLogExportResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthorType), TypeInfoPropertyName = "GetOrganizationsAuditLogExportResponseItemAuthorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemTokenRole), TypeInfoPropertyName = "GetOrganizationsAuditLogExportResponseItemTokenRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemOauth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>), TypeInfoPropertyName = "AnyOfGetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource), TypeInfoPropertyName = "GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>), TypeInfoPropertyName = "AnyOfGetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource), TypeInfoPropertyName = "GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>), TypeInfoPropertyName = "AnyOfPatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource), TypeInfoPropertyName = "PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>), TypeInfoPropertyName = "AnyOfPatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource), TypeInfoPropertyName = "PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAvatarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsMembersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsMembersResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsMembersResponseItemRole), TypeInfoPropertyName = "GetOrganizationsMembersResponseItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole), TypeInfoPropertyName = "GetOrganizationsMembersResponseItemResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeSpaces))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeEndpoints))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeJobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSocialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSocialsResponseSocialHandles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1, global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2>?), TypeInfoPropertyName = "NullableAnyOfPutOrganizationsSettingsSsoCredentialsRequestVariant1PutOrganizationsSettingsSsoCredentialsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, string>?), TypeInfoPropertyName = "NullableAnyOfBooleanString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?, string>?), TypeInfoPropertyName = "NullableAnyOfPatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?), TypeInfoPropertyName = "NullablePatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource?, string>?), TypeInfoPropertyName = "NullableAnyOfPatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource?), TypeInfoPropertyName = "NullablePatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestRole?), TypeInfoPropertyName = "NullablePutOrganizationsMembersRoleRequestRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroupRole?), TypeInfoPropertyName = "NullablePutOrganizationsMembersRoleRequestResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesType?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsRepositoriesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesSort?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsRepositoriesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsRepositoriesDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsTokensResponseItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsTokensResponseItemAuthorizationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsRepositoriesResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsRepositoriesResponseItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemType?), TypeInfoPropertyName = "NullableGetOrganizationsAuditLogExportResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthorType?), TypeInfoPropertyName = "NullableGetOrganizationsAuditLogExportResponseItemAuthorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemTokenRole?), TypeInfoPropertyName = "NullableGetOrganizationsAuditLogExportResponseItemTokenRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>?), TypeInfoPropertyName = "NullableAnyOfGetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>?), TypeInfoPropertyName = "NullableAnyOfGetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?), TypeInfoPropertyName = "NullableGetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>?), TypeInfoPropertyName = "NullableAnyOfPatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?), TypeInfoPropertyName = "NullablePatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>?), TypeInfoPropertyName = "NullableAnyOfPatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?), TypeInfoPropertyName = "NullablePatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsMembersResponseItemRole?), TypeInfoPropertyName = "NullableGetOrganizationsMembersResponseItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole?), TypeInfoPropertyName = "NullableGetOrganizationsMembersResponseItemResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsTokensResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsAuditLogExportResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsMembersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession>))]
    internal sealed partial class OrgsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrgsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrgsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1, global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, double?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, bool?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource?)

                    || typeToConvert == typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestRole)

                    || typeToConvert == typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestRole?)

                    || typeToConvert == typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroupRole)

                    || typeToConvert == typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroupRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesType)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesType?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesSort)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesSort?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthorType)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthorType?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemTokenRole)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemTokenRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsMembersResponseItemRole)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsMembersResponseItemRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource?))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestRole))
                {
                    return new global::HuggingFace.JsonConverters.PutOrganizationsMembersRoleRequestRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestRole?))
                {
                    return new global::HuggingFace.JsonConverters.PutOrganizationsMembersRoleRequestRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroupRole))
                {
                    return new global::HuggingFace.JsonConverters.PutOrganizationsMembersRoleRequestResourceGroupRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroupRole?))
                {
                    return new global::HuggingFace.JsonConverters.PutOrganizationsMembersRoleRequestResourceGroupRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesType))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesType?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesSort))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesSortJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesSort?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemAuthorizationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemAuthorizationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesResponseItemVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsRepositoriesResponseItemVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsAuditLogExportResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsAuditLogExportResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthorType))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsAuditLogExportResponseItemAuthorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthorType?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsAuditLogExportResponseItemAuthorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemTokenRole))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsAuditLogExportResponseItemTokenRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsAuditLogExportResponseItemTokenRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsAuditLogExportResponseItemTokenRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsMembersResponseItemRole))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsMembersResponseItemRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsMembersResponseItemRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsMembersResponseItemRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsMembersResponseItemResourceGroupRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsMembersResponseItemResourceGroupRoleNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new OrgsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}