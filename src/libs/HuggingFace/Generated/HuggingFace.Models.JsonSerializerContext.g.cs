
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesBatchRequestDeletions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTargetType), TypeInfoPropertyName = "CreateModelsLfsFilesDuplicateRequestTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPreuploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPreuploadRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPreuploadRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsBranchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsResourceGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsSuperSquashRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsRequestVisibility), TypeInfoPropertyName = "PutModelsSettingsRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsRequestDiscussionsSorting), TypeInfoPropertyName = "PutModelsSettingsRequestDiscussionsSorting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutModelsSettingsRequestGated?>), TypeInfoPropertyName = "AnyOfBooleanPutModelsSettingsRequestGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsRequestGated), TypeInfoPropertyName = "PutModelsSettingsRequestGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsRequestGatedNotificationsMode), TypeInfoPropertyName = "PutModelsSettingsRequestGatedNotificationsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestHandleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestHandleRequestStatus), TypeInfoPropertyName = "CreateModelsUserAccessRequestHandleRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus), TypeInfoPropertyName = "CreateModelsUserAccessRequestBatchRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestGrantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsLikersExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLikersExpandItem), TypeInfoPropertyName = "GetModelsLikersExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesDirection), TypeInfoPropertyName = "GetModelsLfsFilesDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesSort), TypeInfoPropertyName = "GetModelsLfsFilesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsCommitsExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsCommitsExpandItem), TypeInfoPropertyName = "GetModelsCommitsExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsCommitContentType), TypeInfoPropertyName = "CreateModelsCommitContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTagsByTypeType), TypeInfoPropertyName = "GetModelsTagsByTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsUserAccessRequestStatus), TypeInfoPropertyName = "GetModelsUserAccessRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreesizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsLfsFilesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusher))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan), TypeInfoPropertyName = "GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole), TypeInfoPropertyName = "GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsCommitsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsCommitsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsCommitsResponseItemAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsCommitsResponseItemAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsCommitsResponseItemFormatted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsRefsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsRefsResponseTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseBranche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsRefsResponseBranche))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponseConvert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsRefsResponseConvert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsRefsResponsePullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsRefsResponsePullRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemType), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemLfs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemLastCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusStatus), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety), TypeInfoPropertyName = "CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPreuploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPreuploadResponseFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPreuploadResponseFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode), TypeInfoPropertyName = "CreateModelsPreuploadResponseFileUploadMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsXetWriteTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsXetReadTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsCommitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsResourceGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsResourceGroupResponseType), TypeInfoPropertyName = "CreateModelsResourceGroupResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsResourceGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsSuperSquashResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsResponseVisibility), TypeInfoPropertyName = "PutModelsSettingsResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting), TypeInfoPropertyName = "PutModelsSettingsResponseDiscussionsSorting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutModelsSettingsResponseGated?>), TypeInfoPropertyName = "AnyOfBooleanPutModelsSettingsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsResponseGated), TypeInfoPropertyName = "PutModelsSettingsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsResponseGatedNotificationsMode), TypeInfoPropertyName = "PutModelsSettingsResponseGatedNotificationsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemType), TypeInfoPropertyName = "GetModelsTreeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemLfs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemLastCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanStatus), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusAvScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety), TypeInfoPropertyName = "GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetModelsNotebookResponseVariant1, global::HuggingFace.GetModelsNotebookResponseVariant2, global::HuggingFace.GetModelsNotebookResponseVariant3>), TypeInfoPropertyName = "AnyOfGetModelsNotebookResponseVariant1GetModelsNotebookResponseVariant2GetModelsNotebookResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsNotebookResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsNotebookResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsNotebookResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsScanResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsScanResponseFilesWithIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsScanResponseFilesWithIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsScanResponseFilesWithIssueLevel), TypeInfoPropertyName = "GetModelsScanResponseFilesWithIssueLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsJwtResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsJwtResponseEncryptedToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTagsByTypeResponseItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTagsByTypeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTagsByTypeResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTagsByTypeResponseItemType), TypeInfoPropertyName = "GetModelsTagsByTypeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetResolveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetResolveCacheModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetModelsUserAccessRequestResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsUserAccessRequestResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItemError), TypeInfoPropertyName = "CreateModelsUserAccessRequestBatchResponseItemError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTargetType?), TypeInfoPropertyName = "NullableCreateModelsLfsFilesDuplicateRequestTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsRequestVisibility?), TypeInfoPropertyName = "NullablePutModelsSettingsRequestVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsRequestDiscussionsSorting?), TypeInfoPropertyName = "NullablePutModelsSettingsRequestDiscussionsSorting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutModelsSettingsRequestGated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanPutModelsSettingsRequestGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsRequestGated?), TypeInfoPropertyName = "NullablePutModelsSettingsRequestGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsRequestGatedNotificationsMode?), TypeInfoPropertyName = "NullablePutModelsSettingsRequestGatedNotificationsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestHandleRequestStatus?), TypeInfoPropertyName = "NullableCreateModelsUserAccessRequestHandleRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus?), TypeInfoPropertyName = "NullableCreateModelsUserAccessRequestBatchRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLikersExpandItem?), TypeInfoPropertyName = "NullableGetModelsLikersExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesDirection?), TypeInfoPropertyName = "NullableGetModelsLfsFilesDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesSort?), TypeInfoPropertyName = "NullableGetModelsLfsFilesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsCommitsExpandItem?), TypeInfoPropertyName = "NullableGetModelsCommitsExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsCommitContentType?), TypeInfoPropertyName = "NullableCreateModelsCommitContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTagsByTypeType?), TypeInfoPropertyName = "NullableGetModelsTagsByTypeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsUserAccessRequestStatus?), TypeInfoPropertyName = "NullableGetModelsUserAccessRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan?), TypeInfoPropertyName = "NullableGetModelsLfsFilesResponseItemPusherPrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole?), TypeInfoPropertyName = "NullableGetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemType?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusStatus?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?), TypeInfoPropertyName = "NullableCreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode?), TypeInfoPropertyName = "NullableCreateModelsPreuploadResponseFileUploadMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsResourceGroupResponseType?), TypeInfoPropertyName = "NullableCreateModelsResourceGroupResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsResponseVisibility?), TypeInfoPropertyName = "NullablePutModelsSettingsResponseVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting?), TypeInfoPropertyName = "NullablePutModelsSettingsResponseDiscussionsSorting2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutModelsSettingsResponseGated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanPutModelsSettingsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsResponseGated?), TypeInfoPropertyName = "NullablePutModelsSettingsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutModelsSettingsResponseGatedNotificationsMode?), TypeInfoPropertyName = "NullablePutModelsSettingsResponseGatedNotificationsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemType?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanStatus?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusAvScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?), TypeInfoPropertyName = "NullableGetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetModelsNotebookResponseVariant1, global::HuggingFace.GetModelsNotebookResponseVariant2, global::HuggingFace.GetModelsNotebookResponseVariant3>?), TypeInfoPropertyName = "NullableAnyOfGetModelsNotebookResponseVariant1GetModelsNotebookResponseVariant2GetModelsNotebookResponseVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsScanResponseFilesWithIssueLevel?), TypeInfoPropertyName = "NullableGetModelsScanResponseFilesWithIssueLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetModelsTagsByTypeResponseItemType?), TypeInfoPropertyName = "NullableGetModelsTagsByTypeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItemError?), TypeInfoPropertyName = "NullableCreateModelsUserAccessRequestBatchResponseItemError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsLfsFilesDuplicateRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPreuploadRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsUserAccessRequestBatchRequestRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsLikersExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsCommitsExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsLfsFilesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsLfsFilesDuplicateResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsCommitsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsCommitsResponseItemAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponseBranche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponseConvert>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsRefsResponsePullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsPreuploadResponseFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImport>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsScanResponseFilesWithIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::HuggingFace.GetModelsTagsByTypeResponseItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsTagsByTypeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetModelsUserAccessRequestResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItem>))]
    internal sealed partial class ModelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModelsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.PutModelsSettingsRequestGated?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.PutModelsSettingsResponseGated?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetModelsNotebookResponseVariant1, global::HuggingFace.GetModelsNotebookResponseVariant2, global::HuggingFace.GetModelsNotebookResponseVariant3>());
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
                    typeToConvert == typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTargetType)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTargetType?)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestVisibility)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestVisibility?)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestDiscussionsSorting)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestDiscussionsSorting?)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestGated)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestGated?)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestGatedNotificationsMode)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestGatedNotificationsMode?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestHandleRequestStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestHandleRequestStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLikersExpandItem)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLikersExpandItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesDirection)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesDirection?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesSort)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesSort?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsCommitsExpandItem)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsCommitsExpandItem?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsCommitContentType)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsCommitContentType?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTagsByTypeType)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTagsByTypeType?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsUserAccessRequestStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsUserAccessRequestStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsResourceGroupResponseType)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsResourceGroupResponseType?)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseVisibility)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseVisibility?)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting?)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseGated)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseGated?)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseGatedNotificationsMode)

                    || typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseGatedNotificationsMode?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsScanResponseFilesWithIssueLevel)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsScanResponseFilesWithIssueLevel?)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTagsByTypeResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetModelsTagsByTypeResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItemError)

                    || typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItemError?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTargetType))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsLfsFilesDuplicateRequestTargetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsLfsFilesDuplicateRequestTargetType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsLfsFilesDuplicateRequestTargetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestVisibility))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsRequestVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestVisibility?))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsRequestVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestDiscussionsSorting))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsRequestDiscussionsSortingJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestDiscussionsSorting?))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsRequestDiscussionsSortingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestGated))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsRequestGatedJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestGated?))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsRequestGatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestGatedNotificationsMode))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsRequestGatedNotificationsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsRequestGatedNotificationsMode?))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsRequestGatedNotificationsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestHandleRequestStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsUserAccessRequestHandleRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestHandleRequestStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsUserAccessRequestHandleRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsUserAccessRequestBatchRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchRequestStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsUserAccessRequestBatchRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLikersExpandItem))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLikersExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLikersExpandItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLikersExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesDirection))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLfsFilesDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesDirection?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLfsFilesDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesSort))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLfsFilesSortJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesSort?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLfsFilesSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsCommitsExpandItem))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsCommitsExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsCommitsExpandItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsCommitsExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsCommitContentType))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsCommitContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsCommitContentType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsCommitContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTagsByTypeType))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTagsByTypeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTagsByTypeType?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTagsByTypeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsUserAccessRequestStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsUserAccessRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsUserAccessRequestStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsUserAccessRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLfsFilesResponseItemPusherPrimaryOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPreuploadResponseFileUploadModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsPreuploadResponseFileUploadMode?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsPreuploadResponseFileUploadModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsResourceGroupResponseType))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsResourceGroupResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsResourceGroupResponseType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsResourceGroupResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseVisibility))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsResponseVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseVisibility?))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsResponseVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsResponseDiscussionsSortingJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseDiscussionsSorting?))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsResponseDiscussionsSortingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseGated))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsResponseGatedJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseGated?))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsResponseGatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseGatedNotificationsMode))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsResponseGatedNotificationsModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutModelsSettingsResponseGatedNotificationsMode?))
                {
                    return new global::HuggingFace.JsonConverters.PutModelsSettingsResponseGatedNotificationsModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusAvScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusAvScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsScanResponseFilesWithIssueLevel))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsScanResponseFilesWithIssueLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsScanResponseFilesWithIssueLevel?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsScanResponseFilesWithIssueLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTagsByTypeResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTagsByTypeResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetModelsTagsByTypeResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetModelsTagsByTypeResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItemError))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsUserAccessRequestBatchResponseItemErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateModelsUserAccessRequestBatchResponseItemError?))
                {
                    return new global::HuggingFace.JsonConverters.CreateModelsUserAccessRequestBatchResponseItemErrorNullableJsonConverter();
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
                    0 => new ModelsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::HuggingFace.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}