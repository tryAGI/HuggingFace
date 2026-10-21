
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.RepoId? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.RepoIdType? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.Job? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobOwner? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobArch? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobFlavor? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobStatus? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobStatusStage? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.JobStatusCancelReason?, string>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobStatusCancelReason? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobCreatedBy? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobDurations? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.JobVolume>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobVolume? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobExpose? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobNetwork? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteNotificationsRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateNotificationsMarkAsReadRequest? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCredentialsRevokeRequest? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsNotificationsRequest? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsNotificationsRequestNotifications? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequest? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestDeleteItem>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequestDeleteItem? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequestDeleteItemType? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestAddItem>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequestAddItem? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequestAddItemType? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Expose? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Ssh? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Network? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Expose? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Ssh? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Network? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestDomain? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequest2? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType2? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType2? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Expose2? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Ssh2? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Network2? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor2? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch2? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume2>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume2? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType2? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Expose2? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Ssh2? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Network2? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain2>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestDomain2? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsPapersClaimRequest? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::HuggingFace.CreateSettingsInferenceProvidersRequest2>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsInferenceProvidersRequest2? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequest? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequestProvider? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSettingsInferenceProvidersDefaultBillingEntityRequest? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSettingsInferenceProvidersUsageLimitsRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1, global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsRequest? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsRequestSpendLimits? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequest? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, string>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant2? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequest? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant2? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteRequest? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteRequestRole? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestVariant1, global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestVariant2>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestVariant1? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestVariant1Role? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestVariant2? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsRequestUser>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestUser? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestUserRole? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.RepoId>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant1? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Scope? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant2? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequest2? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequest? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContent>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContent? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?, string>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContent>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContent? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource?, string>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsRequest? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequest? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequest? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersRoleRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersRoleRequestRole? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroup>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroup? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroupRole? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersAccountTypeRequest? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersAccountTypeRequestAccountType? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersRequest? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2UsersRequestEmail>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersRequestEmail? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersRequestName? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersRequest? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperation>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperation? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperationPath? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2UsersRequestEmail>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersRequestEmail? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersRequestName? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsRequest? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2GroupsRequestMember>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsRequestMember? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsRequest? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2GroupsRequestMember>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsRequestMember? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsRequest? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsRequestOperationVariant1? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2GroupsRequestOperationVariant1ValueItem>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsRequestOperationVariant1ValueItem? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsRequestOperationVariant2? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequest? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequestEmail>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequestEmail? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequest? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperation>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperation? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperationPath? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersRequest? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsRequest? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsRequestMember>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsRequestMember? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequest? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequestMember>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequestMember? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequest? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant1? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant1ValueItem>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant1ValueItem? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant2? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterRequestTokenEndpointAuthMethod? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthDeviceRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentRequest? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyRequest? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequest? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequestReaction? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequestAction? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentHideRequest? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentHideRequestReason? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentEditRequest? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentRequest2? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyRequest2? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequest2? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequestReaction2? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequestAction2? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentHideRequest2? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentHideRequestReason2? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentEditRequest2? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogResourceGroupRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesBatchRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesBatchRequestDeletions? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesBatchRequest? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesBatchRequestDeletions? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesBatchRequest? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesBatchRequestDeletions? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateRequest? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTarget? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTargetType? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateRequestFile>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateRequestFile? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateRequest? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTarget? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTargetType? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequest? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequestTarget? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequestTargetType? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequestFile>? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequestFile? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateRequest? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTarget? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTargetType? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestFile>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestFile? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateRequest? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTarget? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTargetType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestFile>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestFile? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<string, bool?>? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoRequest? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoRequest? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadRequest? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPreuploadRequestFile>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadRequestFile? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadRequest? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPreuploadRequestFile>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadRequestFile? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPreuploadRequestFile>? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadRequestFile? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsTagRequest? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesTagRequest? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsTagRequest? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsBranchRequest? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesBranchRequest? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsBranchRequest? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsResourceGroupRequest? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesResourceGroupRequest? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsResourceGroupRequest? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResourceGroupRequest? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsSuperSquashRequest? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsSuperSquashRequest? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesSuperSquashRequest? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestVisibility? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestDiscussionsSorting? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutModelsSettingsRequestGated?>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestGated? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutModelsSettingsRequestGatedProfileSharingVariant1, global::HuggingFace.PutModelsSettingsRequestGatedProfileSharingVariant2>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestGatedProfileSharingVariant1? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestGatedProfileSharingVariant2? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestGatedNotificationsMode? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequest? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestVisibility? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsRequestGated?>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestGated? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant1, global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant2>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant1? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant2? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequest? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestVisibility? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestDiscussionsSorting? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutDatasetsSettingsRequestGated?>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestGated? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutDatasetsSettingsRequestGatedProfileSharingVariant1, global::HuggingFace.PutDatasetsSettingsRequestGatedProfileSharingVariant2>? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestGatedProfileSharingVariant1? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestGatedProfileSharingVariant2? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestGatedNotificationsMode? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsRequest? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusRequest? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusRequestStatus? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsPinRequest? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsMergeRequest? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsIgnoreRequest? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsIgnoreRequestAction? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentEditRequest? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentHideRequest? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentHideRequestReason? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentReactionRequest? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentReactionRequestReaction? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentReactionRequestAction? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsAccessRequestApproveRequest? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequest? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLang?, string>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestLang? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLibrary?, string>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestLibrary? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestRepoType?, string>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestRepoType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesSecretsRequest? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSpacesSecretsRequest? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesVariablesRequest? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSpacesVariablesRequest? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequest? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestVisibility? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestHardware? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<int?, double?>? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestSecret>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestSecret? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestVariable>? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestVariable? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestVolume>? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestVolume? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestVolumeType? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1Region? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1License? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1Visibility? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant1File>? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1File? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1FileEncoding? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2Region? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2License? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2Visibility? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant2File>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2File? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2FileEncoding? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3Region? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3License? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3Visibility? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant3File>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3File? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3FileEncoding? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Region? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4License? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Visibility? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4File>? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4File? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4FileEncoding? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Hardware? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Secret>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Secret? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Variable>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Variable? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Volume>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Volume? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4VolumeType? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Sdk? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposMoveRequest? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposMoveRequestType? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSqlConsoleEmbedRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedRequest? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSqlConsoleEmbedRequestView>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedRequestView? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant1? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant1Status? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant2? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant2Status? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant3? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestHandleRequestVariant3Status? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant1? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant1Status? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant2? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant2Status? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant3? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestVariant3Status? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchRequest? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequestVariant1? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequestVariant2? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequestVariant3? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequest? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequestStatus? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequestRequestVariant1? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequestRequestVariant2? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequestRequestVariant3? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestGrantRequest? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestGrantRequest? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesVolumesRequest? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutSpacesVolumesRequestVolume>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesVolumesRequestVolume? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesVolumesRequestVolumeType? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesHardwareRequest? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesHardwareRequestFlavor? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesSleeptimeRequest? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesDevModeRequest? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesCustomDomainRequest? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersIndexRequest? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentRequest? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyRequest? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentEditRequest? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentHideRequest? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentHideRequestReason? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReactionRequest? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReactionRequestReaction? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReactionRequestAction? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersLinksRequest? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentRequest? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyRequest? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReactionRequest? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReactionRequestReaction? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReactionRequestAction? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentHideRequest? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentHideRequestReason? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentEditRequest? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequest? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestTheme? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsRequestGatingVariant2, global::HuggingFace.PatchCollectionsRequestGatingVariant3>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant2? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant1? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant2? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3Notifications? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3NotificationsMode? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3ProfileSharingVariant1? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3ProfileSharingVariant2? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequest2? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestTheme2? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsRequestGatingVariant22, global::HuggingFace.PatchCollectionsRequestGatingVariant32>? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant22? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant12? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant22? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant32? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3Notifications2? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3NotificationsMode2? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3ProfileSharingVariant12? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3ProfileSharingVariant22? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequest? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequestItem? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequestItemType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequest2? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequestItem2? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequestItemType2? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsBatchRequestItem>? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItem? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItemAction? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItemData? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsBatchRequestItem2>? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItem2? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItemAction2? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItemData2? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsItemsRequest? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsItemsRequest2? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsRequest? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsRequestItem? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsRequestItemType? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResourceGroupRequest? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResourceGroupRequest2? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequest? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestVisibility? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsRequestCdnItem>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestCdnItem? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestCdnItemProvider? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestCdnItemRegion? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestRegion? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequest? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestVisibility? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersRequestCdnItem>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestCdnItem? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestCdnItemProvider? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestCdnItemRegion? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestRegion? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsRequest? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutBucketsSettingsRequestCdnRegion>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsRequestCdnRegion? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsRequestCdnRegionProvider? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsRequestCdnRegionRegion? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsRequest? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsRequestCdnRegion>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsRequestCdnRegion? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsRequestCdnRegionProvider? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsRequestCdnRegionRegion? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsPathsInfoRequest? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersPathsInfoRequest? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateJobsRequestVariant1, global::HuggingFace.CreateJobsRequestVariant2>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Flavor? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Arch? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsRequestVariant1Volume>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Volume? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1VolumeType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Expose? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Ssh? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Network? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Flavor? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Arch? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsRequestVariant2Volume>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Volume? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2VolumeType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Expose? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Ssh? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Network? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsRequest? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeRequest? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequest? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1, global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Flavor? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Arch? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Volume>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Volume? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1VolumeType? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Expose? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Ssh? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Network? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Flavor? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Arch? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Volume>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Volume? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2VolumeType? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Expose? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Ssh? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Network? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleRequest? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsRequest? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreatePartnersModelsRequestVariant1, global::HuggingFace.CreatePartnersModelsRequestVariant2>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant1? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant1Status? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant1Task? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant2? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant2Status? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant2Task? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutPartnersModelsStatusRequest? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutPartnersModelsStatusRequestStatus? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsReadStatus? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsRepoType? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsMention? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteNotificationsReadStatus? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteNotificationsRepoType? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteNotificationsMention? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateNotificationsMarkAsReadReadStatus? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateNotificationsMarkAsReadRepoType? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateNotificationsMarkAsReadMention? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksAction? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesType? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesSort? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesDirection? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesType? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesSort? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBlogZhCommunitySort? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchProduct? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowersExpandItem>? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersExpandItem? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckPerms? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckPerms2? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckPerms? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckPerms2? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsLikersExpandItem>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLikersExpandItem? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLikersExpandItem>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLikersExpandItem? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesLikersExpandItem>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLikersExpandItem? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsLikersExpandItem>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsLikersExpandItem? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesDirection? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesSort? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesDirection? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesSort? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesDirection? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesSort? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsCommitsExpandItem>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsCommitsExpandItem? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesCommitsExpandItem>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesCommitsExpandItem? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsExpandItem>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsCommitsExpandItem? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsCommitContentType? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsCommitContentType? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesCommitContentType? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsRepoType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsType? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsStatus? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsSort? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsRepoType? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsRepoType2? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteDiscussionsRepoType? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentRepoType? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusRepoType? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleRepoType? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsPinRepoType? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsMergeRepoType? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteDiscussionsRefRepoType? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsStorageRepoType? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsIgnoreRepoType? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentEditRepoType? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentHideRepoType? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentReactionRepoType? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsSort? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsDirection? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsExpand2? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsExpandItem? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTagsByTypeType? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTagsByTypeType? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingType? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLang2?, string>? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchLang2? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLibrary2?, string>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchLibrary2? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchTypeVariant1Item? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchReposFilterVariant1Item? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchPipelinesVariant1Item? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchRepoType2?, string>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchRepoType2? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLang2?, string>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchLang2? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLibrary2?, string>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchLibrary2? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchTypeVariant1Item? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchReposFilterVariant1Item? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchPipelinesVariant1Item? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRepoType2?, string>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRepoType2? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>>? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSearchFullTextType2? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSearchFullTextTypeItem? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRepoType? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDuplicateStatusRepoType? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSqlConsoleEmbedRepoType? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSqlConsoleEmbedRepoType? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedHideRepoType? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedRepoType? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestStatus? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestStatus? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLogsLogType? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesSemanticSearchCategory? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesSemanticSearchSdkItem>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesSemanticSearchSdkItem? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersSort? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetPapersField2?, global::System.Collections.Generic.IList<global::HuggingFace.GetPapersFieldItem>>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersField2? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersFieldItem>? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersFieldItem? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsSort? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsTreeSort? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsTreeDirection? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersTreeSort? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersTreeDirection? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsStage2? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsStageItem? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsCountStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsCountStageItem>>? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsCountStage2? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsCountStageItem>? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsCountStageItem? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPartnersModelsProvider? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPartnersModelsStatus? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsProvider? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutPartnersModelsStatusProvider? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponse? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant1? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant1Paper? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussion? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussionParticipatingItem>? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussionParticipatingItem? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant2? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant2Discussion? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionStatus? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionParticipatingItem>? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionParticipatingItem? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant3? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant3Post? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant3PostParticipatingItem>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant3PostParticipatingItem? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant4? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant4Blog? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant4BlogParticipatingItem>? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant4BlogParticipatingItem? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseCount? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsMcpResponse? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsMcpResponseSpaceTool>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsMcpResponseSpaceTool? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseItem>? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItem? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2>? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1Flavor? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2Flavor? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItem>? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItem? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItemType? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseItemDomain>? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemDomain? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponse? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhook? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain>? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponse? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhook? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2>? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1Flavor? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2Flavor? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItem>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItem? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItemType? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponse2? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhook2? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant12, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant22>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant12? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant22? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem2>? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem2? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType2? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSettingsWebhooksResponse? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponse3? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhook3? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant13, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant23>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant13? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant23? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem3>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem3? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType3? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3>? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksReplayResponse? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsPapersClaimResponse? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsRepositoriesResponseItem>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesResponseItem? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesResponseItemType? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesResponseItemVisibility? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItem>? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItem? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemOwner? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorization? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationAuthorizer? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrained? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem>? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission>? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem>? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsAuditLogExportResponseItem>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItem? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemType? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemLocation? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthor? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthorType? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemToken? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemTokenRole? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemOauth? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponse? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant2? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseSpendLimits? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsResourceGroupsResponseUser>? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseUser? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseUserRole? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseUserOrgRole? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant1? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant1Type? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant2? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant3? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant4? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant5? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsResponse? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponse? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseAutoJoinVariant1? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseAutoJoinVariant2? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseSpendLimits? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsResourceGroupsResponseUser>? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseUser? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseUserRole? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseUserOrgRole? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant1? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant1Type? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant2? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant3? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant4? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant5? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponse? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant2? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseSpendLimits? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUser>? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUser? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUserRole? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant2? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant3? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant4? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponse? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant2? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseSpendLimits? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUser>? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUser? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUserRole? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUserOrgRole? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant1? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant2? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant3? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant4? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant5? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponse? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseRole? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseAuthor? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseAuthorOrg>? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseAuthorOrg? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseAuthorServiceAccount? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseInvitee? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseInviteeOrg>? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseInviteeOrg? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseInviteeServiceAccount? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseResourceGroup? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseResourceGroupRole? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItem>? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItem? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemRole? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemAuthor? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemAuthorOrg>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemAuthorOrg? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemAuthorServiceAccount? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemInvitee? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemInviteeOrg>? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemInviteeOrg? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemInviteeServiceAccount? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroup? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroupRole? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponse? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseRole? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseAuthor? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseAuthorOrg>? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseAuthorOrg? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseAuthorServiceAccount? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseInvitee? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseInviteeOrg>? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseInviteeOrg? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseInviteeServiceAccount? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroup? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponse? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant2? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseSpendLimits? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUser>? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUser? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUserRole? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant2? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant3? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant4? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant5? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant2? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseSpendLimits? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUser>? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUser? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUserRole? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUserOrgRole? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant1? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant2? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant3? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant4? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant5? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsResourceGroupsResponseItem>? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItem? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant2? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemSpendLimits? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUser>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUser? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserRole? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserOrgRole? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant1? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant1Type? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant2? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant3? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant4? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant5? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant2? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseSpendLimits? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsResponseUser>? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseUser? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseUserRole? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseUserOrgRole? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant1? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant1Type? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant2? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant3? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant4? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant5? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsSettingsResponse? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponse2? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponse? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContent>? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContent? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContent>? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContent? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponse? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent>? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent>? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseItem>? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseItem? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsResponse? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponse? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessToken>? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessToken? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission>? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission>? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensResponse? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensResponseTokenInfo? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsServiceAccountsTokensResponse? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponse? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponseTokenInfo? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAvatarResponse? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsMembersResponseItem>? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsMembersResponseItem? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsMembersResponseItemRole? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroup>? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroup? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponse? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponsePatch? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseBulk? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseFilter? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseChangePassword? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseSort? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseEtag? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme>? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseMeta? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItem>? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItem? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItemMeta? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2SchemasResponseItem>? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2SchemasResponseItem? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2SchemasResponseItemMeta? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2SchemasResponse? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2SchemasResponseMeta? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponse? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema>? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseResource>? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResource? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceSchema>? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceSchema? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceName? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceEmail>? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceEmail? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceEmailType? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceMeta? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceMetaResourceType? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponse? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2UsersResponseSchema>? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseSchema? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseName? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2UsersResponseEmail>? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseEmail? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseEmailType? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseMeta? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseMetaResourceType? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponse2? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema2>? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema2? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseName? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseEmail>? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseEmail? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseEmailType? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseMeta? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseMetaResourceType? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponse? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2UsersResponseSchema>? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseSchema? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseName? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2UsersResponseEmail>? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseEmail? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseEmailType? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseMeta? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseMetaResourceType? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponse? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2UsersResponseSchema>? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseSchema? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseName? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2UsersResponseEmail>? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseEmail? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseEmailType? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseMeta? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseMetaResourceType? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponse? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema>? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResource>? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResource? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceSchema>? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceSchema? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMember>? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMember? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMeta? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMetaResourceType? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponse? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2GroupsResponseSchema>? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponseSchema? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMember>? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMember? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMeta? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMetaResourceType? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponse2? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema2>? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema2? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseMember>? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseMember? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseMeta? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseMetaResourceType? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponse? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2GroupsResponseSchema>? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponseSchema? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2GroupsResponseMember>? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponseMember? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponseMeta? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponseMetaResourceType? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponse? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2GroupsResponseSchema>? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponseSchema? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMember>? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMember? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMeta? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMetaResourceType? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponse? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema>? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResource>? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResource? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceSchema>? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceSchema? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceName? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceEmail>? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceEmail? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceEmailType? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceMeta? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceMetaResourceType? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponse? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseSchema>? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseSchema? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseName? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseEmail>? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseEmail? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseEmailType? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseMeta? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseMetaResourceType? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponse2? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema2>? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema2? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseName? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseEmail>? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseEmail? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseEmailType? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseMeta? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseMetaResourceType? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponse? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseSchema>? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseSchema? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseName? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseEmail>? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseEmail? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseEmailType? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseMeta? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseMetaResourceType? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponse? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseSchema>? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseSchema? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseName? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmail>? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmail? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmailType? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseMeta? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseMetaResourceType? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponse? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema>? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResource>? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResource? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceSchema>? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceSchema? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMember>? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMember? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMeta? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceType? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponse? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseSchema>? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseSchema? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMember>? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMember? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMeta? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponse2? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema2>? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema2? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMember>? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMember? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMeta? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponse? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseSchema>? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseSchema? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMember>? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMember? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMeta? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponse? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseSchema>? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseSchema? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMember>? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMember? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMeta? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterResponse? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthRegisterResponseGrantType>? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterResponseGrantType? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterResponseTokenEndpointAuthMethod? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthDeviceResponse? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponse? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseHardwareItem>? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseHardwareItem? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseBillingMode? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrg>? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrg? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgPlan? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction>? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup>? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroupRole? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponse? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseHardwareItem>? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseHardwareItem? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseBillingMode? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrg>? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrg? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgPlan? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgBillingMode? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgRoleInOrg? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction>? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroup>? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroup? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroupRole? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetRegistryTokenResponse? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponse? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessage? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1, global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2>? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1OauthApp? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1OauthAppImageData? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1Plan? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2OauthApp? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2OauthAppImageData? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrg? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageData? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataHiddenReason? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatest? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction>? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataReactionReaction? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataIdentifiedLanguage? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponse? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessage? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1OauthApp? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1OauthAppImageData? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2OauthApp? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2OauthAppImageData? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrg? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageData? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataHiddenReason? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatest? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction>? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReactionReaction? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataIdentifiedLanguage? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponse2? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessage2? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant12, global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant22>? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant12? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1OauthApp2? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1OauthAppImageData2? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1Plan2? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant22? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2OauthApp2? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2OauthAppImageData2? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrg2? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageData2? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataHiddenReason2? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatest2? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant12? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant22? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg2? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction2>? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction2? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataReactionReaction2? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataIdentifiedLanguage2? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponse2? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessage2? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant12? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1OauthApp2? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1OauthAppImageData2? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan2? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant22? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2OauthApp2? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2OauthAppImageData2? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrg2? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageData2? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataHiddenReason2? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatest2? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant12? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant22? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrg2? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction2>? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction2? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReactionReaction2? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataIdentifiedLanguage2? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBlogResourceGroupResponse? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogResourceGroupResponse? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDocsResponseItem>? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsResponseItem? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDocsSearchResponseItem>? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchResponseItem? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchResponseItemVectors? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchFullTextResponse? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDocsSearchFullTextResponseHit>? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchFullTextResponseHit? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchFullTextResponseHitFormatted? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2Response2? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuth? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessToken? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenRole? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrained? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem>? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntity? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem>? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthResource? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseBillingMode? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrg>? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrg? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgPlan? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction>? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup>? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroupRole? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponse? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod>? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup>? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeSpaces? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeEndpoints? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeJobs? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponse? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriod>? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriod? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession>? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageInferenceResponseItem>? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageInferenceResponseItem? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageInferenceResponseItemUsageItem>? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageInferenceResponseItemUsageItem? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponse? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriod>? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriod? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriodSession>? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriodSession? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageJobsResponse? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageJobsResponseUsage? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageJobsResponseUsageJobDetail>? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageJobsResponseUsageJobDetail? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersOverviewResponse? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersOverviewResponseOrg>? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersOverviewResponseOrg? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersOverviewResponseServiceAccount? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersOverviewResponseHardwareItem>? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersOverviewResponseHardwareItem? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersSocialsResponse? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersSocialsResponseSocialHandles? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersAvatarResponse? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersLikesResponseItem>? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersLikesResponseItem? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersLikesResponseItemRepo? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersLikesResponseItemRepoType? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>>? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersResponseItemVariant1? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowersResponseItemVariant1Org>? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersResponseItemVariant1Org? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersResponseItemVariant1ServiceAccount? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersResponseItemVariant2? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingResponseItem>? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingResponseItem? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingResponseItemOrg>? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingResponseItemOrg? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingResponseItemServiceAccount? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItem>? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingOrgsResponseItem? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain>? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSocialsResponse? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSocialsResponseSocialHandles? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse2? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace2? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser2? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse3? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace3? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser3? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse4? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace4? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser4? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponse? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponseNamespace? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponseUser? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponse2? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponseNamespace2? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponseUser2? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreesizeResponse? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreesizeResponse? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreesizeResponse? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsSafetensorsMetadataResponse? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsSafetensorsMetadataResponseIndex? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetModelsSafetensorsMetadataResponseHeadersVariant1, global::System.Collections.Generic.Dictionary<string, string>>? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsSafetensorsMetadataResponseHeadersVariant1? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsLfsFilesResponseItem>? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItem? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItemPusher? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrg? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItem? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItemPusher? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItemPusherPrimaryOrg? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesLfsFilesResponseItem>? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItem? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItemPusher? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrg? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateResponse? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem>? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateResponse2? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem2>? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem2? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateResponse? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem>? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateResponse2? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem2>? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem2? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponse? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem>? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponse2? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem2>? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem2? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateResponse? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem>? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateResponse2? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem2>? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem2? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateResponse? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem>? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateResponse2? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem2>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem2? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsCommitsResponseItem>? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsCommitsResponseItem? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsCommitsResponseItemAuthor>? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsCommitsResponseItemAuthor? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsCommitsResponseItemFormatted? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesCommitsResponseItem>? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesCommitsResponseItem? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesCommitsResponseItemAuthor>? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesCommitsResponseItemAuthor? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesCommitsResponseItemFormatted? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsResponseItem>? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsCommitsResponseItem? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsResponseItemAuthor>? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsCommitsResponseItemAuthor? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsCommitsResponseItemFormatted? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponse? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseTag>? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponseTag? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseBranche>? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponseBranche? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseConvert>? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponseConvert? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponsePullRequest>? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponsePullRequest? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponse? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsRefsResponseTag>? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponseTag? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsRefsResponseBranche>? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponseBranche? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsRefsResponseConvert>? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponseConvert? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsRefsResponsePullRequest>? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponsePullRequest? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponse? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponseTag>? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponseTag? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponseBranche>? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponseBranche? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponseConvert>? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponseConvert? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponsePullRequest>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponsePullRequest? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItem>? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItem? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemType? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemLfs? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemLastCommit? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatus? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusStatus? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScan? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScan? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScan? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScan? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScan? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItem>? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItem? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemType? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemLfs? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemLastCommit? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatus? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScan? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScan? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScan? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScan? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScan? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItem>? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItem? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemType? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemLfs? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemLastCommit? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatus? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScan? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScan? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScan? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImport? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScan? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScan? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadResponse? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPreuploadResponseFile>? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadResponseFile? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadResponse? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPreuploadResponseFile>? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadResponseFile? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadResponseFileUploadMode? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadResponse? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPreuploadResponseFile>? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadResponseFile? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadResponseFileUploadMode? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsXetWriteTokenResponse? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesXetWriteTokenResponse? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsXetWriteTokenResponse? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsXetWriteTokenResponse? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersXetWriteTokenResponse? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsXetReadTokenResponse? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesXetReadTokenResponse? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsXetReadTokenResponse? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsXetReadTokenResponse? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersXetReadTokenResponse? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsCommitResponse? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsCommitResponse? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesCommitResponse? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsResourceGroupResponse? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsResourceGroupResponseType? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsResourceGroupResponse? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesResourceGroupResponse? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesResourceGroupResponseType? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesResourceGroupResponse? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsResourceGroupResponse? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsResourceGroupResponseType? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsResourceGroupResponse? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResourceGroupResponse? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResourceGroupResponseType? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResourceGroupResponse? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsSuperSquashResponse? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsSuperSquashResponse? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesSuperSquashResponse? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponse? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseVisibility? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutModelsSettingsResponseGated?>? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseGated? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutModelsSettingsResponseGatedProfileSharingVariant1, global::HuggingFace.PutModelsSettingsResponseGatedProfileSharingVariant2>? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseGatedProfileSharingVariant1? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseGatedProfileSharingVariant2? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseGatedNotificationsMode? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponse? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseVisibility? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseDiscussionsSorting? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsResponseGated?>? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseGated? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutSpacesSettingsResponseGatedProfileSharingVariant1, global::HuggingFace.PutSpacesSettingsResponseGatedProfileSharingVariant2>? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseGatedProfileSharingVariant1? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseGatedProfileSharingVariant2? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseGatedNotificationsMode? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponse? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseVisibility? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseDiscussionsSorting? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutDatasetsSettingsResponseGated?>? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseGated? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseGatedProfileSharingVariant1? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseGatedProfileSharingVariant2? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseGatedNotificationsMode? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItem>? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItem? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemType? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemLfs? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemLastCommit? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatus? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScan? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImport? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScan? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScan? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanStatus? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImport>? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImport? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScan? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScan? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItem>? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItem? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemType? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemLfs? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemLastCommit? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatus? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusStatus? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScan? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImport? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScan? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScan? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport>? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScan? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScan? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItem>? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItem? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemType? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemLfs? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemLastCommit? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatus? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusStatus? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScan? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImport? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScan? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScan? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImport>? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImport? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScan? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScan? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetModelsNotebookResponseVariant1, global::HuggingFace.GetModelsNotebookResponseVariant2, global::HuggingFace.GetModelsNotebookResponseVariant3>? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsNotebookResponseVariant1? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsNotebookResponseVariant2? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsNotebookResponseVariant3? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetDatasetsNotebookResponseVariant1, global::HuggingFace.GetDatasetsNotebookResponseVariant2, global::HuggingFace.GetDatasetsNotebookResponseVariant3>? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsNotebookResponseVariant1? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsNotebookResponseVariant2? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsNotebookResponseVariant3? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetSpacesNotebookResponseVariant1, global::HuggingFace.GetSpacesNotebookResponseVariant2, global::HuggingFace.GetSpacesNotebookResponseVariant3>? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesNotebookResponseVariant1? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesNotebookResponseVariant2? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesNotebookResponseVariant3? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsScanResponse? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsScanResponseFilesWithIssue>? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsScanResponseFilesWithIssue? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsScanResponseFilesWithIssueLevel? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsScanResponse? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsScanResponseFilesWithIssue>? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsScanResponseFilesWithIssue? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsScanResponseFilesWithIssueLevel? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesScanResponse? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesScanResponseFilesWithIssue>? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesScanResponseFilesWithIssue? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsScanResponse? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsScanResponseFilesWithIssue>? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsScanResponseFilesWithIssue? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsScanResponseFilesWithIssueLevel? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponse? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseDiscussion>? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussion? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant1, global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2>? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant1? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant1Plan? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrg? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseDiscussionTopReaction>? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionTopReaction? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionTopReactionReaction? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionStatus? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionRepoOwner? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionRepoOwnerType? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsResponse? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsResponseReferences? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant1, global::HuggingFace.GetDiscussionsResponseVariant2>? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2>? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant1? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant1Plan? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrg? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgUserRole? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1Org? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1OrgPlan? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1Status? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant1? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant1OauthApp? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant1OauthAppImageData? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant1Plan? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2OauthApp? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2OauthAppImageData? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrg? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgPlan? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1Data? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataHiddenReason? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatest? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant1? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant1Plan? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant2? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrg? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataReaction>? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataReaction? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataReactionReaction? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataIdentifiedLanguage? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthApp? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthAppImageData? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1Plan? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2OauthApp? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2OauthAppImageData? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2PrimaryOrg? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2PrimaryOrgPlan? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2PrimaryOrgUserRole? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2Data? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2DataStatus? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant1? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant1OauthApp? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant1OauthAppImageData? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant1Plan? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2OauthApp? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2OauthAppImageData? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2PrimaryOrg? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2PrimaryOrgPlan? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2PrimaryOrgUserRole? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3Data? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant1? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant1OauthApp? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant1OauthAppImageData? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant1Plan? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2OauthApp? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2OauthAppImageData? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2PrimaryOrg? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2PrimaryOrgPlan? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2PrimaryOrgUserRole? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4Data? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant1? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant1OauthApp? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant1OauthAppImageData? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant1Plan? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2OauthApp? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2OauthAppImageData? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2PrimaryOrg? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2PrimaryOrgPlan? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2PrimaryOrgUserRole? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5Data? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant1? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant1OauthApp? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant1OauthAppImageData? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant1Plan? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2OauthApp? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2OauthAppImageData? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2PrimaryOrg? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2PrimaryOrgPlan? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2PrimaryOrgUserRole? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6Data? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant1? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant1OauthApp? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant1OauthAppImageData? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant1Plan? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2OauthApp? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2OauthAppImageData? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2PrimaryOrg? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2PrimaryOrgPlan? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2PrimaryOrgUserRole? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7Data? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant1? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant1OauthApp? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant1OauthAppImageData? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant1Plan? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2OauthApp? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2OauthAppImageData? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2PrimaryOrg? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2PrimaryOrgPlan? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2PrimaryOrgUserRole? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8Data? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant1? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant1OauthApp? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant1OauthAppImageData? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant1Plan? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2OauthApp? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2OauthAppImageData? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2PrimaryOrg? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2PrimaryOrgPlan? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2PrimaryOrgUserRole? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9Data? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1Collection? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2>? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant1? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant1Plan? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2PrimaryOrg? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2PrimaryOrgPlan? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2PrimaryOrgUserRole? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2Org? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2OrgPlan? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2Status? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant1? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant1OauthApp? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant1OauthAppImageData? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant1Plan? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2OauthApp? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2OauthAppImageData? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2PrimaryOrg? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2PrimaryOrgPlan? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2PrimaryOrgUserRole? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1Data? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataHiddenReason? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatest? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant1? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant1Plan? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrg? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReaction>? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReaction? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReactionReaction? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataIdentifiedLanguage? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant1? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant1OauthApp? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant1OauthAppImageData? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant1Plan? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2OauthApp? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2OauthAppImageData? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2PrimaryOrg? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2PrimaryOrgPlan? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2PrimaryOrgUserRole? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2Data? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2DataStatus? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant1? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant1OauthApp? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant1OauthAppImageData? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant1Plan? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2OauthApp? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2OauthAppImageData? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrg? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgPlan? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3Data? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1OauthApp? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1OauthAppImageData? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2OauthApp? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2OauthAppImageData? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrg? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgPlan? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgUserRole? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4Data? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant1? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant1OauthApp? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant1OauthAppImageData? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant1Plan? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2OauthApp? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2OauthAppImageData? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2PrimaryOrg? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5Data? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant1? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant1OauthApp? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant1OauthAppImageData? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant1Plan? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2OauthApp? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2OauthAppImageData? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2PrimaryOrg? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2PrimaryOrgPlan? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2PrimaryOrgUserRole? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6Data? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant1? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant1OauthApp? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant1OauthAppImageData? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant1Plan? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2OauthApp? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2OauthAppImageData? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2PrimaryOrg? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2PrimaryOrgPlan? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2PrimaryOrgUserRole? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7Data? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant1? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant1OauthApp? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant1OauthAppImageData? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant1Plan? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2OauthApp? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2OauthAppImageData? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2PrimaryOrg? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2PrimaryOrgPlan? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2PrimaryOrgUserRole? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8Data? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant1? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant1OauthApp? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant1OauthAppImageData? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant1Plan? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2OauthApp? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2OauthAppImageData? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2PrimaryOrg? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2PrimaryOrgPlan? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2PrimaryOrgUserRole? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9Data? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, bool?>? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2Changes? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponse? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessage? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant1? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant1OauthApp? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant1OauthAppImageData? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2OauthApp? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2OauthAppImageData? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrg? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageData? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataHiddenReason? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatest? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataReaction>? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataReaction? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataReactionReaction? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataIdentifiedLanguage? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponse? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatus? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1OauthApp? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1OauthAppImageData? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2OauthApp? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2OauthAppImageData? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrg? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusData? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusDataStatus? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponse? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitle? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1, global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2>? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1OauthApp? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1OauthAppImageData? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2OauthApp? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2OauthAppImageData? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrg? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleData? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsStorageResponse? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItem? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, string, string>? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadata? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibility? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem>? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO>? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem>? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend>? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType>? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataBuilder? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie>? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemResourceGroup? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponse? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetKernelsResponseGated?>? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseGated? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseResourceGroup? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetKernelsResponseAuthorDataVariant1, global::HuggingFace.GetKernelsResponseAuthorDataVariant2>? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant1? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant1Plan? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant2? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrg? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseSupportedDriverFamilie>? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseSupportedDriverFamilie? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponse? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetKernelsRevisionResponseGated?>? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseGated? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseResourceGroup? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1, global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2>? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1Plan? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrg? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie>? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLeaderboardResponseItem>? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItem? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant1, global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2>? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant1? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant1Plan? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrg? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSource? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant1? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrg? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsJwtResponse? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsJwtResponseEncryptedToken? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesJwtResponse? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesJwtResponseEncryptedToken? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsJwtResponse? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsJwtResponseEncryptedToken? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetAgentHarnessesResponse? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetAgentHarnessesResponseHarnesses2>? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetAgentHarnessesResponseHarnesses2? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTagsByTypeResponseItem>>? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTagsByTypeResponseItem>? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTagsByTypeResponseItem? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTagsByTypeResponseItemType? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>>? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTagsByTypeResponseItem? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTagsByTypeResponseItemType? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponse? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoData? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfo? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie>? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat>? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie>? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated?>? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataResourceGroup? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoData? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProvider>? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProvider? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderFeatures? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated?>? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataResourceGroup? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrg? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgPlan? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoData? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntime? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardware? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareCurrent? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeReplicas? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<double?, string>? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain>? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHotReloading? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepo? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrg? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataResourceGroup? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant1? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant1Plan? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrg? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponse? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseDataset>? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseDataset? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseModel>? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseModel? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseOrg>? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseOrg? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseSpace>? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseSpace? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseUser>? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseUser? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponsePaper>? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponsePaper? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseCollection>? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseCollection? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseBucket>? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseBucket? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseContainer>? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseContainer? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseKernel>? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseKernel? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseBlog>? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseBlog? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponse? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseDataset>? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseDataset? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseModel>? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseModel? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseOrg>? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseOrg? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseSpace>? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseSpace? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseUser>? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseUser? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponsePaper>? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponsePaper? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseCollection>? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseCollection? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseBucket>? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseBucket? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseContainer>? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseContainer? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseKernel>? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseKernel? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseBlog>? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseBlog? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesHardwareResponseItem>? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesHardwareResponseItem? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesHardwareResponseItemAccelerator? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorType? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorManufacturer? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTemplatesResponse? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTemplatesResponseTemplate>? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTemplatesResponseTemplate? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesZeroGpuQuotaResponse? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesZeroGpuQuotaResponseRuns? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetSpacesSecretsResponse2>? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesSecretsResponse2? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetSpacesVariablesResponse2>? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesVariablesResponse2? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateResponse? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDuplicateStatusResponse? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateResponse? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateResponse2? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSqlConsoleEmbedResponse? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchSqlConsoleEmbedResponseView>? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSqlConsoleEmbedResponseView? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSqlConsoleEmbedResponse? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedHideResponse? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedResponse? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSqlConsoleEmbedResponseView>? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedResponseView? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesResolveResponse? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsResolveResponse? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetResolveResponse? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetResolveCacheSpacesResponse? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetResolveCacheDatasetsResponse? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetResolveCacheModelsResponse? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsUserAccessRequestResponseItem>? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItem? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemUser? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsUserAccessRequestResponseItemUserOrg>? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemUserOrg? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemUserServiceAccount? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1Org>? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1Org? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1ServiceAccount? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant2? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemStatus? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsUserAccessRequestResponseItem>? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItem? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUser? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUserOrg>? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUserOrg? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUserServiceAccount? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1Org>? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1Org? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1ServiceAccount? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant2? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemStatus? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem>? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItemError? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsUserAccessRequestBatchResponseItem>? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchResponseItem? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchResponseItemError? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItem>? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItem? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemPaper? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItemPaperAuthor>? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemPaperAuthor? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemPaperAuthorUser? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemPaperSubmittedOnDailyBy? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemSubmittedBy? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseItem>? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseItem? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseItemAuthor>? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseItemAuthor? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseItemAuthorUser? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseItemOrganization? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersIndexResponse? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponse? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseAuthor>? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseAuthor? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseAuthorUser? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseSubmittedOnDailyBy? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedModel>? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModel? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProvider>? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProvider? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderFeatures? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetPapersResponseLinkedModelGated?>? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelGated? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelResourceGroup? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1, global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2>? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrg? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDataset>? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDataset? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfo? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie>? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat>? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie>? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetPapersResponseLinkedDatasetGated?>? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetGated? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetResourceGroup? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedSpace>? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedSpace? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseComment>? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseComment? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseCommentAuthorVariant1, global::HuggingFace.GetPapersResponseCommentAuthorVariant2>? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant1? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant1OauthApp? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant1OauthAppImageData? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant1Plan? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2OauthApp? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2OauthAppImageData? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrg? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentData? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataHiddenReason? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatest? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1, global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2>? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1Plan? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrg? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseCommentDataReaction>? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataReaction? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataReactionReaction? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataIdentifiedLanguage? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponse? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessage? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1, global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2>? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1OauthApp? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1OauthAppImageData? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1Plan? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2OauthApp? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2OauthAppImageData? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrg? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageData? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataHiddenReason? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatest? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreatePapersCommentResponseNewMessageDataReaction>? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataReaction? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataReactionReaction? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataIdentifiedLanguage? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponse? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessage? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1OauthApp? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1OauthAppImageData? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2OauthApp? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2OauthAppImageData? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrg? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageData? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataHiddenReason? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatest? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataReaction>? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataReaction? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataReactionReaction? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataIdentifiedLanguage? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersLinksResponse? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponse? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessage? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1, global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2>? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1OauthApp? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1OauthAppImageData? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1Plan? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2OauthApp? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2OauthAppImageData? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrg? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageData? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataHiddenReason? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatest? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreatePostsCommentResponseNewMessageDataReaction>? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataReaction? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataReactionReaction? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataIdentifiedLanguage? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponse? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessage? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant1? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant1OauthApp? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant1OauthAppImageData? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2OauthApp? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2OauthAppImageData? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrg? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageData? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataHiddenReason? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatest? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataReaction>? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataReaction? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataReactionReaction? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataIdentifiedLanguage? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponse? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3>?>? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3>? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant1? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant2? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3Notifications? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3NotificationsMode? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3ProfileSharingVariant1? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3ProfileSharingVariant2? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseOwnerVariant1, global::HuggingFace.GetCollectionsResponseOwnerVariant2>? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant1? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant1Plan? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrg? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrgPlan? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseTheme? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseResourceGroup? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1Note? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfo? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoViewer? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie>? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat>? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie>? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseItemVariant1Gated?>? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1Gated? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1ResourceGroup? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2Note? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider>? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderTask? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderFeatures? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseItemVariant2Gated?>? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2Gated? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2ResourceGroup? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant1, global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2>? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant1? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant1Plan? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrg? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Note? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Sdk? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Runtime? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeStage? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardware? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardwareCurrent? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardwareRequested? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeReplicas? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain>? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomainStage? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHotReloading? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepo? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3ResourceGroup? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant1, global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2>? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant1? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant1Plan? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrg? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Visibility? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant4? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant4Note? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5Note? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant1, global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2>? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant1? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant1Plan? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrg? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5Theme? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6Note? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6RepoType? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6Disabled? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion>? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegionProvider? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegionRegion? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6ResourceGroup? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponse? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseData? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant2, global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3>? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant2? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant2ProfileSharingVariant1? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant2ProfileSharingVariant2? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3Notifications? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3NotificationsMode? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3ProfileSharingVariant1? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3ProfileSharingVariant2? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.PatchCollectionsResponseDataOwnerVariant1, global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2>? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant1? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant1Plan? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrg? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataTheme? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataResourceGroup? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1Note? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfo? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie>? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat>? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie>? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataItemVariant1Gated?>? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1Gated? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1ResourceGroup? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2Note? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider>? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderFeatures? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataItemVariant2Gated?>? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2Gated? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2ResourceGroup? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant1? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrg? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Note? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Sdk? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Runtime? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStage? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardware? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareRequested? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeReplicas? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain>? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomainStage? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHotReloading? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepo? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3ResourceGroup? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant1? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrg? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Visibility? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant4? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant4Note? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5Note? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1, global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2>? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1Plan? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrg? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5Theme? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6Note? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6RepoType? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6Disabled? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion>? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionProvider? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionRegion? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6ResourceGroup? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponse2? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant22, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant32>? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant22? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant12? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant22? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant32? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3Notifications2? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3NotificationsMode2? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3ProfileSharingVariant12? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3ProfileSharingVariant22? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseOwnerVariant12, global::HuggingFace.GetCollectionsResponseOwnerVariant22>? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant12? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant1Plan2? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant22? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrg2? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseTheme2? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseResourceGroup2? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant12? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1Note2? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfo2? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2>? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2>? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2>? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseItemVariant1Gated2?>? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1Gated2? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1ResourceGroup2? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant22? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2Note2? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider2>? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider2? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus2? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderFeatures2? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseItemVariant2Gated2?>? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2Gated2? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2ResourceGroup2? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant12, global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant22>? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant12? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant1Plan2? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant22? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrg2? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant32? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Note2? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Sdk2? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Runtime2? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeStage2? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardware2? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardwareCurrent2? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardwareRequested2? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeReplicas2? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain2>? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain2? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomainStage2? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHotReloading2? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepo2? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant12? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan2? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant22? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg2? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3ResourceGroup2? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant12, global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant22>? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant12? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant1Plan2? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant22? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrg2? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan2? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole2? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Visibility2? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant42? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant4Note2? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant52? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5Note2? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant12, global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant22>? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant12? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant1Plan2? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant22? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrg2? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan2? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5Theme2? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant62? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6Note2? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6RepoType2? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6Disabled2? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion2>? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion2? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegionProvider2? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegionRegion2? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6ResourceGroup2? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponse2? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseData2? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant22? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant2ProfileSharingVariant12? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant2ProfileSharingVariant22? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant32? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3Notifications2? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3NotificationsMode2? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3ProfileSharingVariant12? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3ProfileSharingVariant22? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.PatchCollectionsResponseDataOwnerVariant12, global::HuggingFace.PatchCollectionsResponseDataOwnerVariant22>? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant12? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant1Plan2? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant22? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrg2? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataTheme2? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataResourceGroup2? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant12? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1Note2? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfo2? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer2? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2>? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2>? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2>? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataItemVariant1Gated2?>? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1Gated2? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1ResourceGroup2? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant22? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2Note2? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider2>? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider2? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderFeatures2? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataItemVariant2Gated2?>? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2Gated2? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2ResourceGroup2? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant12? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant22? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrg2? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan2? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant32? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Note2? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Sdk2? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Runtime2? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStage2? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardware2? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent2? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareRequested2? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeReplicas2? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain2>? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain2? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomainStage2? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHotReloading2? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepo2? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant12? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant22? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrg2? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3ResourceGroup2? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant12? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan2? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant22? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrg2? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole2? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Visibility2? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant42? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant4Note2? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant52? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5Note2? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant12? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1Plan2? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant22? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrg2? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5Theme2? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant62? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6Note2? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6RepoType2? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6Disabled2? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion2>? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion2? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionProvider2? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionRegion2? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6ResourceGroup2? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponse? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant1? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant2? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3Notifications? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant1? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant2? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant1, global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2>? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant1? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant1Plan? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrg? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseTheme? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseResourceGroup? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Note? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfo? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie>? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat>? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie>? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated?>? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1ResourceGroup? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Note? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider>? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderFeatures? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Gated?>? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Gated? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2ResourceGroup? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrg? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Note? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Sdk? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Runtime? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeStage? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardware? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardwareRequested? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeReplicas? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain>? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHotReloading? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepo? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3ResourceGroup? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrg? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Visibility? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant4? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant4Note? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5Note? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant1? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant1Plan? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrg? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5Theme? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6Note? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6RepoType? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6Disabled? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion>? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegionProvider? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegionRegion? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6ResourceGroup? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponse2? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant22? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant12? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant22? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant32? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3Notifications2? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode2? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant12? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant22? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant12, global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant22>? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant12? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant1Plan2? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant22? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrg2? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseTheme2? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseResourceGroup2? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant12? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Note2? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfo2? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2>? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2>? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2>? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated2?>? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated2? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1ResourceGroup2? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant22? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Note2? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider2>? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider2? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderFeatures2? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Gated2?>? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Gated2? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2ResourceGroup2? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant12? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan2? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant22? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrg2? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant32? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Note2? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Sdk2? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Runtime2? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeStage2? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardware2? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardwareRequested2? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeReplicas2? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain2>? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain2? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHotReloading2? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepo2? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant12? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant22? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg2? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3ResourceGroup2? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant12? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan2? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant22? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrg2? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan2? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole2? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Visibility2? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant42? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant4Note2? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant52? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5Note2? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant12? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant1Plan2? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant22? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrg2? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan2? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5Theme2? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant62? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6Note2? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6RepoType2? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6Disabled2? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion2>? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion2? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegionProvider2? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6ResourceGroup2? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponse? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant2, global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3>? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant2? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant2ProfileSharingVariant1? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant2ProfileSharingVariant2? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3Notifications? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3NotificationsMode? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3ProfileSharingVariant1? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3ProfileSharingVariant2? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateCollectionsResponseOwnerVariant1, global::HuggingFace.CreateCollectionsResponseOwnerVariant2>? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant1? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant1Plan? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant2? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant2PrimaryOrg? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseTheme? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseResourceGroup? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1Note? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfo? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie>? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat>? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie>? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsResponseItemVariant1Gated?>? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1Gated? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1ResourceGroup? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2Note? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProvider>? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProvider? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderFeatures? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsResponseItemVariant2Gated?>? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2Gated? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2ResourceGroup? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant1? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrg? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3Note? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3Sdk? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3Runtime? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeStage? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHardware? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHardwareCurrent? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHardwareRequested? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeReplicas? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomain>? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomain? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomainStage? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHotReloading? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepo? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3ResourceGroup? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant1? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant1Plan? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant2? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrg? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3Visibility? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant4? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant4Note? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5Note? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant1, global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2>? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant1? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant1Plan? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrg? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5Theme? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6Note? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6RepoType? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6Disabled? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegion>? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegion? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegionProvider? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegionRegion? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6ResourceGroup? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponse2? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1Item>, global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant2Item>>? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1Item>? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1Item? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant2? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant2ProfileSharingVariant1? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant2ProfileSharingVariant2? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant3? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant3Notifications? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant3NotificationsMode? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant3ProfileSharingVariant1? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant3ProfileSharingVariant2? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant1, global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2>? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant1? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant1Plan? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrg? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgPlan? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemTheme? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemResourceGroup? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1Note? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfo? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie>? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat>? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie>? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1Gated?>? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1Gated? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1ResourceGroup? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2Note? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProvider>? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProvider? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderTask? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderFeatures? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2Gated?>? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2Gated? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2ResourceGroup? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant1? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant1Plan? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant2? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant2PrimaryOrg? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3Note? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3Sdk? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3Runtime? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeHardware? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeHardwareCurrent? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeHardwareRequested? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeReplicas? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomain>? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomain? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeHotReloading? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepo? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant1? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant1Plan? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3ResourceGroup? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant1? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant1Plan? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant2? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant2PrimaryOrg? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3Visibility? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant4? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant4Note? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5Note? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant1? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant1Plan? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrg? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgPlan? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5Theme? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6Note? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6RepoType? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6Disabled? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegion>? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegion? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProvider? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegion? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6ResourceGroup? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant2Item>? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant2Item? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant2ItemResourceGroup? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResourceGroupResponse? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResourceGroupResponse? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResourceGroupResponse2? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResourceGroupResponse2? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResponse? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResponse2? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponse? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseRepoType? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseDisabled? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsResponseCdnRegion>? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseCdnRegion? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseCdnRegionProvider? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseCdnRegionRegion? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseResourceGroup? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersResponse? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersResponse2? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponse? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseRepoType? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseDisabled? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetContainersResponseCdnRegion>? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseCdnRegion? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseCdnRegionProvider? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseCdnRegionRegion? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseResourceGroup? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsResponse? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutBucketsSettingsResponseCdnRegion>? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsResponseCdnRegion? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsResponseCdnRegionProvider? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsResponseCdnRegionRegion? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsResponse? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsResponseCdnRegion>? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsResponseCdnRegion? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsResponseItem>? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItem? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemRepoType? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemDisabled? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsResponseItemCdnRegion>? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemCdnRegion? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemCdnRegionProvider? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemCdnRegionRegion? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemResourceGroup? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetContainersResponseItem>? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItem? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemRepoType? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemDisabled? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetContainersResponseItemCdnRegion>? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemCdnRegion? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemCdnRegionProvider? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemCdnRegionRegion? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemResourceGroup? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResolveResponse? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResolveResponse3? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResolveResponse4? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResolveResponse? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResolveResponse3? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResolveResponse4? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsBatchResponse? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsBatchResponseFailedItem>? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsBatchResponseFailedItem? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsBatchResponse2? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsBatchResponseFailedItem2>? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsBatchResponseFailedItem2? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersBatchResponse? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersBatchResponseFailedItem>? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersBatchResponseFailedItem? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersBatchResponse2? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersBatchResponseFailedItem2>? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersBatchResponseFailedItem2? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsTreeResponseItem>? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsTreeResponseItem? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsTreeResponseItemType? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetContainersTreeResponseItem>? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersTreeResponseItem? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersTreeResponseItemType? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsEventsResponse? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsPathsInfoResponseItem>? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsPathsInfoResponseItem? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsPathsInfoResponseItemType? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersPathsInfoResponseItem>? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersPathsInfoResponseItem? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersPathsInfoResponseItemType? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsHardwareResponseItem>? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsHardwareResponseItem? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsHardwareResponseItemAccelerator? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsResponseItem>? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItem? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemArch? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemFlavor? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemCreatedBy? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemDurations? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsResponseItemVolume>? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemVolume? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemExpose? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemNetwork? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemOwner? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemOwnerType? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemResourceGroup? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant1? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant1Type? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant2? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant3? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant4? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemStatus? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemStatusStage? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsResponseItemStatusCancelReason?, string>? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemStatusCancelReason? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemHfToken? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemHfTokenTokenRole? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponse? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseArch? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseFlavor? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseCreatedBy? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseDurations? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsResponseVolume>? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseVolume? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseExpose? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseNetwork? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseOwner? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseOwnerType? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseResourceGroup? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant1? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant1Type? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant2? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant3? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant4? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseStatus? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseStatusStage? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsResponseStatusCancelReason?, string>? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseStatusCancelReason? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseHfToken? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseHfTokenTokenRole? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsCountResponse? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponse? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseArch? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseFlavor? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseCreatedBy? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseDurations? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsResponseVolume>? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseVolume? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseExpose? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseNetwork? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseOwner? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseOwnerType? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseResourceGroup? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant1? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant1Type? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant2? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant3? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant4? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseStatus? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseStatusStage? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsResponseStatusCancelReason?, string>? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseStatusCancelReason? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseHfToken? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseHfTokenTokenRole? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponse? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseArch? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseFlavor? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseCreatedBy? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseDurations? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsCancelResponseVolume>? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseVolume? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseExpose? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseNetwork? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseOwner? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseOwnerType? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseResourceGroup? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant1? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant1Type? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant2? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant3? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant4? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseStatus? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseStatusStage? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsCancelResponseStatusCancelReason?, string>? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseStatusCancelReason? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseHfToken? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseHfTokenTokenRole? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponse? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseArch? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseFlavor? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseCreatedBy? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseDurations? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsDuplicateResponseVolume>? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseVolume? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseExpose? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseNetwork? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseOwner? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseOwnerType? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseResourceGroup? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant1? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant1Type? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant2? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant3? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant4? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseStatus? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseStatusStage? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsDuplicateResponseStatusCancelReason?, string>? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseStatusCancelReason? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseHfToken? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseHfTokenTokenRole? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponse? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseArch? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseFlavor? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseCreatedBy? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseDurations? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutJobsLabelsResponseVolume>? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseVolume? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseExpose? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseNetwork? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseOwner? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseOwnerType? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseResourceGroup? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant1? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant1Type? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant2? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant3? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant4? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseStatus? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseStatusStage? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutJobsLabelsResponseStatusCancelReason?, string>? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseStatusCancelReason? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseHfToken? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseHfTokenTokenRole? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponse? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseArch? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseFlavor? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseCreatedBy? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseDurations? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutJobsExposeResponseVolume>? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseVolume? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseExpose? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseNetwork? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseOwner? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseOwnerType? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseResourceGroup? Type3686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant1? Type3687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant1Type? Type3688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant2? Type3689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant3? Type3690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant4? Type3691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseStatus? Type3692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseStatusStage? Type3693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutJobsExposeResponseStatusCancelReason?, string>? Type3694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseStatusCancelReason? Type3695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseHfToken? Type3696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseHfTokenTokenRole? Type3697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponse? Type3698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseStatus? Type3699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseStatusLastJob? Type3700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseOwner? Type3701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseOwnerType? Type3702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseInitiator? Type3703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseInitiatorType? Type3704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpec? Type3705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecArch? Type3706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecFlavor? Type3707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecDurations? Type3708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsResponseJobSpecVolume>? Type3709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecVolume? Type3710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecExpose? Type3711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecNetwork? Type3712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecResourceGroup? Type3713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecHfToken? Type3714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecHfTokenTokenRole? Type3715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetScheduledJobsResponseItem>? Type3716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItem? Type3717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemStatus? Type3718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemStatusLastJob? Type3719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemOwner? Type3720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemOwnerType? Type3721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemInitiator? Type3722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemInitiatorType? Type3723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpec? Type3724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecArch? Type3725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecFlavor? Type3726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecDurations? Type3727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetScheduledJobsResponseItemJobSpecVolume>? Type3728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecVolume? Type3729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecExpose? Type3730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecNetwork? Type3731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecResourceGroup? Type3732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecHfToken? Type3733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecHfTokenTokenRole? Type3734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponse? Type3735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseStatus? Type3736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseStatusLastJob? Type3737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseOwner? Type3738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseOwnerType? Type3739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseInitiator? Type3740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseInitiatorType? Type3741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpec? Type3742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecArch? Type3743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecFlavor? Type3744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecDurations? Type3745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetScheduledJobsResponseJobSpecVolume>? Type3746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecVolume? Type3747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecExpose? Type3748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecNetwork? Type3749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecResourceGroup? Type3750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecHfToken? Type3751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecHfTokenTokenRole? Type3752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponse? Type3753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseArch? Type3754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseFlavor? Type3755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseCreatedBy? Type3756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseDurations? Type3757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsRunResponseVolume>? Type3758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseVolume? Type3759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseExpose? Type3760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseNetwork? Type3761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseOwner? Type3762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseOwnerType? Type3763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseResourceGroup? Type3764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant1? Type3765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant1Type? Type3766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant2? Type3767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant3? Type3768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant4? Type3769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseStatus? Type3770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseStatusStage? Type3771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateScheduledJobsRunResponseStatusCancelReason?, string>? Type3772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseStatusCancelReason? Type3773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseHfToken? Type3774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseHfTokenTokenRole? Type3775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponse2? Type3776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponse? Type3777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseStatus? Type3778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseStatusLastJob? Type3779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseOwner? Type3780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseOwnerType? Type3781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseInitiator? Type3782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseInitiatorType? Type3783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpec? Type3784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecArch? Type3785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecFlavor? Type3786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecDurations? Type3787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecVolume>? Type3788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecVolume? Type3789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecExpose? Type3790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecNetwork? Type3791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecResourceGroup? Type3792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecHfToken? Type3793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole? Type3794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponse? Type3795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseStatus? Type3796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseStatusLastJob? Type3797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseOwner? Type3798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseOwnerType? Type3799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseInitiator? Type3800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseInitiatorType? Type3801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpec? Type3802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecArch? Type3803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecFlavor? Type3804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecDurations? Type3805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecVolume>? Type3806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecVolume? Type3807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecExpose? Type3808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecNetwork? Type3809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecResourceGroup? Type3810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecHfToken? Type3811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole? Type3812 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.JobVolume>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchSettingsWatchRequestDeleteItem>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchSettingsWatchRequestAddItem>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestDomain>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume2>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksRequestDomain2>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsRequestUser>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.RepoId>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContent>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContent>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroup>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2UsersRequestEmail>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperation>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2UsersRequestEmail>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2GroupsRequestMember>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2GroupsRequestMember>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2GroupsRequestOperationVariant1ValueItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequestEmail>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperation>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsRequestMember>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequestMember>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant1ValueItem>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsLfsFilesDuplicateRequestFile>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequestFile>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestFile>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestFile>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPreuploadRequestFile>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPreuploadRequestFile>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPreuploadRequestFile>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>, global::System.Collections.Generic.List<string>>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>?>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDuplicateRequestSecret>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDuplicateRequestVariable>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDuplicateRequestVolume>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateReposCreateRequestVariant1File>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateReposCreateRequestVariant2File>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateReposCreateRequestVariant3File>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateReposCreateRequestVariant4File>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateReposCreateRequestVariant4Secret>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateReposCreateRequestVariant4Variable>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateReposCreateRequestVariant4Volume>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSqlConsoleEmbedRequestView>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutSpacesVolumesRequestVolume>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsBatchRequestItem>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsBatchRequestItem2>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsRequestCdnItem>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateContainersRequestCdnItem>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutBucketsSettingsRequestCdnRegion>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutContainersSettingsRequestCdnRegion>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsRequestVariant1Volume>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsRequestVariant2Volume>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Volume>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Volume>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowersExpandItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsLikersExpandItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsLikersExpandItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesLikersExpandItem>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsLikersExpandItem>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsCommitsExpandItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesCommitsExpandItem>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsCommitsExpandItem>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.List<global::HuggingFace.GetKernelsExpandItem>>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsExpandItem>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.List<string>>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchTypeVariant1Item>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>?>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.List<string>>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchTypeVariant1Item>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>?>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.List<global::HuggingFace.GetSearchFullTextTypeItem>>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSearchFullTextTypeItem>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesSemanticSearchSdkItem>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetPapersField2?, global::System.Collections.Generic.List<global::HuggingFace.GetPapersFieldItem>>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersFieldItem>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.List<global::HuggingFace.GetJobsStageItem>>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsStageItem>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsCountStage2?, global::System.Collections.Generic.List<global::HuggingFace.GetJobsCountStageItem>>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsCountStageItem>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussionParticipatingItem>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionParticipatingItem>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant3PostParticipatingItem>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant4BlogParticipatingItem>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsMcpResponseSpaceTool>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseItem>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItem>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseItemDomain>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItem>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem2>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem3>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsRepositoriesResponseItem>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsTokensResponseItem>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsAuditLogExportResponseItem>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsResourceGroupsResponseUser>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsResourceGroupsResponseUser>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUser>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUser>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseAuthorOrg>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsInviteResponseInviteeOrg>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItem>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemAuthorOrg>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsResourceGroupsInvitationsResponseItemInviteeOrg>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseAuthorOrg>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsInvitationResendResponseInviteeOrg>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUser>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUser>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsResourceGroupsResponseItem>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUser>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsResponseUser>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContent>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContent>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseItem>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessToken>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsMembersResponseItem>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroup>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItem>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2SchemasResponseItem>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseResource>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceSchema>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceEmail>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2UsersResponseSchema>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2UsersResponseEmail>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema2>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseEmail>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2UsersResponseSchema>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2UsersResponseEmail>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2UsersResponseSchema>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2UsersResponseEmail>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResource>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceSchema>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMember>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2GroupsResponseSchema>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMember>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema2>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseMember>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2GroupsResponseSchema>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2GroupsResponseMember>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2GroupsResponseSchema>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMember>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResource>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceSchema>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceEmail>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseSchema>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseEmail>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema2>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseEmail>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseSchema>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseEmail>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseSchema>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmail>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResource>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceSchema>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMember>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseSchema>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMember>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema2>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMember>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseSchema>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMember>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseSchema>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMember>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthRegisterResponseGrantType>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseHardwareItem>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseOrg>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseHardwareItem>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseOrg>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroup>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction2>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction2>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDocsResponseItem>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDocsSearchResponseItem>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDocsSearchFullTextResponseHit>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseOrg>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriod>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageInferenceResponseItem>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageInferenceResponseItemUsageItem>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriod>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriodSession>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsBillingUsageJobsResponseUsageJobDetail>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersOverviewResponseOrg>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersOverviewResponseHardwareItem>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersLikesResponseItem>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowersResponseItemVariant1Org>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingResponseItem>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingResponseItemOrg>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingOrgsResponseItem>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsLfsFilesResponseItem>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsLfsFilesResponseItem>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesLfsFilesResponseItem>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem2>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem2>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem2>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem2>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem2>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsCommitsResponseItem>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsCommitsResponseItemAuthor>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesCommitsResponseItem>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesCommitsResponseItemAuthor>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsCommitsResponseItem>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsCommitsResponseItemAuthor>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponseTag>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponseBranche>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponseConvert>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponsePullRequest>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsRefsResponseTag>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsRefsResponseBranche>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsRefsResponseConvert>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsRefsResponsePullRequest>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponseTag>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponseBranche>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponseConvert>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponsePullRequest>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItem>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItem>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItem>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPreuploadResponseFile>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPreuploadResponseFile>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPreuploadResponseFile>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItem>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImport>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItem>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItem>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImport>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsScanResponseFilesWithIssue>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsScanResponseFilesWithIssue>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesScanResponseFilesWithIssue>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsScanResponseFilesWithIssue>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDiscussionsResponseDiscussion>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDiscussionsResponseDiscussionTopReaction>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataReaction>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReaction>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<string>, bool?>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataReaction>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItem>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseSupportedDriverFamilie>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsLeaderboardResponseItem>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::HuggingFace.GetModelsTagsByTypeResponseItem>>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTagsByTypeResponseItem>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProvider>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseDataset>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseModel>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseOrg>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseSpace>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseUser>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponsePaper>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseCollection>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseBucket>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseContainer>? ListType357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseKernel>? ListType358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseBlog>? ListType359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseDataset>? ListType360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseModel>? ListType361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseOrg>? ListType362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseSpace>? ListType363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseUser>? ListType364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponsePaper>? ListType365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseCollection>? ListType366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseBucket>? ListType367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseContainer>? ListType368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseKernel>? ListType369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseBlog>? ListType370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesHardwareResponseItem>? ListType371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTemplatesResponseTemplate>? ListType372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchSqlConsoleEmbedResponseView>? ListType373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSqlConsoleEmbedResponseView>? ListType374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsUserAccessRequestResponseItem>? ListType375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsUserAccessRequestResponseItemUserOrg>? ListType376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1Org>? ListType377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsUserAccessRequestResponseItem>? ListType378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUserOrg>? ListType379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1Org>? ListType380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem>? ListType381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsUserAccessRequestBatchResponseItem>? ListType382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDailyPapersResponseItem>? ListType383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDailyPapersResponseItemPaperAuthor>? ListType384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseItem>? ListType385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseItemAuthor>? ListType386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseAuthor>? ListType387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedModel>? ListType388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProvider>? ListType389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDataset>? ListType390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie>? ListType391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat>? ListType392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie>? ListType393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedSpace>? ListType394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseComment>? ListType395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseCommentDataReaction>? ListType396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreatePapersCommentResponseNewMessageDataReaction>? ListType397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataReaction>? ListType398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreatePostsCommentResponseNewMessageDataReaction>? ListType399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataReaction>? ListType400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie>? ListType401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat>? ListType402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie>? ListType403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider>? ListType404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain>? ListType405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion>? ListType406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie>? ListType407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat>? ListType408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie>? ListType409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider>? ListType410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain>? ListType411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion>? ListType412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2>? ListType413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2>? ListType414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2>? ListType415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider2>? ListType416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain2>? ListType417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion2>? ListType418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2>? ListType419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2>? ListType420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2>? ListType421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider2>? ListType422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain2>? ListType423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion2>? ListType424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie>? ListType425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat>? ListType426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie>? ListType427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider>? ListType428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain>? ListType429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion>? ListType430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2>? ListType431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2>? ListType432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2>? ListType433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider2>? ListType434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain2>? ListType435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion2>? ListType436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie>? ListType437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat>? ListType438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie>? ListType439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProvider>? ListType440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomain>? ListType441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegion>? ListType442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1Item>, global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant2Item>>? ListType443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1Item>? ListType444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie>? ListType445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat>? ListType446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie>? ListType447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProvider>? ListType448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomain>? ListType449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegion>? ListType450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant2Item>? ListType451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetBucketsResponseCdnRegion>? ListType452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetContainersResponseCdnRegion>? ListType453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutBucketsSettingsResponseCdnRegion>? ListType454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutContainersSettingsResponseCdnRegion>? ListType455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetBucketsResponseItem>? ListType456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetBucketsResponseItemCdnRegion>? ListType457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetContainersResponseItem>? ListType458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetContainersResponseItemCdnRegion>? ListType459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsBatchResponseFailedItem>? ListType460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsBatchResponseFailedItem2>? ListType461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateContainersBatchResponseFailedItem>? ListType462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateContainersBatchResponseFailedItem2>? ListType463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetBucketsTreeResponseItem>? ListType464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetContainersTreeResponseItem>? ListType465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsPathsInfoResponseItem>? ListType466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateContainersPathsInfoResponseItem>? ListType467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsHardwareResponseItem>? ListType468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsResponseItem>? ListType469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsResponseItemVolume>? ListType470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsResponseVolume>? ListType471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsResponseVolume>? ListType472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsCancelResponseVolume>? ListType473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsDuplicateResponseVolume>? ListType474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutJobsLabelsResponseVolume>? ListType475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutJobsExposeResponseVolume>? ListType476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsResponseJobSpecVolume>? ListType477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetScheduledJobsResponseItem>? ListType478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetScheduledJobsResponseItemJobSpecVolume>? ListType479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetScheduledJobsResponseJobSpecVolume>? ListType480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsRunResponseVolume>? ListType481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecVolume>? ListType482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecVolume>? ListType483 { get; set; }
    }
}