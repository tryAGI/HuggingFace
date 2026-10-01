
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
        public global::System.Collections.Generic.Dictionary<string, object?>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobArch? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobFlavor? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobStatus? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobStatusStage? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.JobStatusCancelReason?, string>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobStatusCancelReason? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobCreatedBy? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobDurations? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.JobVolume>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobVolume? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobExpose? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.JobNetwork? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteNotificationsRequest? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateNotificationsMarkAsReadRequest? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCredentialsRevokeRequest? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsNotificationsRequest? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsNotificationsRequestNotifications? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequest? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestDeleteItem>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequestDeleteItem? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequestDeleteItemType? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestAddItem>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequestAddItem? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSettingsWatchRequestAddItemType? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequest? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Expose? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Ssh? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Network? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Expose? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Ssh? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Network? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestDomain? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequest2? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestWatchedItemType2? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Flavor2? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Arch2? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Volume2? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1VolumeType2? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Expose2? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Ssh2? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant1Network2? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Flavor2? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Arch2? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume2>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Volume2? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2VolumeType2? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Expose2? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Ssh2? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestJobVariant2Network2? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain2>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksRequestDomain2? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsPapersClaimRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::HuggingFace.CreateSettingsInferenceProvidersRequest2>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsInferenceProvidersRequest2? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequest? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequestProvider? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSettingsInferenceProvidersDefaultBillingEntityRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSettingsInferenceProvidersUsageLimitsRequest? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1, global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsRequest? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsRequestSpendLimits? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequest? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, string>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant2? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequest? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant2? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestRole? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequest? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsRequestUser>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestUser? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestUserRole? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.RepoId>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant1? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Scope? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant2? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequest? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContent>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContent? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource?, string>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContent>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContent? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource?, string>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsRequest? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequest? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequest? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersRoleRequest? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersRoleRequestRole? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroup>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroup? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroupRole? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2UsersRequestEmail>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersRequestEmail? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersRequestName? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersRequest? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperation>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperation? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperationPath? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersRequest? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2UsersRequestEmail>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersRequestEmail? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersRequestName? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsRequest? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2GroupsRequestMember>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsRequestMember? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsRequest? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2GroupsRequestMember>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsRequestMember? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsRequest? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsRequestOperationVariant1? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2GroupsRequestOperationVariant1ValueItem>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsRequestOperationVariant1ValueItem? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsRequestOperationVariant2? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequest? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequestEmail>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequestEmail? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequest? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperation>? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperation? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperationOp? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperationPath? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersRequest? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsRequest? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsRequestMember>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsRequestMember? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequest? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequestMember>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsRequestMember? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequest? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant1? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant1ValueItem>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant1ValueItem? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant2? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterRequest? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterRequestTokenEndpointAuthMethod? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthDeviceRequest? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentRequest? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyRequest? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequest? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequestReaction? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequestAction? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentHideRequest? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentHideRequestReason? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentEditRequest? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentRequest2? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyRequest2? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequest2? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequestReaction2? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReactionRequestAction2? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentHideRequest2? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentHideRequestReason2? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentEditRequest2? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogResourceGroupRequest? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesBatchRequest? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesBatchRequestDeletions? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesBatchRequest? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesBatchRequestDeletions? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesBatchRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesBatchRequestDeletions? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTarget? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTargetType? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateRequestFile>? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateRequestFile? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateRequest? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTarget? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTargetType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequest? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequestTarget? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequestTargetType? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequestFile>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateRequestFile? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateRequest? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTarget? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTargetType? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestFile>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestFile? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateRequest? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTarget? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTargetType? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestFile>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestFile? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoRequest? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<string, bool?>? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoRequest? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoRequest? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadRequest? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPreuploadRequestFile>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadRequestFile? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadRequest? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPreuploadRequestFile>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadRequestFile? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadRequest? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPreuploadRequestFile>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadRequestFile? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsTagRequest? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesTagRequest? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsTagRequest? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsBranchRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesBranchRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsBranchRequest? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsResourceGroupRequest? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesResourceGroupRequest? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsResourceGroupRequest? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResourceGroupRequest? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsSuperSquashRequest? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsSuperSquashRequest? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesSuperSquashRequest? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequest? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestVisibility? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestDiscussionsSorting? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutModelsSettingsRequestGated?>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestGated? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsRequestGatedNotificationsMode? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestVisibility? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsRequestGated?>? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestGated? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequest? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestVisibility? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestDiscussionsSorting? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutDatasetsSettingsRequestGated?>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestGated? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsRequestGatedNotificationsMode? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsRequest? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentRequest? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusRequest? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusRequestStatus? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleRequest? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsPinRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsMergeRequest? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsIgnoreRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsIgnoreRequestAction? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentEditRequest? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentHideRequest? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentHideRequestReason? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentReactionRequest? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentReactionRequestReaction? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentReactionRequestAction? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsAccessRequestApproveRequest? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLang?, string>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestLang? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLibrary?, string>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestLibrary? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestRepoType?, string>? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRequestRepoType? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesSecretsRequest? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSpacesSecretsRequest? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesVariablesRequest? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSpacesVariablesRequest? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequest? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestVisibility? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestHardware? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<int?, double?>? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestSecret>? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestSecret? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestVariable>? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestVariable? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestVolume>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestVolume? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRequestVolumeType? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1Region? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1License? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1Visibility? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant1File>? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1File? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant1FileEncoding? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2Region? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2License? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2Visibility? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant2File>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2File? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant2FileEncoding? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3Region? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3License? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3Visibility? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant3File>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3File? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant3FileEncoding? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Region? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4License? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Visibility? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4File>? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4File? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4FileEncoding? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Hardware? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Secret>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Secret? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Variable>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Variable? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Volume>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Volume? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4VolumeType? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateRequestVariant4Sdk? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposMoveRequest? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposMoveRequestType? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSqlConsoleEmbedRequest? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedRequest? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSqlConsoleEmbedRequestView>? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedRequestView? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestHandleRequest? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestHandleRequestStatus? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequest? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestHandleRequestStatus? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchRequest? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequest>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequest? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequest? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequestStatus? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequestRequest>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequestRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestGrantRequest? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestGrantRequest? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesVolumesRequest? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutSpacesVolumesRequestVolume>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesVolumesRequestVolume? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesVolumesRequestVolumeType? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesHardwareRequest? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesHardwareRequestFlavor? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesSleeptimeRequest? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesDevModeRequest? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesCustomDomainRequest? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersIndexRequest? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentRequest? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyRequest? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentEditRequest? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentHideRequest? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentHideRequestReason? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReactionRequest? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReactionRequestReaction? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReactionRequestAction? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersLinksRequest? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentRequest? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyRequest? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReactionRequest? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReactionRequestReaction? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReactionRequestAction? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentHideRequest? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentHideRequestReason? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentEditRequest? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequest? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestTheme? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsRequestGatingVariant2, global::HuggingFace.PatchCollectionsRequestGatingVariant3>? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant2? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3Notifications? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3NotificationsMode? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequest2? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestTheme2? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsRequestGatingVariant22, global::HuggingFace.PatchCollectionsRequestGatingVariant32>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant22? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant32? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3Notifications2? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsRequestGatingVariant3NotificationsMode2? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequest? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequestItem? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequestItemType? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequest2? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequestItem2? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsRequestItemType2? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsBatchRequestItem>? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItem? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItemAction? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItemData? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsBatchRequestItem2>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItem2? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItemAction2? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsBatchRequestItemData2? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsItemsRequest? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsItemsRequest2? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsRequest? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsRequestItem? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsRequestItemType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResourceGroupRequest? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResourceGroupRequest2? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequest? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestVisibility? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsRequestCdnItem>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestCdnItem? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestCdnItemProvider? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestCdnItemRegion? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsRequestRegion? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequest? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestVisibility? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersRequestCdnItem>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestCdnItem? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestCdnItemProvider? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestCdnItemRegion? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersRequestRegion? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutBucketsSettingsRequestCdnRegion>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsRequestCdnRegion? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsRequestCdnRegionProvider? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsRequestCdnRegionRegion? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsRequest? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsRequestCdnRegion>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsRequestCdnRegion? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsRequestCdnRegionProvider? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsRequestCdnRegionRegion? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsPathsInfoRequest? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersPathsInfoRequest? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateJobsRequestVariant1, global::HuggingFace.CreateJobsRequestVariant2>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Flavor? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Arch? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsRequestVariant1Volume>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Volume? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1VolumeType? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Expose? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Ssh? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant1Network? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Flavor? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Arch? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsRequestVariant2Volume>? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Volume? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2VolumeType? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Expose? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Ssh? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsRequestVariant2Network? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsRequest? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequest? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1, global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Flavor? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Arch? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Volume>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Volume? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1VolumeType? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Expose? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Ssh? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Network? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Flavor? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Arch? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Volume>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Volume? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2VolumeType? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Expose? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Ssh? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Network? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleRequest? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsRequest? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreatePartnersModelsRequestVariant1, global::HuggingFace.CreatePartnersModelsRequestVariant2>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant1? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant1Status? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant1Task? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant2? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant2Status? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsRequestVariant2Task? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutPartnersModelsStatusRequest? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutPartnersModelsStatusRequestStatus? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsReadStatus? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsRepoType? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsMention? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteNotificationsReadStatus? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteNotificationsRepoType? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteNotificationsMention? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateNotificationsMarkAsReadReadStatus? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateNotificationsMarkAsReadRepoType? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateNotificationsMarkAsReadMention? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksAction? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesType? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesSort? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesDirection? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesType? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesSort? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBlogZhCommunitySort? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchProduct? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowersExpandItem>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersExpandItem? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckPerms? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckPerms2? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckPerms? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckPerms2? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsLikersExpandItem>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLikersExpandItem? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLikersExpandItem>? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLikersExpandItem? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesLikersExpandItem>? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLikersExpandItem? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsLikersExpandItem>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsLikersExpandItem? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesDirection? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesSort? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesDirection? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesSort? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesDirection? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesSort? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsCommitsExpandItem>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsCommitsExpandItem? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesCommitsExpandItem>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesCommitsExpandItem? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsExpandItem>? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsCommitsExpandItem? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsCommitContentType? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsCommitContentType? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesCommitContentType? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsRepoType? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsType? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsStatus? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsSort? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsRepoType? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsRepoType2? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteDiscussionsRepoType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentRepoType? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusRepoType? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleRepoType? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsPinRepoType? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsMergeRepoType? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteDiscussionsRefRepoType? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsStorageRepoType? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsIgnoreRepoType? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentEditRepoType? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentHideRepoType? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentReactionRepoType? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsSort? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsDirection? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsExpand2? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsExpandItem? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTagsByTypeType? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTagsByTypeType? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingType? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLang2?, string>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchLang2? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLibrary2?, string>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchLibrary2? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchTypeVariant1Item? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchReposFilterVariant1Item? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchPipelinesVariant1Item? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchRepoType2?, string>? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchRepoType2? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLang2?, string>? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchLang2? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLibrary2?, string>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchLibrary2? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchTypeVariant1Item? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchReposFilterVariant1Item? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchPipelinesVariant1Item? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRepoType2?, string>? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchRepoType2? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSearchFullTextType2? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSearchFullTextTypeItem? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateRepoType? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDuplicateStatusRepoType? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSqlConsoleEmbedRepoType? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSqlConsoleEmbedRepoType? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedRepoType? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestStatus? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestStatus? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLogsLogType? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesSemanticSearchCategory? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesSemanticSearchSdkItem>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesSemanticSearchSdkItem? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersSort? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetPapersField2?, global::System.Collections.Generic.IList<global::HuggingFace.GetPapersFieldItem>>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersField2? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersFieldItem>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersFieldItem? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsSort? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsTreeSort? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsTreeDirection? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersTreeSort? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersTreeDirection? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>>? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsStage2? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsStageItem? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsCountStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsCountStageItem>>? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsCountStage2? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsCountStageItem>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsCountStageItem? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPartnersModelsProvider? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPartnersModelsStatus? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePartnersModelsProvider? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutPartnersModelsStatusProvider? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponse? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant1? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant1Paper? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussion? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussionParticipatingItem>? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussionParticipatingItem? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant2? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant2Discussion? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionStatus? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionParticipatingItem>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionParticipatingItem? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant3? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant3Post? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant3PostParticipatingItem>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant3PostParticipatingItem? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant4? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant4Blog? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant4BlogParticipatingItem>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseNotificationVariant4BlogParticipatingItem? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetNotificationsResponseCount? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsMcpResponse? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsMcpResponseSpaceTool>? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsMcpResponseSpaceTool? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseItem>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItem? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant1Flavor? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemJobVariant2Flavor? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItem>? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItem? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItemType? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseItemDomain>? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseItemDomain? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponse? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhook? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem>? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain>? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponse? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhook? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1, global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2>? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant1Flavor? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookJobVariant2Flavor? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItem>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItem? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItemType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponse2? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhook2? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant12, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant22>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant12? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor2? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant22? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor2? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem2>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem2? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType2? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2>? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSettingsWebhooksResponse? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponse3? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhook3? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant13, global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant23>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant13? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant1Flavor3? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant23? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJobVariant2Flavor3? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem3>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem3? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItemType3? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3>? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsWebhooksReplayResponse? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSettingsPapersClaimResponse? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsRepositoriesResponseItem>? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesResponseItem? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesResponseItemType? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsRepositoriesResponseItemVisibility? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItem>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItem? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemRole? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemOwner? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorization? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationStatus? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemAuthorizationAuthorizer? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrained? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntity? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemEntityType? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission>? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem>? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemType? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItemVisibility? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsAuditLogExportResponseItem>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItem? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemType? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemLocation? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthor? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemAuthorType? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemToken? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemTokenRole? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAuditLogExportResponseItemOauth? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponse? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseAutoJoinVariant2? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseSpendLimits? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsResourceGroupsResponseUser>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseUser? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseUserRole? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseUserOrgRole? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant1? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant1Type? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant2? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant3? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant4? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsResponseResourceVariant5? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsResponse? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponse? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseAutoJoinVariant1? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseAutoJoinVariant2? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseSpendLimits? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsResourceGroupsResponseUser>? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseUser? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseUserRole? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseUserOrgRole? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant1? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant1Type? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant2? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant3? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant4? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseResourceVariant5? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponse? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant2? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseSpendLimits? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUser>? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUser? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUserRole? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant1Type? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant2? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant3? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant4? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseResourceVariant5? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponse? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant2? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseSpendLimits? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUser>? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUser? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUserRole? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUserOrgRole? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant1? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant1Type? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant2? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant3? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant4? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseResourceVariant5? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponse? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant2? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseSpendLimits? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUser>? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUser? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUserRole? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant1Type? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant2? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant3? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant4? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseResourceVariant5? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant2? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseSpendLimits? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUser>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUser? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUserRole? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUserOrgRole? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant1? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant1Type? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant2? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant3? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant4? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseResourceVariant5? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsResourceGroupsResponseItem>? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItem? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemAutoJoinVariant2? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemSpendLimits? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUser>? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUser? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserRole? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUserOrgRole? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant1? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant1Type? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant2? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant3? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant4? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsResourceGroupsResponseItemResourceVariant5? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponse? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseAutoJoinVariant2? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseSpendLimits? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsResponseUser>? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseUser? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseUserRole? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseUserOrgRole? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant1? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant1Type? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant2? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant3? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant4? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsResourceGroupsResponseResourceVariant5? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponse? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContent>? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContent? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContent>? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContent? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponse? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent>? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource?, string>? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent>? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource?, string>? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseItem>? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseItem? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsResponse? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponse? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessToken>? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessToken? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission>? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission>? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensResponse? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensResponseTokenInfo? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsServiceAccountsTokensResponse? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponse? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponseTokenInfo? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsAvatarResponse? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsMembersResponseItem>? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsMembersResponseItem? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsMembersResponseItemRole? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroup>? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroup? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroupRole? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponse? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponsePatch? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseBulk? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseFilter? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseChangePassword? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseSort? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseEtag? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme>? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseMeta? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItem>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItem? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItemMeta? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2SchemasResponseItem>? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2SchemasResponseItem? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2SchemasResponseItemMeta? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2SchemasResponse? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2SchemasResponseMeta? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponse? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema>? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseResource>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResource? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceSchema>? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceSchema? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceName? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceEmail>? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceEmail? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceEmailType? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceMeta? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceMetaResourceType? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponse? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2UsersResponseSchema>? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseSchema? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseName? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2UsersResponseEmail>? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseEmail? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseEmailType? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseMeta? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2UsersResponseMetaResourceType? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponse2? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema2>? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema2? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseName? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2UsersResponseEmail>? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseEmail? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseEmailType? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseMeta? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2UsersResponseMetaResourceType? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponse? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2UsersResponseSchema>? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseSchema? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseName? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2UsersResponseEmail>? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseEmail? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseEmailType? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseMeta? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2UsersResponseMetaResourceType? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponse? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2UsersResponseSchema>? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseSchema? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseName? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2UsersResponseEmail>? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseEmail? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseEmailType? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseMeta? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2UsersResponseMetaResourceType? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponse? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema>? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResource>? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResource? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceSchema>? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceSchema? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMember>? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMember? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMeta? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMetaResourceType? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponse? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2GroupsResponseSchema>? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponseSchema? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMember>? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMember? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMeta? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMetaResourceType? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponse2? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema2>? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema2? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimV2GroupsResponseMember>? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseMember? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseMeta? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimV2GroupsResponseMetaResourceType? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponse? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2GroupsResponseSchema>? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponseSchema? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimV2GroupsResponseMember>? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponseMember? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponseMeta? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimV2GroupsResponseMetaResourceType? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponse? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2GroupsResponseSchema>? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponseSchema? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMember>? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMember? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMeta? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMetaResourceType? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponse? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema>? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResource>? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResource? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceSchema>? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceSchema? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceName? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceEmail>? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceEmail? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceEmailType? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceMeta? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceMetaResourceType? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponse? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseSchema>? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseSchema? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseName? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseEmail>? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseEmail? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseEmailType? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseMeta? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseMetaResourceType? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponse2? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema2>? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema2? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseName? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseEmail>? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseEmail? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseEmailType? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseMeta? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseMetaResourceType? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponse? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseSchema>? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseSchema? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseName? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseEmail>? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseEmail? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseEmailType? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseMeta? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseMetaResourceType? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponse? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseSchema>? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseSchema? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseName? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmail>? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmail? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmailType? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseMeta? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseMetaResourceType? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponse? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema>? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResource>? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResource? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceSchema>? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceSchema? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMember>? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMember? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMeta? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMetaResourceType? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponse? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseSchema>? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseSchema? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMember>? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMember? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMeta? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponse2? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema2>? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema2? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMember>? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMember? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMeta? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponse? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseSchema>? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseSchema? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMember>? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMember? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMeta? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponse? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseSchema>? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseSchema? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMember>? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMember? Type1162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMeta? Type1163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMetaResourceType? Type1164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterResponse? Type1165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthRegisterResponseGrantType>? Type1166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterResponseGrantType? Type1167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthRegisterResponseTokenEndpointAuthMethod? Type1168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthDeviceResponse? Type1169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponse? Type1170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseHardwareItem>? Type1171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseHardwareItem? Type1172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseBillingMode? Type1173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrg>? Type1174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrg? Type1175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgPlan? Type1176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode? Type1177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg? Type1178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction>? Type1179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction? Type1180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup>? Type1181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup? Type1182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroupRole? Type1183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponse? Type1184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseHardwareItem>? Type1185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseHardwareItem? Type1186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseBillingMode? Type1187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrg>? Type1188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrg? Type1189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgPlan? Type1190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgBillingMode? Type1191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgRoleInOrg? Type1192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction>? Type1193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction? Type1194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroup>? Type1195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroup? Type1196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroupRole? Type1197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetRegistryTokenResponse? Type1198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponse? Type1199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessage? Type1200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1, global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2>? Type1201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1? Type1202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1OauthApp? Type1203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1OauthAppImageData? Type1204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1Plan? Type1205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2? Type1206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2OauthApp? Type1207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2OauthAppImageData? Type1208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrg? Type1209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type1210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type1211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageData? Type1212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataHiddenReason? Type1213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatest? Type1214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1? Type1215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan? Type1216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2? Type1217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type1218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type1219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type1220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction>? Type1221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction? Type1222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataReactionReaction? Type1223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataIdentifiedLanguage? Type1224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponse? Type1225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessage? Type1226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1? Type1227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1OauthApp? Type1228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1OauthAppImageData? Type1229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan? Type1230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2? Type1231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2OauthApp? Type1232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2OauthAppImageData? Type1233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrg? Type1234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type1235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type1236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageData? Type1237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataHiddenReason? Type1238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatest? Type1239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1? Type1240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan? Type1241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2? Type1242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type1243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type1244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type1245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction>? Type1246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction? Type1247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReactionReaction? Type1248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataIdentifiedLanguage? Type1249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponse2? Type1250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessage2? Type1251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant12, global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant22>? Type1252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant12? Type1253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1OauthApp2? Type1254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1OauthAppImageData2? Type1255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant1Plan2? Type1256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant22? Type1257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2OauthApp2? Type1258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2OauthAppImageData2? Type1259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrg2? Type1260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan2? Type1261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2? Type1262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageData2? Type1263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataHiddenReason2? Type1264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatest2? Type1265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant12? Type1266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant1Plan2? Type1267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant22? Type1268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg2? Type1269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2? Type1270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2? Type1271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction2>? Type1272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction2? Type1273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataReactionReaction2? Type1274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentResponseNewMessageDataIdentifiedLanguage2? Type1275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponse2? Type1276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessage2? Type1277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant12? Type1278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1OauthApp2? Type1279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1OauthAppImageData2? Type1280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant1Plan2? Type1281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant22? Type1282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2OauthApp2? Type1283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2OauthAppImageData2? Type1284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrg2? Type1285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan2? Type1286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2? Type1287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageData2? Type1288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataHiddenReason2? Type1289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatest2? Type1290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant12? Type1291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan2? Type1292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant22? Type1293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrg2? Type1294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2? Type1295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2? Type1296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction2>? Type1297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction2? Type1298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReactionReaction2? Type1299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataIdentifiedLanguage2? Type1300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBlogResourceGroupResponse? Type1301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBlogResourceGroupResponse? Type1302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDocsResponseItem>? Type1303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsResponseItem? Type1304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDocsSearchResponseItem>? Type1305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchResponseItem? Type1306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchResponseItemVectors? Type1307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type1308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchFullTextResponse? Type1309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDocsSearchFullTextResponseHit>? Type1310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchFullTextResponseHit? Type1311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDocsSearchFullTextResponseHitFormatted? Type1312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2Response2? Type1313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuth? Type1314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessToken? Type1315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenRole? Type1316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrained? Type1317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem>? Type1318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem? Type1319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntity? Type1320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType? Type1321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem>? Type1322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem? Type1323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseAuthResource? Type1324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseBillingMode? Type1325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrg>? Type1326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrg? Type1327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode? Type1328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgPlan? Type1329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg? Type1330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction>? Type1331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction? Type1332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup>? Type1333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup? Type1334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroupRole? Type1335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponse? Type1336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod>? Type1337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod? Type1338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup>? Type1339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup? Type1340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupStorage? Type1341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupInference? Type1342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupCompute? Type1343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeSpaces? Type1344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeEndpoints? Type1345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroupComputeJobs? Type1346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponse? Type1347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriod>? Type1348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriod? Type1349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession>? Type1350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession? Type1351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponse? Type1352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriod>? Type1353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriod? Type1354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriodSession>? Type1355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriodSession? Type1356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageJobsResponse? Type1357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageJobsResponseUsage? Type1358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageJobsResponseUsageJobDetail>? Type1359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSettingsBillingUsageJobsResponseUsageJobDetail? Type1360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersOverviewResponse? Type1361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersOverviewResponseOrg>? Type1362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersOverviewResponseOrg? Type1363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersOverviewResponseServiceAccount? Type1364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersOverviewResponseHardwareItem>? Type1365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersOverviewResponseHardwareItem? Type1366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersSocialsResponse? Type1367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersSocialsResponseSocialHandles? Type1368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersAvatarResponse? Type1369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersLikesResponseItem>? Type1370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersLikesResponseItem? Type1371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersLikesResponseItemRepo? Type1372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersLikesResponseItemRepoType? Type1373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>>? Type1374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>? Type1375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersResponseItemVariant1? Type1376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowersResponseItemVariant1Org>? Type1377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersResponseItemVariant1Org? Type1378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersResponseItemVariant1ServiceAccount? Type1379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowersResponseItemVariant2? Type1380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingResponseItem>? Type1381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingResponseItem? Type1382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingResponseItemOrg>? Type1383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingResponseItemOrg? Type1384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingResponseItemServiceAccount? Type1385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItem>? Type1386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingOrgsResponseItem? Type1387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType? Type1388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan? Type1389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain>? Type1390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain? Type1391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSocialsResponse? Type1392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetOrganizationsSocialsResponseSocialHandles? Type1393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse? Type1394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace? Type1395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser? Type1396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse2? Type1397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace2? Type1398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser2? Type1399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse3? Type1400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace3? Type1401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser3? Type1402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponse4? Type1403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseNamespace4? Type1404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateInferenceEndpointsAuthCheckResponseUser4? Type1405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponse? Type1406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponseNamespace? Type1407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponseUser? Type1408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponse2? Type1409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponseNamespace2? Type1410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsAuthCheckResponseUser2? Type1411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreesizeResponse? Type1412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreesizeResponse? Type1413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreesizeResponse? Type1414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsLfsFilesResponseItem>? Type1415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItem? Type1416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItemPusher? Type1417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrg? Type1418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan? Type1419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole? Type1420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>? Type1421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItem? Type1422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItemPusher? Type1423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItemPusherPrimaryOrg? Type1424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItemPusherPrimaryOrgPlan? Type1425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole? Type1426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesLfsFilesResponseItem>? Type1427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItem? Type1428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItemPusher? Type1429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrg? Type1430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan? Type1431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole? Type1432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateResponse? Type1433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem>? Type1434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem? Type1435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateResponse2? Type1436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem2>? Type1437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem2? Type1438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateResponse? Type1439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem>? Type1440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem? Type1441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateResponse2? Type1442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem2>? Type1443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem2? Type1444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponse? Type1445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem>? Type1446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem? Type1447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponse2? Type1448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem2>? Type1449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem2? Type1450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateResponse? Type1451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem>? Type1452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem? Type1453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateResponse2? Type1454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem2>? Type1455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem2? Type1456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateResponse? Type1457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem>? Type1458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem? Type1459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateResponse2? Type1460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem2>? Type1461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem2? Type1462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsCommitsResponseItem>? Type1463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsCommitsResponseItem? Type1464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsCommitsResponseItemAuthor>? Type1465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsCommitsResponseItemAuthor? Type1466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsCommitsResponseItemFormatted? Type1467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesCommitsResponseItem>? Type1468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesCommitsResponseItem? Type1469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesCommitsResponseItemAuthor>? Type1470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesCommitsResponseItemAuthor? Type1471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesCommitsResponseItemFormatted? Type1472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsResponseItem>? Type1473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsCommitsResponseItem? Type1474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsCommitsResponseItemAuthor>? Type1475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsCommitsResponseItemAuthor? Type1476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsCommitsResponseItemFormatted? Type1477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponse? Type1478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseTag>? Type1479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponseTag? Type1480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseBranche>? Type1481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponseBranche? Type1482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseConvert>? Type1483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponseConvert? Type1484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponsePullRequest>? Type1485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsRefsResponsePullRequest? Type1486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponse? Type1487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsRefsResponseTag>? Type1488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponseTag? Type1489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsRefsResponseBranche>? Type1490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponseBranche? Type1491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsRefsResponseConvert>? Type1492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponseConvert? Type1493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsRefsResponsePullRequest>? Type1494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsRefsResponsePullRequest? Type1495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponse? Type1496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponseTag>? Type1497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponseTag? Type1498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponseBranche>? Type1499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponseBranche? Type1500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponseConvert>? Type1501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponseConvert? Type1502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponsePullRequest>? Type1503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesRefsResponsePullRequest? Type1504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItem>? Type1505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItem? Type1506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemType? Type1507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemLfs? Type1508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemLastCommit? Type1509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatus? Type1510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusStatus? Type1511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScan? Type1512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus? Type1513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport? Type1515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScan? Type1517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus? Type1518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScan? Type1522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus? Type1523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? Type1524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport? Type1525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScan? Type1527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus? Type1528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScan? Type1532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus? Type1533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItem>? Type1537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItem? Type1538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemType? Type1539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemLfs? Type1540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemLastCommit? Type1541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatus? Type1542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusStatus? Type1543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScan? Type1544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus? Type1545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport? Type1547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScan? Type1549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus? Type1550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScan? Type1554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanStatus? Type1555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? Type1556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport? Type1557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScan? Type1559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus? Type1560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScan? Type1564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus? Type1565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItem>? Type1569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItem? Type1570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemType? Type1571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemLfs? Type1572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemLastCommit? Type1573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatus? Type1574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus? Type1575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScan? Type1576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus? Type1577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport? Type1579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScan? Type1581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus? Type1582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScan? Type1586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus? Type1587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? Type1588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImport? Type1589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScan? Type1591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus? Type1592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScan? Type1596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus? Type1597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadResponse? Type1601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPreuploadResponseFile>? Type1602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadResponseFile? Type1603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode? Type1604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadResponse? Type1605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPreuploadResponseFile>? Type1606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadResponseFile? Type1607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesPreuploadResponseFileUploadMode? Type1608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadResponse? Type1609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsPreuploadResponseFile>? Type1610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadResponseFile? Type1611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsPreuploadResponseFileUploadMode? Type1612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsXetWriteTokenResponse? Type1613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesXetWriteTokenResponse? Type1614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsXetWriteTokenResponse? Type1615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsXetWriteTokenResponse? Type1616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersXetWriteTokenResponse? Type1617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsXetReadTokenResponse? Type1618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesXetReadTokenResponse? Type1619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsXetReadTokenResponse? Type1620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsXetReadTokenResponse? Type1621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersXetReadTokenResponse? Type1622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsCommitResponse? Type1623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsCommitResponse? Type1624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesCommitResponse? Type1625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsResourceGroupResponse? Type1626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsResourceGroupResponseType? Type1627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsResourceGroupResponse? Type1628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesResourceGroupResponse? Type1629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesResourceGroupResponseType? Type1630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesResourceGroupResponse? Type1631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsResourceGroupResponse? Type1632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsResourceGroupResponseType? Type1633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsResourceGroupResponse? Type1634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResourceGroupResponse? Type1635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResourceGroupResponseType? Type1636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResourceGroupResponse? Type1637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsSuperSquashResponse? Type1638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsSuperSquashResponse? Type1639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSpacesSuperSquashResponse? Type1640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponse? Type1641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseVisibility? Type1642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting? Type1643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutModelsSettingsResponseGated?>? Type1644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseGated? Type1645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutModelsSettingsResponseGatedNotificationsMode? Type1646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponse? Type1647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseVisibility? Type1648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseDiscussionsSorting? Type1649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsResponseGated?>? Type1650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseGated? Type1651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutSpacesSettingsResponseGatedNotificationsMode? Type1652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponse? Type1653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseVisibility? Type1654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseDiscussionsSorting? Type1655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutDatasetsSettingsResponseGated?>? Type1656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseGated? Type1657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutDatasetsSettingsResponseGatedNotificationsMode? Type1658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItem>? Type1659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItem? Type1660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemType? Type1661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemLfs? Type1662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemLastCommit? Type1663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatus? Type1664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus? Type1665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScan? Type1666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus? Type1667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImport? Type1669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScan? Type1671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus? Type1672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScan? Type1676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanStatus? Type1677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImport>? Type1678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImport? Type1679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScan? Type1681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus? Type1682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScan? Type1686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus? Type1687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItem>? Type1691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItem? Type1692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemType? Type1693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemLfs? Type1694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemLastCommit? Type1695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatus? Type1696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusStatus? Type1697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScan? Type1698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus? Type1699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImport? Type1701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScan? Type1703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus? Type1704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScan? Type1708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus? Type1709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport>? Type1710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport? Type1711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScan? Type1713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus? Type1714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScan? Type1718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus? Type1719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItem>? Type1723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItem? Type1724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemType? Type1725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemLfs? Type1726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemLastCommit? Type1727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatus? Type1728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusStatus? Type1729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScan? Type1730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus? Type1731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? Type1732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImport? Type1733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety? Type1734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScan? Type1735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus? Type1736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? Type1737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport? Type1738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? Type1739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScan? Type1740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus? Type1741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImport>? Type1742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImport? Type1743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety? Type1744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScan? Type1745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus? Type1746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? Type1747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport? Type1748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? Type1749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScan? Type1750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus? Type1751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? Type1752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport? Type1753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? Type1754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetModelsNotebookResponseVariant1, global::HuggingFace.GetModelsNotebookResponseVariant2, global::HuggingFace.GetModelsNotebookResponseVariant3>? Type1755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsNotebookResponseVariant1? Type1756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsNotebookResponseVariant2? Type1757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsNotebookResponseVariant3? Type1758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetDatasetsNotebookResponseVariant1, global::HuggingFace.GetDatasetsNotebookResponseVariant2, global::HuggingFace.GetDatasetsNotebookResponseVariant3>? Type1759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsNotebookResponseVariant1? Type1760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsNotebookResponseVariant2? Type1761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsNotebookResponseVariant3? Type1762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetSpacesNotebookResponseVariant1, global::HuggingFace.GetSpacesNotebookResponseVariant2, global::HuggingFace.GetSpacesNotebookResponseVariant3>? Type1763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesNotebookResponseVariant1? Type1764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesNotebookResponseVariant2? Type1765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesNotebookResponseVariant3? Type1766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsScanResponse? Type1767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsScanResponseFilesWithIssue>? Type1768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsScanResponseFilesWithIssue? Type1769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsScanResponseFilesWithIssueLevel? Type1770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsScanResponse? Type1771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsScanResponseFilesWithIssue>? Type1772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsScanResponseFilesWithIssue? Type1773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsScanResponseFilesWithIssueLevel? Type1774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesScanResponse? Type1775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesScanResponseFilesWithIssue>? Type1776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesScanResponseFilesWithIssue? Type1777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel? Type1778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsScanResponse? Type1779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsScanResponseFilesWithIssue>? Type1780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsScanResponseFilesWithIssue? Type1781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsScanResponseFilesWithIssueLevel? Type1782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponse? Type1783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseDiscussion>? Type1784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussion? Type1785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant1, global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2>? Type1786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant1? Type1787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant1Plan? Type1788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2? Type1789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrg? Type1790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan? Type1791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole? Type1792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseDiscussionTopReaction>? Type1793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionTopReaction? Type1794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionTopReactionReaction? Type1795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionStatus? Type1796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionRepoOwner? Type1797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseDiscussionRepoOwnerType? Type1798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsResponse? Type1799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsResponseReferences? Type1800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant1, global::HuggingFace.GetDiscussionsResponseVariant2>? Type1801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1? Type1802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2>? Type1803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant1? Type1804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant1Plan? Type1805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2? Type1806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrg? Type1807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan? Type1808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgUserRole? Type1809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1Org? Type1810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1OrgPlan? Type1811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1Status? Type1812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1? Type1813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant1? Type1814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant1OauthApp? Type1815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant1OauthAppImageData? Type1816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant1Plan? Type1817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2? Type1818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2OauthApp? Type1819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2OauthAppImageData? Type1820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrg? Type1821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgPlan? Type1822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole? Type1823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1Data? Type1824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataHiddenReason? Type1825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatest? Type1826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant1? Type1827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant1Plan? Type1828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant2? Type1829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrg? Type1830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan? Type1831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole? Type1832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataReaction>? Type1833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataReaction? Type1834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataReactionReaction? Type1835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataIdentifiedLanguage? Type1836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2? Type1837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1? Type1838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthApp? Type1839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1OauthAppImageData? Type1840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant1Plan? Type1841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2? Type1842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2OauthApp? Type1843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2OauthAppImageData? Type1844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2PrimaryOrg? Type1845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2PrimaryOrgPlan? Type1846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2AuthorVariant2PrimaryOrgUserRole? Type1847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2Data? Type1848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2DataStatus? Type1849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3? Type1850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant1? Type1851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant1OauthApp? Type1852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant1OauthAppImageData? Type1853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant1Plan? Type1854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2? Type1855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2OauthApp? Type1856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2OauthAppImageData? Type1857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2PrimaryOrg? Type1858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2PrimaryOrgPlan? Type1859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3AuthorVariant2PrimaryOrgUserRole? Type1860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3Data? Type1861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4? Type1862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant1? Type1863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant1OauthApp? Type1864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant1OauthAppImageData? Type1865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant1Plan? Type1866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2? Type1867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2OauthApp? Type1868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2OauthAppImageData? Type1869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2PrimaryOrg? Type1870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2PrimaryOrgPlan? Type1871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4AuthorVariant2PrimaryOrgUserRole? Type1872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4Data? Type1873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5? Type1874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant1? Type1875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant1OauthApp? Type1876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant1OauthAppImageData? Type1877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant1Plan? Type1878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2? Type1879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2OauthApp? Type1880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2OauthAppImageData? Type1881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2PrimaryOrg? Type1882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2PrimaryOrgPlan? Type1883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5AuthorVariant2PrimaryOrgUserRole? Type1884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5Data? Type1885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6? Type1886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant1? Type1887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant1OauthApp? Type1888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant1OauthAppImageData? Type1889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant1Plan? Type1890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2? Type1891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2OauthApp? Type1892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2OauthAppImageData? Type1893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2PrimaryOrg? Type1894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2PrimaryOrgPlan? Type1895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6AuthorVariant2PrimaryOrgUserRole? Type1896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6Data? Type1897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7? Type1898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant1? Type1899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant1OauthApp? Type1900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant1OauthAppImageData? Type1901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant1Plan? Type1902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2? Type1903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2OauthApp? Type1904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2OauthAppImageData? Type1905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2PrimaryOrg? Type1906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2PrimaryOrgPlan? Type1907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7AuthorVariant2PrimaryOrgUserRole? Type1908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7Data? Type1909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8? Type1910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant1? Type1911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant1OauthApp? Type1912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant1OauthAppImageData? Type1913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant1Plan? Type1914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2? Type1915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2OauthApp? Type1916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2OauthAppImageData? Type1917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2PrimaryOrg? Type1918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2PrimaryOrgPlan? Type1919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8AuthorVariant2PrimaryOrgUserRole? Type1920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8Data? Type1921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9? Type1922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant1? Type1923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant1OauthApp? Type1924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant1OauthAppImageData? Type1925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant1Plan? Type1926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2? Type1927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2OauthApp? Type1928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2OauthAppImageData? Type1929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2PrimaryOrg? Type1930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2PrimaryOrgPlan? Type1931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9AuthorVariant2PrimaryOrgUserRole? Type1932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9Data? Type1933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant1Collection? Type1934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2? Type1935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2>? Type1936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant1? Type1937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant1Plan? Type1938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2? Type1939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2PrimaryOrg? Type1940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2PrimaryOrgPlan? Type1941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2PrimaryOrgUserRole? Type1942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2Org? Type1943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2OrgPlan? Type1944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2Status? Type1945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1? Type1946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant1? Type1947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant1OauthApp? Type1948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant1OauthAppImageData? Type1949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant1Plan? Type1950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2? Type1951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2OauthApp? Type1952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2OauthAppImageData? Type1953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2PrimaryOrg? Type1954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2PrimaryOrgPlan? Type1955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1AuthorVariant2PrimaryOrgUserRole? Type1956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1Data? Type1957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataHiddenReason? Type1958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatest? Type1959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant1? Type1960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant1Plan? Type1961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2? Type1962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrg? Type1963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan? Type1964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole? Type1965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReaction>? Type1966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReaction? Type1967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReactionReaction? Type1968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataIdentifiedLanguage? Type1969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2? Type1970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant1? Type1971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant1OauthApp? Type1972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant1OauthAppImageData? Type1973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant1Plan? Type1974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2? Type1975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2OauthApp? Type1976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2OauthAppImageData? Type1977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2PrimaryOrg? Type1978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2PrimaryOrgPlan? Type1979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2AuthorVariant2PrimaryOrgUserRole? Type1980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2Data? Type1981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2DataStatus? Type1982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3? Type1983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant1? Type1984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant1OauthApp? Type1985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant1OauthAppImageData? Type1986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant1Plan? Type1987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2? Type1988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2OauthApp? Type1989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2OauthAppImageData? Type1990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrg? Type1991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgPlan? Type1992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole? Type1993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3Data? Type1994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4? Type1995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1? Type1996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1OauthApp? Type1997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1OauthAppImageData? Type1998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant1Plan? Type1999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2? Type2000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2OauthApp? Type2001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2OauthAppImageData? Type2002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrg? Type2003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgPlan? Type2004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4AuthorVariant2PrimaryOrgUserRole? Type2005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4Data? Type2006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5? Type2007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant1? Type2008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant1OauthApp? Type2009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant1OauthAppImageData? Type2010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant1Plan? Type2011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2? Type2012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2OauthApp? Type2013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2OauthAppImageData? Type2014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2PrimaryOrg? Type2015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2PrimaryOrgPlan? Type2016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole? Type2017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5Data? Type2018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6? Type2019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant1? Type2020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant1OauthApp? Type2021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant1OauthAppImageData? Type2022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant1Plan? Type2023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2? Type2024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2OauthApp? Type2025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2OauthAppImageData? Type2026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2PrimaryOrg? Type2027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2PrimaryOrgPlan? Type2028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6AuthorVariant2PrimaryOrgUserRole? Type2029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6Data? Type2030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7? Type2031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant1? Type2032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant1OauthApp? Type2033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant1OauthAppImageData? Type2034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant1Plan? Type2035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2? Type2036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2OauthApp? Type2037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2OauthAppImageData? Type2038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2PrimaryOrg? Type2039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2PrimaryOrgPlan? Type2040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7AuthorVariant2PrimaryOrgUserRole? Type2041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7Data? Type2042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8? Type2043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant1? Type2044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant1OauthApp? Type2045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant1OauthAppImageData? Type2046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant1Plan? Type2047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2? Type2048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2OauthApp? Type2049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2OauthAppImageData? Type2050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2PrimaryOrg? Type2051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2PrimaryOrgPlan? Type2052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8AuthorVariant2PrimaryOrgUserRole? Type2053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8Data? Type2054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9? Type2055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant1? Type2056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant1OauthApp? Type2057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant1OauthAppImageData? Type2058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant1Plan? Type2059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2? Type2060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2OauthApp? Type2061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2OauthAppImageData? Type2062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2PrimaryOrg? Type2063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2PrimaryOrgPlan? Type2064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9AuthorVariant2PrimaryOrgUserRole? Type2065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2EventVariant9Data? Type2066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, bool?>? Type2067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsResponseVariant2Changes? Type2068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponse? Type2069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessage? Type2070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant1? Type2071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant1OauthApp? Type2072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant1OauthAppImageData? Type2073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant1Plan? Type2074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2? Type2075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2OauthApp? Type2076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2OauthAppImageData? Type2077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrg? Type2078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageData? Type2081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataHiddenReason? Type2082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatest? Type2083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1? Type2084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant1Plan? Type2085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2? Type2086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataReaction>? Type2090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataReaction? Type2091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataReactionReaction? Type2092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataIdentifiedLanguage? Type2093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponse? Type2094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatus? Type2095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1? Type2096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1OauthApp? Type2097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1OauthAppImageData? Type2098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant1Plan? Type2099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2? Type2100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2OauthApp? Type2101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2OauthAppImageData? Type2102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrg? Type2103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgPlan? Type2104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole? Type2105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusData? Type2106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsStatusResponseNewStatusDataStatus? Type2107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponse? Type2108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitle? Type2109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1, global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2>? Type2110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1? Type2111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1OauthApp? Type2112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1OauthAppImageData? Type2113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant1Plan? Type2114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2? Type2115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2OauthApp? Type2116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2OauthAppImageData? Type2117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrg? Type2118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgPlan? Type2119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole? Type2120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDiscussionsTitleResponseNewTitleData? Type2121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDiscussionsStorageResponse? Type2122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>? Type2123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItem? Type2124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, string, string>? Type2125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadata? Type2126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibility? Type2127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem>? Type2128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem? Type2129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO>? Type2130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO? Type2131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem>? Type2132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem? Type2133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend>? Type2134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend? Type2135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType? Type2136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType>? Type2137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType? Type2138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemBuildMetadataBuilder? Type2139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie>? Type2140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie? Type2141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseItemResourceGroup? Type2142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponse? Type2143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetKernelsResponseGated?>? Type2144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseGated? Type2145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseResourceGroup? Type2146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetKernelsResponseAuthorDataVariant1, global::HuggingFace.GetKernelsResponseAuthorDataVariant2>? Type2147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant1? Type2148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant1Plan? Type2149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant2? Type2150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrg? Type2151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan? Type2152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole? Type2153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseSupportedDriverFamilie>? Type2154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsResponseSupportedDriverFamilie? Type2155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponse? Type2156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetKernelsRevisionResponseGated?>? Type2157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseGated? Type2158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseResourceGroup? Type2159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1, global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2>? Type2160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1? Type2161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1Plan? Type2162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2? Type2163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrg? Type2164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan? Type2165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole? Type2166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie>? Type2167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie? Type2168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLeaderboardResponseItem>? Type2169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItem? Type2170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant1, global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2>? Type2171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant1? Type2172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant1Plan? Type2173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2? Type2174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrg? Type2175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan? Type2176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole? Type2177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSource? Type2178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant1? Type2179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan? Type2180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2? Type2181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrg? Type2182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan? Type2183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole? Type2184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsJwtResponse? Type2185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsJwtResponseEncryptedToken? Type2186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesJwtResponse? Type2187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesJwtResponseEncryptedToken? Type2188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsJwtResponse? Type2189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsJwtResponseEncryptedToken? Type2190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetAgentHarnessesResponse? Type2191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetAgentHarnessesResponseHarnesses2>? Type2192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetAgentHarnessesResponseHarnesses2? Type2193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTagsByTypeResponseItem>>? Type2194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTagsByTypeResponseItem>? Type2195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTagsByTypeResponseItem? Type2196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsTagsByTypeResponseItemType? Type2197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>>? Type2198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>? Type2199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTagsByTypeResponseItem? Type2200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsTagsByTypeResponseItemType? Type2201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponse? Type2202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1? Type2203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoData? Type2204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfo? Type2205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoViewer? Type2206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie>? Type2207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie? Type2208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat>? Type2209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat? Type2210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie>? Type2211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie? Type2212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated?>? Type2213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated? Type2214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataResourceGroup? Type2215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2? Type2216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoData? Type2217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProvider>? Type2218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProvider? Type2219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProvider? Type2220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderProviderStatus? Type2221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderModelStatus? Type2222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderTask? Type2223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProviderFeatures? Type2224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated?>? Type2225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated? Type2226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataResourceGroup? Type2227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1? Type2228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan? Type2229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2? Type2230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrg? Type2231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgPlan? Type2232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole? Type2233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3? Type2234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoData? Type2235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataSdk? Type2236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntime? Type2237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStage? Type2238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardware? Type2239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareCurrent? Type2240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHardwareRequested? Type2241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeReplicas? Type2242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<double?, string>? Type2243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain>? Type2244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain? Type2245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomainStage? Type2246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeHotReloading? Type2247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? Type2248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepo? Type2249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1? Type2250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan? Type2251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2? Type2252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrg? Type2253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan? Type2254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole? Type2255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataResourceGroup? Type2256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant1? Type2257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant1Plan? Type2258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2? Type2259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrg? Type2260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan? Type2261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole? Type2262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility? Type2263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponse? Type2264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseDataset>? Type2265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseDataset? Type2266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseModel>? Type2267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseModel? Type2268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseOrg>? Type2269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseOrg? Type2270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseSpace>? Type2271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseSpace? Type2272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseUser>? Type2273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseUser? Type2274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponsePaper>? Type2275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponsePaper? Type2276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseCollection>? Type2277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseCollection? Type2278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseBucket>? Type2279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseBucket? Type2280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseContainer>? Type2281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseContainer? Type2282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseKernel>? Type2283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseKernel? Type2284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseBlog>? Type2285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetQuicksearchResponseBlog? Type2286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponse? Type2287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseDataset>? Type2288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseDataset? Type2289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseModel>? Type2290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseModel? Type2291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseOrg>? Type2292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseOrg? Type2293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseSpace>? Type2294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseSpace? Type2295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseUser>? Type2296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseUser? Type2297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponsePaper>? Type2298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponsePaper? Type2299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseCollection>? Type2300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseCollection? Type2301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseBucket>? Type2302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseBucket? Type2303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseContainer>? Type2304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseContainer? Type2305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseKernel>? Type2306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseKernel? Type2307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseBlog>? Type2308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateQuicksearchResponseBlog? Type2309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesHardwareResponseItem>? Type2310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesHardwareResponseItem? Type2311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesHardwareResponseItemAccelerator? Type2312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorType? Type2313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorManufacturer? Type2314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTemplatesResponse? Type2315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTemplatesResponseTemplate>? Type2316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTemplatesResponseTemplate? Type2317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk? Type2318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesZeroGpuQuotaResponse? Type2319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesZeroGpuQuotaResponseRuns? Type2320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetSpacesSecretsResponse2>? Type2321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesSecretsResponse2? Type2322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetSpacesVariablesResponse2>? Type2323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesVariablesResponse2? Type2324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDuplicateResponse? Type2325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDuplicateStatusResponse? Type2326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateResponse? Type2327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateReposCreateResponse2? Type2328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSqlConsoleEmbedResponse? Type2329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchSqlConsoleEmbedResponseView>? Type2330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchSqlConsoleEmbedResponseView? Type2331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.DeleteSqlConsoleEmbedResponse? Type2332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedResponse? Type2333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateSqlConsoleEmbedResponseView>? Type2334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateSqlConsoleEmbedResponseView? Type2335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetSpacesResolveResponse? Type2336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsResolveResponse? Type2337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetResolveResponse? Type2338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetResolveCacheSpacesResponse? Type2339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetResolveCacheDatasetsResponse? Type2340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetResolveCacheModelsResponse? Type2341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsUserAccessRequestResponseItem>? Type2342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItem? Type2343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemUser? Type2344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsUserAccessRequestResponseItemUserOrg>? Type2345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemUserOrg? Type2346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemUserServiceAccount? Type2347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1? Type2348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1Org>? Type2349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1Org? Type2350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1ServiceAccount? Type2351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant2? Type2352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetModelsUserAccessRequestResponseItemStatus? Type2353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsUserAccessRequestResponseItem>? Type2354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItem? Type2355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUser? Type2356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUserOrg>? Type2357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUserOrg? Type2358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUserServiceAccount? Type2359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1? Type2360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1Org>? Type2361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1Org? Type2362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1ServiceAccount? Type2363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant2? Type2364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDatasetsUserAccessRequestResponseItemStatus? Type2365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem>? Type2366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem? Type2367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItemError? Type2368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDatasetsUserAccessRequestBatchResponseItem>? Type2369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchResponseItem? Type2370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateDatasetsUserAccessRequestBatchResponseItemError? Type2371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItem>? Type2372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItem? Type2373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemPaper? Type2374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItemPaperAuthor>? Type2375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemPaperAuthor? Type2376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemPaperAuthorUser? Type2377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemPaperSubmittedOnDailyBy? Type2378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetDailyPapersResponseItemSubmittedBy? Type2379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseItem>? Type2380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseItem? Type2381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseItemAuthor>? Type2382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseItemAuthor? Type2383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseItemAuthorUser? Type2384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseItemOrganization? Type2385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersIndexResponse? Type2386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponse? Type2387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseAuthor>? Type2388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseAuthor? Type2389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseAuthorUser? Type2390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseSubmittedOnDailyBy? Type2391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedModel>? Type2392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModel? Type2393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProvider>? Type2394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProvider? Type2395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider? Type2396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus? Type2397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus? Type2398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask? Type2399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderFeatures? Type2400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetPapersResponseLinkedModelGated?>? Type2401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelGated? Type2402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelResourceGroup? Type2403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1, global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2>? Type2404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1? Type2405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan? Type2406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2? Type2407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrg? Type2408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan? Type2409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole? Type2410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDataset>? Type2411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDataset? Type2412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfo? Type2413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer? Type2414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie>? Type2415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie? Type2416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat>? Type2417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat? Type2418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie>? Type2419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie? Type2420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetPapersResponseLinkedDatasetGated?>? Type2421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetGated? Type2422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedDatasetResourceGroup? Type2423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedSpace>? Type2424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseLinkedSpace? Type2425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseComment>? Type2426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseComment? Type2427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseCommentAuthorVariant1, global::HuggingFace.GetPapersResponseCommentAuthorVariant2>? Type2428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant1? Type2429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant1OauthApp? Type2430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant1OauthAppImageData? Type2431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant1Plan? Type2432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2? Type2433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2OauthApp? Type2434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2OauthAppImageData? Type2435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrg? Type2436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan? Type2437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole? Type2438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentData? Type2439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataHiddenReason? Type2440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatest? Type2441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1, global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2>? Type2442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1? Type2443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1Plan? Type2444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2? Type2445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrg? Type2446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan? Type2447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole? Type2448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseCommentDataReaction>? Type2449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataReaction? Type2450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataReactionReaction? Type2451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetPapersResponseCommentDataIdentifiedLanguage? Type2452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponse? Type2453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessage? Type2454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1, global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2>? Type2455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1? Type2456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1OauthApp? Type2457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1OauthAppImageData? Type2458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant1Plan? Type2459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2? Type2460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2OauthApp? Type2461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2OauthAppImageData? Type2462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrg? Type2463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageData? Type2466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataHiddenReason? Type2467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatest? Type2468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1? Type2469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant1Plan? Type2470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2? Type2471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreatePapersCommentResponseNewMessageDataReaction>? Type2475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataReaction? Type2476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataReactionReaction? Type2477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentResponseNewMessageDataIdentifiedLanguage? Type2478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponse? Type2479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessage? Type2480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1? Type2481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1OauthApp? Type2482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1OauthAppImageData? Type2483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant1Plan? Type2484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2? Type2485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2OauthApp? Type2486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2OauthAppImageData? Type2487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrg? Type2488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageData? Type2491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataHiddenReason? Type2492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatest? Type2493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1? Type2494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan? Type2495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2? Type2496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataReaction>? Type2500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataReaction? Type2501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataReactionReaction? Type2502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataIdentifiedLanguage? Type2503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePapersLinksResponse? Type2504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponse? Type2505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessage? Type2506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1, global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2>? Type2507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1? Type2508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1OauthApp? Type2509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1OauthAppImageData? Type2510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant1Plan? Type2511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2? Type2512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2OauthApp? Type2513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2OauthAppImageData? Type2514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrg? Type2515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageData? Type2518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataHiddenReason? Type2519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatest? Type2520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1? Type2521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant1Plan? Type2522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2? Type2523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreatePostsCommentResponseNewMessageDataReaction>? Type2527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataReaction? Type2528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataReactionReaction? Type2529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentResponseNewMessageDataIdentifiedLanguage? Type2530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponse? Type2531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessage? Type2532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant1? Type2533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant1OauthApp? Type2534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant1OauthAppImageData? Type2535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant1Plan? Type2536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2? Type2537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2OauthApp? Type2538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2OauthAppImageData? Type2539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrg? Type2540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgPlan? Type2541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole? Type2542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageData? Type2543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataHiddenReason? Type2544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatest? Type2545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1? Type2546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant1Plan? Type2547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2? Type2548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrg? Type2549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? Type2550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? Type2551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataReaction>? Type2552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataReaction? Type2553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataReactionReaction? Type2554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataIdentifiedLanguage? Type2555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponse? Type2556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3>?>? Type2557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3>? Type2558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant2? Type2559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3? Type2560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3Notifications? Type2561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3NotificationsMode? Type2562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseOwnerVariant1, global::HuggingFace.GetCollectionsResponseOwnerVariant2>? Type2563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant1? Type2564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant1Plan? Type2565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2? Type2566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrg? Type2567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrgPlan? Type2568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole? Type2569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseTheme? Type2570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseResourceGroup? Type2571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1? Type2572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1Note? Type2573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfo? Type2574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoViewer? Type2575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie>? Type2576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie? Type2577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat>? Type2578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat? Type2579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie>? Type2580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie? Type2581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseItemVariant1Gated?>? Type2582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1Gated? Type2583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1ResourceGroup? Type2584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2? Type2585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2Note? Type2586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider>? Type2587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider? Type2588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider? Type2589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus? Type2590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus? Type2591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderTask? Type2592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderFeatures? Type2593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseItemVariant2Gated?>? Type2594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2Gated? Type2595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2ResourceGroup? Type2596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant1, global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2>? Type2597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant1? Type2598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant1Plan? Type2599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2? Type2600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrg? Type2601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type2602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type2603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3? Type2604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Note? Type2605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Sdk? Type2606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Runtime? Type2607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeStage? Type2608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardware? Type2609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardwareCurrent? Type2610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardwareRequested? Type2611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeReplicas? Type2612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain>? Type2613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain? Type2614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomainStage? Type2615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHotReloading? Type2616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepo? Type2617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1? Type2618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan? Type2619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2? Type2620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type2621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type2622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type2623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3ResourceGroup? Type2624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant1, global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2>? Type2625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant1? Type2626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant1Plan? Type2627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2? Type2628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrg? Type2629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type2630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type2631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Visibility? Type2632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant4? Type2633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant4Note? Type2634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5? Type2635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5Note? Type2636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant1, global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2>? Type2637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant1? Type2638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant1Plan? Type2639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2? Type2640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrg? Type2641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan? Type2642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole? Type2643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5Theme? Type2644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6? Type2645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6Note? Type2646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6RepoType? Type2647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6Disabled? Type2648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion>? Type2649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion? Type2650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegionProvider? Type2651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegionRegion? Type2652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6ResourceGroup? Type2653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponse? Type2654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseData? Type2655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant2, global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3>? Type2656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant2? Type2657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3? Type2658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3Notifications? Type2659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3NotificationsMode? Type2660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.PatchCollectionsResponseDataOwnerVariant1, global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2>? Type2661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant1? Type2662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant1Plan? Type2663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2? Type2664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrg? Type2665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan? Type2666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole? Type2667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataTheme? Type2668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataResourceGroup? Type2669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1? Type2670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1Note? Type2671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfo? Type2672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer? Type2673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie>? Type2674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie? Type2675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat>? Type2676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat? Type2677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie>? Type2678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie? Type2679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataItemVariant1Gated?>? Type2680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1Gated? Type2681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1ResourceGroup? Type2682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2? Type2683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2Note? Type2684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider>? Type2685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider? Type2686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider? Type2687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus? Type2688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus? Type2689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask? Type2690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderFeatures? Type2691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataItemVariant2Gated?>? Type2692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2Gated? Type2693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2ResourceGroup? Type2694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant1? Type2695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan? Type2696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2? Type2697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrg? Type2698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type2699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type2700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3? Type2701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Note? Type2702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Sdk? Type2703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Runtime? Type2704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStage? Type2705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardware? Type2706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent? Type2707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareRequested? Type2708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeReplicas? Type2709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain>? Type2710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain? Type2711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomainStage? Type2712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHotReloading? Type2713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepo? Type2714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1? Type2715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan? Type2716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2? Type2717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type2718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type2719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type2720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3ResourceGroup? Type2721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant1? Type2722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan? Type2723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2? Type2724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrg? Type2725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type2726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type2727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Visibility? Type2728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant4? Type2729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant4Note? Type2730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5? Type2731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5Note? Type2732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1, global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2>? Type2733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1? Type2734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1Plan? Type2735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2? Type2736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrg? Type2737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan? Type2738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole? Type2739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5Theme? Type2740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6? Type2741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6Note? Type2742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6RepoType? Type2743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6Disabled? Type2744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion>? Type2745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion? Type2746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionProvider? Type2747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionRegion? Type2748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6ResourceGroup? Type2749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponse2? Type2750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant22, global::HuggingFace.GetCollectionsResponseGatingVariant2Variant32>? Type2751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant22? Type2752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant32? Type2753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3Notifications2? Type2754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseGatingVariant2Variant3NotificationsMode2? Type2755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseOwnerVariant12, global::HuggingFace.GetCollectionsResponseOwnerVariant22>? Type2756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant12? Type2757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant1Plan2? Type2758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant22? Type2759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrg2? Type2760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrgPlan2? Type2761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseOwnerVariant2PrimaryOrgUserRole2? Type2762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseTheme2? Type2763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseResourceGroup2? Type2764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant12? Type2765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1Note2? Type2766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfo2? Type2767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoViewer2? Type2768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2>? Type2769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2? Type2770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2>? Type2771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2? Type2772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2>? Type2773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2? Type2774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseItemVariant1Gated2?>? Type2775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1Gated2? Type2776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant1ResourceGroup2? Type2777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant22? Type2778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2Note2? Type2779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider2>? Type2780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider2? Type2781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderProvider2? Type2782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus2? Type2783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus2? Type2784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderTask2? Type2785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProviderFeatures2? Type2786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseItemVariant2Gated2?>? Type2787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2Gated2? Type2788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2ResourceGroup2? Type2789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant12, global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant22>? Type2790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant12? Type2791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant1Plan2? Type2792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant22? Type2793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrg2? Type2794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2? Type2795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2? Type2796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant32? Type2797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Note2? Type2798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Sdk2? Type2799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Runtime2? Type2800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeStage2? Type2801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardware2? Type2802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardwareCurrent2? Type2803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHardwareRequested2? Type2804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeReplicas2? Type2805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain2>? Type2806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain2? Type2807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomainStage2? Type2808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeHotReloading2? Type2809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepo2? Type2810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant12? Type2811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan2? Type2812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant22? Type2813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg2? Type2814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2? Type2815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? Type2816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3ResourceGroup2? Type2817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant12, global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant22>? Type2818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant12? Type2819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant1Plan2? Type2820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant22? Type2821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrg2? Type2822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan2? Type2823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole2? Type2824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant3Visibility2? Type2825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant42? Type2826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant4Note2? Type2827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant52? Type2828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5Note2? Type2829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant12, global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant22>? Type2830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant12? Type2831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant1Plan2? Type2832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant22? Type2833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrg2? Type2834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan2? Type2835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2? Type2836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant5Theme2? Type2837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant62? Type2838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6Note2? Type2839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6RepoType2? Type2840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6Disabled2? Type2841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion2>? Type2842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion2? Type2843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegionProvider2? Type2844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegionRegion2? Type2845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseItemVariant6ResourceGroup2? Type2846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponse2? Type2847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseData2? Type2848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant22? Type2849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant32? Type2850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3Notifications2? Type2851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataGatingVariant2Variant3NotificationsMode2? Type2852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.PatchCollectionsResponseDataOwnerVariant12, global::HuggingFace.PatchCollectionsResponseDataOwnerVariant22>? Type2853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant12? Type2854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant1Plan2? Type2855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant22? Type2856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrg2? Type2857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2? Type2858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataOwnerVariant2PrimaryOrgUserRole2? Type2859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataTheme2? Type2860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataResourceGroup2? Type2861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant12? Type2862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1Note2? Type2863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfo2? Type2864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoViewer2? Type2865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2>? Type2866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2? Type2867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2>? Type2868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2? Type2869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2>? Type2870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2? Type2871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataItemVariant1Gated2?>? Type2872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1Gated2? Type2873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant1ResourceGroup2? Type2874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant22? Type2875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2Note2? Type2876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider2>? Type2877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider2? Type2878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProvider2? Type2879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderProviderStatus2? Type2880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderModelStatus2? Type2881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderTask2? Type2882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProviderFeatures2? Type2883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PatchCollectionsResponseDataItemVariant2Gated2?>? Type2884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2Gated2? Type2885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2ResourceGroup2? Type2886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant12? Type2887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2? Type2888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant22? Type2889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrg2? Type2890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgPlan2? Type2891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2? Type2892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant32? Type2893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Note2? Type2894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Sdk2? Type2895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Runtime2? Type2896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeStage2? Type2897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardware2? Type2898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareCurrent2? Type2899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHardwareRequested2? Type2900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeReplicas2? Type2901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain2>? Type2902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain2? Type2903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomainStage2? Type2904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeHotReloading2? Type2905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepo2? Type2906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant12? Type2907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant1Plan2? Type2908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant22? Type2909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrg2? Type2910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2? Type2911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? Type2912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3ResourceGroup2? Type2913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant12? Type2914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant1Plan2? Type2915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant22? Type2916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrg2? Type2917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgPlan2? Type2918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole2? Type2919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant3Visibility2? Type2920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant42? Type2921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant4Note2? Type2922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant52? Type2923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5Note2? Type2924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant12? Type2925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant1Plan2? Type2926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant22? Type2927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrg2? Type2928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2? Type2929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2? Type2930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant5Theme2? Type2931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant62? Type2932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6Note2? Type2933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6RepoType2? Type2934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6Disabled2? Type2935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion2>? Type2936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion2? Type2937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionProvider2? Type2938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegionRegion2? Type2939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PatchCollectionsResponseDataItemVariant6ResourceGroup2? Type2940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponse? Type2941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2? Type2942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3? Type2943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3Notifications? Type2944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode? Type2945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant1, global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2>? Type2946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant1? Type2947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant1Plan? Type2948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2? Type2949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrg? Type2950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan? Type2951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole? Type2952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseTheme? Type2953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseResourceGroup? Type2954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1? Type2955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Note? Type2956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfo? Type2957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer? Type2958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie>? Type2959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie? Type2960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat>? Type2961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat? Type2962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie>? Type2963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie? Type2964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated?>? Type2965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated? Type2966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1ResourceGroup? Type2967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2? Type2968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Note? Type2969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider>? Type2970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider? Type2971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider? Type2972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus? Type2973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus? Type2974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask? Type2975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderFeatures? Type2976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Gated?>? Type2977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Gated? Type2978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2ResourceGroup? Type2979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1? Type2980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan? Type2981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2? Type2982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrg? Type2983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type2984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type2985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3? Type2986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Note? Type2987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Sdk? Type2988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Runtime? Type2989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeStage? Type2990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardware? Type2991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent? Type2992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardwareRequested? Type2993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeReplicas? Type2994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain>? Type2995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain? Type2996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage? Type2997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHotReloading? Type2998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepo? Type2999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1? Type3000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan? Type3001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2? Type3002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type3003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type3004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type3005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3ResourceGroup? Type3006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1? Type3007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan? Type3008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2? Type3009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrg? Type3010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type3011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type3012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Visibility? Type3013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant4? Type3014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant4Note? Type3015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5? Type3016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5Note? Type3017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant1? Type3018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant1Plan? Type3019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2? Type3020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrg? Type3021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan? Type3022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole? Type3023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5Theme? Type3024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6? Type3025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6Note? Type3026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6RepoType? Type3027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6Disabled? Type3028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion>? Type3029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion? Type3030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegionProvider? Type3031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegionRegion? Type3032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6ResourceGroup? Type3033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponse2? Type3034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant22? Type3035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant32? Type3036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3Notifications2? Type3037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3NotificationsMode2? Type3038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant12, global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant22>? Type3039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant12? Type3040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant1Plan2? Type3041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant22? Type3042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrg2? Type3043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgPlan2? Type3044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2? Type3045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseTheme2? Type3046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseResourceGroup2? Type3047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant12? Type3048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Note2? Type3049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfo2? Type3050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoViewer2? Type3051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2>? Type3052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2? Type3053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2>? Type3054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2? Type3055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2>? Type3056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2? Type3057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated2?>? Type3058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1Gated2? Type3059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant1ResourceGroup2? Type3060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant22? Type3061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Note2? Type3062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider2>? Type3063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider2? Type3064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProvider2? Type3065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderProviderStatus2? Type3066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderModelStatus2? Type3067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderTask2? Type3068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProviderFeatures2? Type3069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Gated2?>? Type3070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2Gated2? Type3071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2ResourceGroup2? Type3072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant12? Type3073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan2? Type3074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant22? Type3075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrg2? Type3076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan2? Type3077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2? Type3078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant32? Type3079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Note2? Type3080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Sdk2? Type3081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Runtime2? Type3082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeStage2? Type3083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardware2? Type3084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardwareCurrent2? Type3085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHardwareRequested2? Type3086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeReplicas2? Type3087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain2>? Type3088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain2? Type3089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomainStage2? Type3090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeHotReloading2? Type3091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepo2? Type3092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant12? Type3093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant1Plan2? Type3094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant22? Type3095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg2? Type3096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2? Type3097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? Type3098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3ResourceGroup2? Type3099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant12? Type3100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan2? Type3101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant22? Type3102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrg2? Type3103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan2? Type3104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole2? Type3105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant3Visibility2? Type3106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant42? Type3107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant4Note2? Type3108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant52? Type3109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5Note2? Type3110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant12? Type3111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant1Plan2? Type3112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant22? Type3113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrg2? Type3114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgPlan2? Type3115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole2? Type3116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant5Theme2? Type3117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant62? Type3118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6Note2? Type3119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6RepoType2? Type3120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6Disabled2? Type3121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion2>? Type3122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion2? Type3123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegionProvider2? Type3124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegionRegion2? Type3125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsItemsResponseItemVariant6ResourceGroup2? Type3126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponse? Type3127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant2, global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3>? Type3128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant2? Type3129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3? Type3130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3Notifications? Type3131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3NotificationsMode? Type3132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateCollectionsResponseOwnerVariant1, global::HuggingFace.CreateCollectionsResponseOwnerVariant2>? Type3133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant1? Type3134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant1Plan? Type3135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant2? Type3136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant2PrimaryOrg? Type3137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant2PrimaryOrgPlan? Type3138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseOwnerVariant2PrimaryOrgUserRole? Type3139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseTheme? Type3140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseResourceGroup? Type3141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1? Type3142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1Note? Type3143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfo? Type3144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoViewer? Type3145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie>? Type3146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie? Type3147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat>? Type3148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat? Type3149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie>? Type3150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie? Type3151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsResponseItemVariant1Gated?>? Type3152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1Gated? Type3153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant1ResourceGroup? Type3154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2? Type3155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2Note? Type3156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProvider>? Type3157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProvider? Type3158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderProvider? Type3159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderProviderStatus? Type3160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderModelStatus? Type3161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderTask? Type3162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProviderFeatures? Type3163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.CreateCollectionsResponseItemVariant2Gated?>? Type3164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2Gated? Type3165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2ResourceGroup? Type3166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant1? Type3167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan? Type3168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2? Type3169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrg? Type3170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type3171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type3172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3? Type3173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3Note? Type3174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3Sdk? Type3175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3Runtime? Type3176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeStage? Type3177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHardware? Type3178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHardwareCurrent? Type3179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHardwareRequested? Type3180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeReplicas? Type3181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomain>? Type3182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomain? Type3183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomainStage? Type3184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeHotReloading? Type3185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepo? Type3186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1? Type3187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant1Plan? Type3188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2? Type3189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type3190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type3191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type3192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3ResourceGroup? Type3193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant1? Type3194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant1Plan? Type3195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant2? Type3196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrg? Type3197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type3198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type3199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant3Visibility? Type3200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant4? Type3201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant4Note? Type3202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5? Type3203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5Note? Type3204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant1, global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2>? Type3205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant1? Type3206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant1Plan? Type3207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2? Type3208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrg? Type3209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan? Type3210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgUserRole? Type3211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant5Theme? Type3212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6? Type3213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6Note? Type3214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6RepoType? Type3215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6Disabled? Type3216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegion>? Type3217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegion? Type3218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegionProvider? Type3219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegionRegion? Type3220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponseItemVariant6ResourceGroup? Type3221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResponse2? Type3222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1Item>, global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant2Item>>? Type3223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1Item>? Type3224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1Item? Type3225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant2? Type3226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant3? Type3227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant3Notifications? Type3228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemGatingVariant2Variant3NotificationsMode? Type3229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.OneOf<global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant1, global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2>? Type3230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant1? Type3231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant1Plan? Type3232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2? Type3233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrg? Type3234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgPlan? Type3235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole? Type3236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemTheme? Type3237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemResourceGroup? Type3238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1? Type3239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1Note? Type3240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfo? Type3241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoViewer? Type3242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie>? Type3243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie? Type3244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat>? Type3245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat? Type3246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie>? Type3247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie? Type3248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1Gated?>? Type3249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1Gated? Type3250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1ResourceGroup? Type3251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2? Type3252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2Note? Type3253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProvider>? Type3254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProvider? Type3255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProvider? Type3256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderProviderStatus? Type3257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderModelStatus? Type3258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderTask? Type3259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProviderFeatures? Type3260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2Gated?>? Type3261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2Gated? Type3262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2ResourceGroup? Type3263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant1? Type3264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant1Plan? Type3265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant2? Type3266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant2PrimaryOrg? Type3267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant2PrimaryOrgPlan? Type3268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AuthorDataVariant2PrimaryOrgUserRole? Type3269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3? Type3270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3Note? Type3271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3Sdk? Type3272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3Runtime? Type3273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeStage? Type3274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeHardware? Type3275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeHardwareCurrent? Type3276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeHardwareRequested? Type3277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeReplicas? Type3278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomain>? Type3279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomain? Type3280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomainStage? Type3281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeHotReloading? Type3282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepo? Type3283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant1? Type3284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant1Plan? Type3285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2? Type3286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrg? Type3287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? Type3288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? Type3289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3ResourceGroup? Type3290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant1? Type3291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant1Plan? Type3292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant2? Type3293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant2PrimaryOrg? Type3294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant2PrimaryOrgPlan? Type3295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3AuthorDataVariant2PrimaryOrgUserRole? Type3296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3Visibility? Type3297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant4? Type3298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant4Note? Type3299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5? Type3300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5Note? Type3301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant1? Type3302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant1Plan? Type3303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2? Type3304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrg? Type3305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgPlan? Type3306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5OwnerVariant2PrimaryOrgUserRole? Type3307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant5Theme? Type3308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6? Type3309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6Note? Type3310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6RepoType? Type3311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6Disabled? Type3312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegion>? Type3313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegion? Type3314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegionProvider? Type3315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegionRegion? Type3316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6ResourceGroup? Type3317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetCollectionsResponseVariant2Item>? Type3318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant2Item? Type3319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResponseVariant2ItemResourceGroup? Type3320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResourceGroupResponse? Type3321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResourceGroupResponse? Type3322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetCollectionsResourceGroupResponse2? Type3323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateCollectionsResourceGroupResponse2? Type3324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResponse? Type3325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsResponse2? Type3326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponse? Type3327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseRepoType? Type3328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseDisabled? Type3329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsResponseCdnRegion>? Type3330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseCdnRegion? Type3331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseCdnRegionProvider? Type3332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseCdnRegionRegion? Type3333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseResourceGroup? Type3334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersResponse? Type3335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersResponse2? Type3336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponse? Type3337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseRepoType? Type3338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseDisabled? Type3339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetContainersResponseCdnRegion>? Type3340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseCdnRegion? Type3341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseCdnRegionProvider? Type3342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseCdnRegionRegion? Type3343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseResourceGroup? Type3344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsResponse? Type3345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutBucketsSettingsResponseCdnRegion>? Type3346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsResponseCdnRegion? Type3347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsResponseCdnRegionProvider? Type3348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutBucketsSettingsResponseCdnRegionRegion? Type3349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsResponse? Type3350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsResponseCdnRegion>? Type3351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsResponseCdnRegion? Type3352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider? Type3353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion? Type3354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsResponseItem>? Type3355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItem? Type3356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemRepoType? Type3357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemDisabled? Type3358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsResponseItemCdnRegion>? Type3359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemCdnRegion? Type3360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemCdnRegionProvider? Type3361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemCdnRegionRegion? Type3362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResponseItemResourceGroup? Type3363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetContainersResponseItem>? Type3364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItem? Type3365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemRepoType? Type3366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemDisabled? Type3367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetContainersResponseItemCdnRegion>? Type3368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemCdnRegion? Type3369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemCdnRegionProvider? Type3370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemCdnRegionRegion? Type3371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResponseItemResourceGroup? Type3372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResolveResponse? Type3373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResolveResponse3? Type3374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsResolveResponse4? Type3375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResolveResponse? Type3376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResolveResponse3? Type3377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersResolveResponse4? Type3378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsBatchResponse? Type3379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsBatchResponseFailedItem>? Type3380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsBatchResponseFailedItem? Type3381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsBatchResponse2? Type3382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsBatchResponseFailedItem2>? Type3383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsBatchResponseFailedItem2? Type3384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersBatchResponse? Type3385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersBatchResponseFailedItem>? Type3386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersBatchResponseFailedItem? Type3387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersBatchResponse2? Type3388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersBatchResponseFailedItem2>? Type3389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersBatchResponseFailedItem2? Type3390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsTreeResponseItem>? Type3391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsTreeResponseItem? Type3392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsTreeResponseItemType? Type3393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetContainersTreeResponseItem>? Type3394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersTreeResponseItem? Type3395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetContainersTreeResponseItemType? Type3396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetBucketsEventsResponse? Type3397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsPathsInfoResponseItem>? Type3398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsPathsInfoResponseItem? Type3399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateBucketsPathsInfoResponseItemType? Type3400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersPathsInfoResponseItem>? Type3401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersPathsInfoResponseItem? Type3402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateContainersPathsInfoResponseItemType? Type3403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsHardwareResponseItem>? Type3404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsHardwareResponseItem? Type3405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsHardwareResponseItemAccelerator? Type3406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType? Type3407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer? Type3408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsResponseItem>? Type3409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItem? Type3410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemArch? Type3411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemFlavor? Type3412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemCreatedBy? Type3413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemDurations? Type3414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsResponseItemVolume>? Type3415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemVolume? Type3416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemExpose? Type3417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemNetwork? Type3418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemOwner? Type3419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemOwnerType? Type3420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemResourceGroup? Type3421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant1? Type3422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant1Type? Type3423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant2? Type3424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant3? Type3425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemInitiatorVariant4? Type3426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemStatus? Type3427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemStatusStage? Type3428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsResponseItemStatusCancelReason?, string>? Type3429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemStatusCancelReason? Type3430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemHfToken? Type3431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseItemHfTokenTokenRole? Type3432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponse? Type3433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseArch? Type3434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseFlavor? Type3435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseCreatedBy? Type3436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseDurations? Type3437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsResponseVolume>? Type3438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseVolume? Type3439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseExpose? Type3440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseNetwork? Type3441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseOwner? Type3442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseOwnerType? Type3443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseResourceGroup? Type3444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant1? Type3445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant1Type? Type3446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant2? Type3447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant3? Type3448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseInitiatorVariant4? Type3449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseStatus? Type3450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseStatusStage? Type3451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsResponseStatusCancelReason?, string>? Type3452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseStatusCancelReason? Type3453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseHfToken? Type3454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsResponseHfTokenTokenRole? Type3455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsCountResponse? Type3456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponse? Type3457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseArch? Type3458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseFlavor? Type3459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseCreatedBy? Type3460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseDurations? Type3461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetJobsResponseVolume>? Type3462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseVolume? Type3463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseExpose? Type3464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseNetwork? Type3465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseOwner? Type3466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseOwnerType? Type3467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseResourceGroup? Type3468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant1? Type3469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant1Type? Type3470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant2? Type3471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant3? Type3472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseInitiatorVariant4? Type3473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseStatus? Type3474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseStatusStage? Type3475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsResponseStatusCancelReason?, string>? Type3476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseStatusCancelReason? Type3477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseHfToken? Type3478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetJobsResponseHfTokenTokenRole? Type3479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponse? Type3480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseArch? Type3481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseFlavor? Type3482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseCreatedBy? Type3483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseDurations? Type3484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsCancelResponseVolume>? Type3485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseVolume? Type3486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseExpose? Type3487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseNetwork? Type3488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseOwner? Type3489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseOwnerType? Type3490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseResourceGroup? Type3491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant1? Type3492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant1Type? Type3493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant2? Type3494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant3? Type3495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseInitiatorVariant4? Type3496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseStatus? Type3497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseStatusStage? Type3498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsCancelResponseStatusCancelReason?, string>? Type3499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseStatusCancelReason? Type3500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseHfToken? Type3501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsCancelResponseHfTokenTokenRole? Type3502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponse? Type3503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseArch? Type3504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseFlavor? Type3505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseCreatedBy? Type3506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseDurations? Type3507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsDuplicateResponseVolume>? Type3508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseVolume? Type3509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseExpose? Type3510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseNetwork? Type3511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseOwner? Type3512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseOwnerType? Type3513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseResourceGroup? Type3514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant1? Type3515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant1Type? Type3516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant2? Type3517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant3? Type3518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseInitiatorVariant4? Type3519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseStatus? Type3520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseStatusStage? Type3521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateJobsDuplicateResponseStatusCancelReason?, string>? Type3522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseStatusCancelReason? Type3523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseHfToken? Type3524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateJobsDuplicateResponseHfTokenTokenRole? Type3525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponse? Type3526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseArch? Type3527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseFlavor? Type3528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseCreatedBy? Type3529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseDurations? Type3530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutJobsLabelsResponseVolume>? Type3531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseVolume? Type3532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseExpose? Type3533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseNetwork? Type3534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseOwner? Type3535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseOwnerType? Type3536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseResourceGroup? Type3537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant1? Type3538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant1Type? Type3539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant2? Type3540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant3? Type3541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseInitiatorVariant4? Type3542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseStatus? Type3543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseStatusStage? Type3544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutJobsLabelsResponseStatusCancelReason?, string>? Type3545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseStatusCancelReason? Type3546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseHfToken? Type3547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsLabelsResponseHfTokenTokenRole? Type3548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponse? Type3549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseArch? Type3550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseFlavor? Type3551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseCreatedBy? Type3552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseDurations? Type3553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutJobsExposeResponseVolume>? Type3554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseVolume? Type3555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseExpose? Type3556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseNetwork? Type3557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseOwner? Type3558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseOwnerType? Type3559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseResourceGroup? Type3560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant1? Type3561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant1Type? Type3562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant2? Type3563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant3? Type3564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseInitiatorVariant4? Type3565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseStatus? Type3566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseStatusStage? Type3567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.PutJobsExposeResponseStatusCancelReason?, string>? Type3568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseStatusCancelReason? Type3569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseHfToken? Type3570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutJobsExposeResponseHfTokenTokenRole? Type3571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponse? Type3572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseStatus? Type3573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseStatusLastJob? Type3574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseOwner? Type3575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseOwnerType? Type3576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseInitiator? Type3577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseInitiatorType? Type3578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpec? Type3579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecArch? Type3580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecFlavor? Type3581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecDurations? Type3582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsResponseJobSpecVolume>? Type3583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecVolume? Type3584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecExpose? Type3585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecNetwork? Type3586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecResourceGroup? Type3587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecHfToken? Type3588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsResponseJobSpecHfTokenTokenRole? Type3589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetScheduledJobsResponseItem>? Type3590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItem? Type3591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemStatus? Type3592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemStatusLastJob? Type3593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemOwner? Type3594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemOwnerType? Type3595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemInitiator? Type3596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemInitiatorType? Type3597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpec? Type3598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecArch? Type3599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecFlavor? Type3600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecDurations? Type3601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetScheduledJobsResponseItemJobSpecVolume>? Type3602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecVolume? Type3603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecExpose? Type3604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecNetwork? Type3605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecResourceGroup? Type3606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecHfToken? Type3607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseItemJobSpecHfTokenTokenRole? Type3608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponse? Type3609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseStatus? Type3610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseStatusLastJob? Type3611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseOwner? Type3612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseOwnerType? Type3613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseInitiator? Type3614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseInitiatorType? Type3615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpec? Type3616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecArch? Type3617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecFlavor? Type3618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecDurations? Type3619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.GetScheduledJobsResponseJobSpecVolume>? Type3620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecVolume? Type3621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecExpose? Type3622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecNetwork? Type3623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecResourceGroup? Type3624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecHfToken? Type3625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.GetScheduledJobsResponseJobSpecHfTokenTokenRole? Type3626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponse? Type3627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseArch? Type3628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseFlavor? Type3629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseCreatedBy? Type3630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseDurations? Type3631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsRunResponseVolume>? Type3632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseVolume? Type3633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseExpose? Type3634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseNetwork? Type3635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseOwner? Type3636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseOwnerType? Type3637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseResourceGroup? Type3638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant1? Type3639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant1Type? Type3640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant2? Type3641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant3? Type3642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseInitiatorVariant4? Type3643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseStatus? Type3644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseStatusStage? Type3645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateScheduledJobsRunResponseStatusCancelReason?, string>? Type3646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseStatusCancelReason? Type3647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseHfToken? Type3648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponseHfTokenTokenRole? Type3649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsRunResponse2? Type3650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponse? Type3651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseStatus? Type3652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseStatusLastJob? Type3653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseOwner? Type3654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseOwnerType? Type3655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseInitiator? Type3656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseInitiatorType? Type3657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpec? Type3658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecArch? Type3659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecFlavor? Type3660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecDurations? Type3661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecVolume>? Type3662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecVolume? Type3663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecExpose? Type3664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecNetwork? Type3665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecResourceGroup? Type3666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecHfToken? Type3667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole? Type3668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponse? Type3669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseStatus? Type3670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseStatusLastJob? Type3671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseOwner? Type3672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseOwnerType? Type3673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseInitiator? Type3674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseInitiatorType? Type3675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpec? Type3676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecArch? Type3677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecFlavor? Type3678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecDurations? Type3679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecVolume>? Type3680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecVolume? Type3681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecExpose? Type3682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecNetwork? Type3683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecResourceGroup? Type3684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecHfToken? Type3685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecHfTokenTokenRole? Type3686 { get; set; }

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
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequest>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsUserAccessRequestBatchRequestRequest>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutSpacesVolumesRequestVolume>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsBatchRequestItem>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsBatchRequestItem2>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsRequestCdnItem>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateContainersRequestCdnItem>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutBucketsSettingsRequestCdnRegion>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutContainersSettingsRequestCdnRegion>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsRequestVariant1Volume>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsRequestVariant2Volume>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant1Volume>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsRequestJobSpecVariant2Volume>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowersExpandItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsLikersExpandItem>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsLikersExpandItem>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesLikersExpandItem>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsLikersExpandItem>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsCommitsExpandItem>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesCommitsExpandItem>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsCommitsExpandItem>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.List<global::HuggingFace.GetKernelsExpandItem>>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsExpandItem>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.List<string>>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchTypeVariant1Item>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>?>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.List<string>>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchTypeVariant1Item>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.List<string>>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>?>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.List<global::HuggingFace.GetSearchFullTextTypeItem>>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSearchFullTextTypeItem>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesSemanticSearchSdkItem>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetPapersField2?, global::System.Collections.Generic.List<global::HuggingFace.GetPapersFieldItem>>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersFieldItem>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.List<global::HuggingFace.GetJobsStageItem>>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsStageItem>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::HuggingFace.GetJobsCountStage2?, global::System.Collections.Generic.List<global::HuggingFace.GetJobsCountStageItem>>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsCountStageItem>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussionParticipatingItem>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionParticipatingItem>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant3PostParticipatingItem>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant4BlogParticipatingItem>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsMcpResponseSpaceTool>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseItem>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseItemWatchedItem>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseItemDomain>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseWebhookWatchedItem>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsWebhooksResponseWebhookDomain>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem2>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain2>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem3>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain3>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsRepositoriesResponseItem>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsTokensResponseItem>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItem>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsTokensResponseItemFineGrainedScopedItemPermission>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsAuditLogExportResponseItem>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsResourceGroupsResponseUser>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsResourceGroupsResponseUser>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsSettingsResponseUser>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsUsersResponseUser>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.DeleteOrganizationsResourceGroupsUsersResponseUser>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponseUser>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsResourceGroupsResponseItem>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsResourceGroupsResponseItemUser>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsResourceGroupsResponseUser>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseBlockedContent>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponseAllowedContent>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseItem>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessToken>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsMembersResponseItem>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsMembersResponseItemResourceGroup>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponseAuthenticationScheme>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2ResourceTypesResponseItem>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2SchemasResponseItem>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseResource>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceSchema>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseResourceEmail>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2UsersResponseSchema>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2UsersResponseEmail>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseSchema2>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2UsersResponseEmail>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2UsersResponseSchema>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2UsersResponseEmail>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2UsersResponseSchema>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2UsersResponseEmail>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResource>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceSchema>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseResourceMember>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2GroupsResponseSchema>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimV2GroupsResponseMember>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseSchema2>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimV2GroupsResponseMember>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2GroupsResponseSchema>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimV2GroupsResponseMember>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2GroupsResponseSchema>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimV2GroupsResponseMember>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResource>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceSchema>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseResourceEmail>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseSchema>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponseEmail>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseSchema2>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2UsersResponseEmail>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseSchema>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersResponseEmail>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseSchema>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimProvisioningV2UsersResponseEmail>? ListType191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema>? ListType192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResource>? ListType193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceSchema>? ListType194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseResourceMember>? ListType195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseSchema>? ListType196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsScimProvisioningV2GroupsResponseMember>? ListType197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseSchema2>? ListType198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsScimProvisioningV2GroupsResponseMember>? ListType199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseSchema>? ListType200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutOrganizationsScimProvisioningV2GroupsResponseMember>? ListType201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseSchema>? ListType202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsScimProvisioningV2GroupsResponseMember>? ListType203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthRegisterResponseGrantType>? ListType204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseHardwareItem>? ListType205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseOrg>? ListType206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction>? ListType207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup>? ListType208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseHardwareItem>? ListType209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseOrg>? ListType210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction>? ListType211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroup>? ListType212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction>? ListType213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction>? ListType214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBlogCommentResponseNewMessageDataReaction2>? ListType215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBlogCommentReplyResponseNewMessageDataReaction2>? ListType216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDocsResponseItem>? ListType217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDocsSearchResponseItem>? ListType218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDocsSearchFullTextResponseHit>? ListType220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem>? ListType221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem>? ListType222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseOrg>? ListType223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction>? ListType224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup>? ListType225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriod>? ListType226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByResourceGroupResponsePeriodResourceGroup>? ListType227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriod>? ListType228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsBillingUsageByInferenceSessionResponsePeriodSession>? ListType229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriod>? ListType230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriodSession>? ListType231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSettingsBillingUsageJobsResponseUsageJobDetail>? ListType232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersOverviewResponseOrg>? ListType233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersOverviewResponseHardwareItem>? ListType234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersLikesResponseItem>? ListType235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>>? ListType236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowersResponseItemVariant1Org>? ListType237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingResponseItem>? ListType238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingResponseItemOrg>? ListType239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingOrgsResponseItem>? ListType240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain>? ListType241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsLfsFilesResponseItem>? ListType242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsLfsFilesResponseItem>? ListType243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesLfsFilesResponseItem>? ListType244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem>? ListType245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem2>? ListType246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem>? ListType247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem2>? ListType248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem>? ListType249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsLfsFilesDuplicateResponseFailedItem2>? ListType250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem>? ListType251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem2>? ListType252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem>? ListType253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem2>? ListType254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsCommitsResponseItem>? ListType255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsCommitsResponseItemAuthor>? ListType256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesCommitsResponseItem>? ListType257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesCommitsResponseItemAuthor>? ListType258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsCommitsResponseItem>? ListType259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsCommitsResponseItemAuthor>? ListType260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponseTag>? ListType261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponseBranche>? ListType262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponseConvert>? ListType263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponsePullRequest>? ListType264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsRefsResponseTag>? ListType265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsRefsResponseBranche>? ListType266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsRefsResponseConvert>? ListType267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsRefsResponsePullRequest>? ListType268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponseTag>? ListType269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponseBranche>? ListType270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponseConvert>? ListType271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponsePullRequest>? ListType272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItem>? ListType273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? ListType276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItem>? ListType279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? ListType282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItem>? ListType285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>? ListType288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPreuploadResponseFile>? ListType291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPreuploadResponseFile>? ListType292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsPreuploadResponseFile>? ListType293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItem>? ListType294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImport>? ListType297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItem>? ListType300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport>? ListType303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItem>? ListType306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>? ListType307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>? ListType308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImport>? ListType309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>? ListType310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>? ListType311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsScanResponseFilesWithIssue>? ListType312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsScanResponseFilesWithIssue>? ListType313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesScanResponseFilesWithIssue>? ListType314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsScanResponseFilesWithIssue>? ListType315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDiscussionsResponseDiscussion>? ListType316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDiscussionsResponseDiscussionTopReaction>? ListType317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1DataReaction>? ListType318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1DataReaction>? ListType319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<string>, bool?>? ListType320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDiscussionsCommentResponseNewMessageDataReaction>? ListType321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItem>? ListType322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem>? ListType323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO>? ListType324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem>? ListType325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend>? ListType326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType>? ListType327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie>? ListType328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseSupportedDriverFamilie>? ListType329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie>? ListType330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsLeaderboardResponseItem>? ListType331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::HuggingFace.GetModelsTagsByTypeResponseItem>>? ListType332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsTagsByTypeResponseItem>? ListType333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>>? ListType334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>? ListType335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoLibrarie>? ListType336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoFormat>? ListType337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant1RepoDataDatasetsServerInfoModalitie>? ListType338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant2RepoDataAvailableInferenceProvider>? ListType339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeDomain>? ListType340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>? ListType341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseDataset>? ListType342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseModel>? ListType343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseOrg>? ListType344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseSpace>? ListType345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseUser>? ListType346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponsePaper>? ListType347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseCollection>? ListType348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseBucket>? ListType349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseContainer>? ListType350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseKernel>? ListType351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseBlog>? ListType352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseDataset>? ListType353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseModel>? ListType354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseOrg>? ListType355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseSpace>? ListType356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseUser>? ListType357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponsePaper>? ListType358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseCollection>? ListType359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseBucket>? ListType360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseContainer>? ListType361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseKernel>? ListType362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseBlog>? ListType363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesHardwareResponseItem>? ListType364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTemplatesResponseTemplate>? ListType365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchSqlConsoleEmbedResponseView>? ListType366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateSqlConsoleEmbedResponseView>? ListType367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsUserAccessRequestResponseItem>? ListType368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsUserAccessRequestResponseItemUserOrg>? ListType369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetModelsUserAccessRequestResponseItemGrantedByVariant1Org>? ListType370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsUserAccessRequestResponseItem>? ListType371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemUserOrg>? ListType372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDatasetsUserAccessRequestResponseItemGrantedByVariant1Org>? ListType373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem>? ListType374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateDatasetsUserAccessRequestBatchResponseItem>? ListType375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDailyPapersResponseItem>? ListType376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetDailyPapersResponseItemPaperAuthor>? ListType377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseItem>? ListType378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseItemAuthor>? ListType379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseAuthor>? ListType380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedModel>? ListType381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProvider>? ListType382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDataset>? ListType383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie>? ListType384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat>? ListType385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie>? ListType386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedSpace>? ListType387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseComment>? ListType388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseCommentDataReaction>? ListType389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreatePapersCommentResponseNewMessageDataReaction>? ListType390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreatePapersCommentReplyResponseNewMessageDataReaction>? ListType391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreatePostsCommentResponseNewMessageDataReaction>? ListType392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreatePostsCommentReplyResponseNewMessageDataReaction>? ListType393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie>? ListType394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat>? ListType395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie>? ListType396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider>? ListType397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain>? ListType398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion>? ListType399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie>? ListType400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat>? ListType401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie>? ListType402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider>? ListType403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain>? ListType404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion>? ListType405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoLibrarie2>? ListType406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoFormat2>? ListType407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant1DatasetsServerInfoModalitie2>? ListType408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant2AvailableInferenceProvider2>? ListType409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant3RuntimeDomain2>? ListType410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseItemVariant6CdnRegion2>? ListType411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoLibrarie2>? ListType412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoFormat2>? ListType413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant1DatasetsServerInfoModalitie2>? ListType414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant2AvailableInferenceProvider2>? ListType415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant3RuntimeDomain2>? ListType416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PatchCollectionsResponseDataItemVariant6CdnRegion2>? ListType417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie>? ListType418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat>? ListType419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie>? ListType420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider>? ListType421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain>? ListType422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion>? ListType423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoLibrarie2>? ListType424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoFormat2>? ListType425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant1DatasetsServerInfoModalitie2>? ListType426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant2AvailableInferenceProvider2>? ListType427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant3RuntimeDomain2>? ListType428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsItemsResponseItemVariant6CdnRegion2>? ListType429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoLibrarie>? ListType430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoFormat>? ListType431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant1DatasetsServerInfoModalitie>? ListType432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant2AvailableInferenceProvider>? ListType433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant3RuntimeDomain>? ListType434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateCollectionsResponseItemVariant6CdnRegion>? ListType435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1Item>, global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant2Item>>? ListType436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1Item>? ListType437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoLibrarie>? ListType438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoFormat>? ListType439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant1DatasetsServerInfoModalitie>? ListType440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant2AvailableInferenceProvider>? ListType441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant3RuntimeDomain>? ListType442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant1ItemItemVariant6CdnRegion>? ListType443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetCollectionsResponseVariant2Item>? ListType444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetBucketsResponseCdnRegion>? ListType445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetContainersResponseCdnRegion>? ListType446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutBucketsSettingsResponseCdnRegion>? ListType447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutContainersSettingsResponseCdnRegion>? ListType448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetBucketsResponseItem>? ListType449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetBucketsResponseItemCdnRegion>? ListType450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetContainersResponseItem>? ListType451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetContainersResponseItemCdnRegion>? ListType452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsBatchResponseFailedItem>? ListType453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsBatchResponseFailedItem2>? ListType454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateContainersBatchResponseFailedItem>? ListType455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateContainersBatchResponseFailedItem2>? ListType456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetBucketsTreeResponseItem>? ListType457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetContainersTreeResponseItem>? ListType458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsPathsInfoResponseItem>? ListType459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateContainersPathsInfoResponseItem>? ListType460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsHardwareResponseItem>? ListType461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsResponseItem>? ListType462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsResponseItemVolume>? ListType463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsResponseVolume>? ListType464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetJobsResponseVolume>? ListType465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsCancelResponseVolume>? ListType466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateJobsDuplicateResponseVolume>? ListType467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutJobsLabelsResponseVolume>? ListType468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutJobsExposeResponseVolume>? ListType469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsResponseJobSpecVolume>? ListType470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetScheduledJobsResponseItem>? ListType471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetScheduledJobsResponseItemJobSpecVolume>? ListType472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.GetScheduledJobsResponseJobSpecVolume>? ListType473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsRunResponseVolume>? ListType474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.CreateScheduledJobsScheduleResponseJobSpecVolume>? ListType475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::HuggingFace.PutScheduledJobsLabelsResponseJobSpecVolume>? ListType476 { get; set; }
    }
}