
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesBatchRequestDeletions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTargetType), TypeInfoPropertyName = "CreateSpacesLfsFilesDuplicateRequestTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPreuploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPreuploadRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPreuploadRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesBranchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesResourceGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesSuperSquashRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsRequestVisibility), TypeInfoPropertyName = "PutSpacesSettingsRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting), TypeInfoPropertyName = "PutSpacesSettingsRequestDiscussionsSorting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsRequestGated?>), TypeInfoPropertyName = "AnyOfBooleanPutSpacesSettingsRequestGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsRequestGated), TypeInfoPropertyName = "PutSpacesSettingsRequestGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode), TypeInfoPropertyName = "PutSpacesSettingsRequestGatedNotificationsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesSecretsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteSpacesSecretsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesVariablesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteSpacesVariablesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesVolumesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PutSpacesVolumesRequestVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesVolumesRequestVolume))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesVolumesRequestVolumeType), TypeInfoPropertyName = "PutSpacesVolumesRequestVolumeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesHardwareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesHardwareRequestFlavor), TypeInfoPropertyName = "CreateSpacesHardwareRequestFlavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesSleeptimeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesDevModeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesCustomDomainRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesLikersExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLikersExpandItem), TypeInfoPropertyName = "GetSpacesLikersExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesDirection), TypeInfoPropertyName = "GetSpacesLfsFilesDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesSort), TypeInfoPropertyName = "GetSpacesLfsFilesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesCommitsExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesCommitsExpandItem), TypeInfoPropertyName = "GetSpacesCommitsExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesCommitContentType), TypeInfoPropertyName = "CreateSpacesCommitContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLogsLogType), TypeInfoPropertyName = "GetSpacesLogsLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesSemanticSearchCategory), TypeInfoPropertyName = "GetSpacesSemanticSearchCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesSemanticSearchSdkItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesSemanticSearchSdkItem), TypeInfoPropertyName = "GetSpacesSemanticSearchSdkItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreesizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesLfsFilesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusher))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan), TypeInfoPropertyName = "GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole), TypeInfoPropertyName = "GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesCommitsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesCommitsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesCommitsResponseItemAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesCommitsResponseItemAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesCommitsResponseItemFormatted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesRefsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesRefsResponseTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponseBranche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesRefsResponseBranche))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponseConvert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesRefsResponseConvert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesRefsResponsePullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesRefsResponsePullRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemType), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemLfs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemLastCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety), TypeInfoPropertyName = "CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPreuploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPreuploadResponseFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPreuploadResponseFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPreuploadResponseFileUploadMode), TypeInfoPropertyName = "CreateSpacesPreuploadResponseFileUploadMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesXetWriteTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesXetReadTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesCommitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesResourceGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesResourceGroupResponseType), TypeInfoPropertyName = "CreateSpacesResourceGroupResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesResourceGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesSuperSquashResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsResponseVisibility), TypeInfoPropertyName = "PutSpacesSettingsResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsResponseDiscussionsSorting), TypeInfoPropertyName = "PutSpacesSettingsResponseDiscussionsSorting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsResponseGated?>), TypeInfoPropertyName = "AnyOfBooleanPutSpacesSettingsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsResponseGated), TypeInfoPropertyName = "PutSpacesSettingsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsResponseGatedNotificationsMode), TypeInfoPropertyName = "PutSpacesSettingsResponseGatedNotificationsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemType), TypeInfoPropertyName = "GetSpacesTreeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemLfs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemLastCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusStatus), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety), TypeInfoPropertyName = "GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetSpacesNotebookResponseVariant1, global::HuggingFace.GetSpacesNotebookResponseVariant2, global::HuggingFace.GetSpacesNotebookResponseVariant3>), TypeInfoPropertyName = "AnyOfGetSpacesNotebookResponseVariant1GetSpacesNotebookResponseVariant2GetSpacesNotebookResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesNotebookResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesNotebookResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesNotebookResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesScanResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesScanResponseFilesWithIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesScanResponseFilesWithIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel), TypeInfoPropertyName = "GetSpacesScanResponseFilesWithIssueLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesJwtResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesJwtResponseEncryptedToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesHardwareResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesHardwareResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesHardwareResponseItemAccelerator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorType), TypeInfoPropertyName = "GetSpacesHardwareResponseItemAcceleratorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorManufacturer), TypeInfoPropertyName = "GetSpacesHardwareResponseItemAcceleratorManufacturer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTemplatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSpacesTemplatesResponseTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTemplatesResponseTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk), TypeInfoPropertyName = "GetSpacesTemplatesResponseTemplateSdk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesZeroGpuQuotaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesZeroGpuQuotaResponseRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetSpacesSecretsResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesSecretsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::HuggingFace.GetSpacesVariablesResponse2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesVariablesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesResolveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetResolveCacheSpacesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTargetType?), TypeInfoPropertyName = "NullableCreateSpacesLfsFilesDuplicateRequestTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsRequestVisibility?), TypeInfoPropertyName = "NullablePutSpacesSettingsRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting?), TypeInfoPropertyName = "NullablePutSpacesSettingsRequestDiscussionsSorting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsRequestGated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanPutSpacesSettingsRequestGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsRequestGated?), TypeInfoPropertyName = "NullablePutSpacesSettingsRequestGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode?), TypeInfoPropertyName = "NullablePutSpacesSettingsRequestGatedNotificationsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesVolumesRequestVolumeType?), TypeInfoPropertyName = "NullablePutSpacesVolumesRequestVolumeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesHardwareRequestFlavor?), TypeInfoPropertyName = "NullableCreateSpacesHardwareRequestFlavor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLikersExpandItem?), TypeInfoPropertyName = "NullableGetSpacesLikersExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesDirection?), TypeInfoPropertyName = "NullableGetSpacesLfsFilesDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesSort?), TypeInfoPropertyName = "NullableGetSpacesLfsFilesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesCommitsExpandItem?), TypeInfoPropertyName = "NullableGetSpacesCommitsExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesCommitContentType?), TypeInfoPropertyName = "NullableCreateSpacesCommitContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLogsLogType?), TypeInfoPropertyName = "NullableGetSpacesLogsLogType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesSemanticSearchCategory?), TypeInfoPropertyName = "NullableGetSpacesSemanticSearchCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesSemanticSearchSdkItem?), TypeInfoPropertyName = "NullableGetSpacesSemanticSearchSdkItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan?), TypeInfoPropertyName = "NullableGetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole?), TypeInfoPropertyName = "NullableGetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemType?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesPreuploadResponseFileUploadMode?), TypeInfoPropertyName = "NullableCreateSpacesPreuploadResponseFileUploadMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSpacesResourceGroupResponseType?), TypeInfoPropertyName = "NullableCreateSpacesResourceGroupResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsResponseVisibility?), TypeInfoPropertyName = "NullablePutSpacesSettingsResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsResponseDiscussionsSorting?), TypeInfoPropertyName = "NullablePutSpacesSettingsResponseDiscussionsSorting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsResponseGated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanPutSpacesSettingsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsResponseGated?), TypeInfoPropertyName = "NullablePutSpacesSettingsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSpacesSettingsResponseGatedNotificationsMode?), TypeInfoPropertyName = "NullablePutSpacesSettingsResponseGatedNotificationsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemType?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusStatus?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusAvScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetSpacesNotebookResponseVariant1, global::HuggingFace.GetSpacesNotebookResponseVariant2, global::HuggingFace.GetSpacesNotebookResponseVariant3>?), TypeInfoPropertyName = "NullableAnyOfGetSpacesNotebookResponseVariant1GetSpacesNotebookResponseVariant2GetSpacesNotebookResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel?), TypeInfoPropertyName = "NullableGetSpacesScanResponseFilesWithIssueLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorType?), TypeInfoPropertyName = "NullableGetSpacesHardwareResponseItemAcceleratorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorManufacturer?), TypeInfoPropertyName = "NullableGetSpacesHardwareResponseItemAcceleratorManufacturer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk?), TypeInfoPropertyName = "NullableGetSpacesTemplatesResponseTemplateSdk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPreuploadRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PutSpacesVolumesRequestVolume>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesLikersExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesCommitsExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesSemanticSearchSdkItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesLfsFilesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesCommitsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesCommitsResponseItemAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponseBranche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponseConvert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesRefsResponsePullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateSpacesPreuploadResponseFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesScanResponseFilesWithIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesHardwareResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSpacesTemplatesResponseTemplate>))]
    internal sealed partial class SpacesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpacesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SpacesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SpacesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::HuggingFace.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.PutSpacesSettingsRequestGated?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.PutSpacesSettingsResponseGated?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetSpacesNotebookResponseVariant1, global::HuggingFace.GetSpacesNotebookResponseVariant2, global::HuggingFace.GetSpacesNotebookResponseVariant3>());
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
                    typeToConvert == typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTargetType)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTargetType?)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestVisibility)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestVisibility?)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting?)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestGated)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestGated?)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode?)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesVolumesRequestVolumeType)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesVolumesRequestVolumeType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesHardwareRequestFlavor)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesHardwareRequestFlavor?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLikersExpandItem)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLikersExpandItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesDirection)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesDirection?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesSort)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesSort?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesCommitsExpandItem)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesCommitsExpandItem?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesCommitContentType)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesCommitContentType?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLogsLogType)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLogsLogType?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesSemanticSearchCategory)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesSemanticSearchCategory?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesSemanticSearchSdkItem)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesSemanticSearchSdkItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPreuploadResponseFileUploadMode)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesPreuploadResponseFileUploadMode?)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesResourceGroupResponseType)

                    || typeToConvert == typeof(global::HuggingFace.CreateSpacesResourceGroupResponseType?)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseVisibility)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseVisibility?)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseDiscussionsSorting)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseDiscussionsSorting?)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseGated)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseGated?)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseGatedNotificationsMode)

                    || typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseGatedNotificationsMode?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorType)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorType?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorManufacturer)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorManufacturer?)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk)

                    || typeToConvert == typeof(global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTargetType))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesLfsFilesDuplicateRequestTargetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTargetType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesLfsFilesDuplicateRequestTargetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestVisibility))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestVisibility?))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsRequestDiscussionsSortingJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting?))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsRequestDiscussionsSortingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestGated))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsRequestGatedJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestGated?))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsRequestGatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsRequestGatedNotificationsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode?))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsRequestGatedNotificationsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesVolumesRequestVolumeType))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesVolumesRequestVolumeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesVolumesRequestVolumeType?))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesVolumesRequestVolumeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesHardwareRequestFlavor))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesHardwareRequestFlavorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesHardwareRequestFlavor?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesHardwareRequestFlavorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLikersExpandItem))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLikersExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLikersExpandItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLikersExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesDirection))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLfsFilesDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesDirection?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLfsFilesDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesSort))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLfsFilesSortJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesSort?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLfsFilesSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesCommitsExpandItem))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesCommitsExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesCommitsExpandItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesCommitsExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesCommitContentType))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesCommitContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesCommitContentType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesCommitContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLogsLogType))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLogsLogTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLogsLogType?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLogsLogTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesSemanticSearchCategory))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesSemanticSearchCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesSemanticSearchCategory?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesSemanticSearchCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesSemanticSearchSdkItem))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesSemanticSearchSdkItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesSemanticSearchSdkItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesSemanticSearchSdkItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLfsFilesResponseItemPusherPrimaryOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPreuploadResponseFileUploadMode))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPreuploadResponseFileUploadModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesPreuploadResponseFileUploadMode?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesPreuploadResponseFileUploadModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesResourceGroupResponseType))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesResourceGroupResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSpacesResourceGroupResponseType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSpacesResourceGroupResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseVisibility))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsResponseVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseVisibility?))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsResponseVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseDiscussionsSorting))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsResponseDiscussionsSortingJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseDiscussionsSorting?))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsResponseDiscussionsSortingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseGated))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsResponseGatedJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseGated?))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsResponseGatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseGatedNotificationsMode))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsResponseGatedNotificationsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutSpacesSettingsResponseGatedNotificationsMode?))
                {
                    return new global::HuggingFace.JsonConverters.PutSpacesSettingsResponseGatedNotificationsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusAvScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesScanResponseFilesWithIssueLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesScanResponseFilesWithIssueLevel?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesScanResponseFilesWithIssueLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorType))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesHardwareResponseItemAcceleratorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorType?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesHardwareResponseItemAcceleratorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorManufacturer))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesHardwareResponseItemAcceleratorManufacturerJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesHardwareResponseItemAcceleratorManufacturer?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesHardwareResponseItemAcceleratorManufacturerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTemplatesResponseTemplateSdkJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSpacesTemplatesResponseTemplateSdk?))
                {
                    return new global::HuggingFace.JsonConverters.GetSpacesTemplatesResponseTemplateSdkNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SpacesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::HuggingFace.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}