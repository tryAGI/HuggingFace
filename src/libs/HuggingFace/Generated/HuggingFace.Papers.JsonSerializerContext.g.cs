
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsPapersClaimRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePapersIndexRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePapersLinksRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetDailyPapersSort), TypeInfoPropertyName = "GetDailyPapersSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetPapersField2?, global::System.Collections.Generic.IList<global::HuggingFace.GetPapersFieldItem>>), TypeInfoPropertyName = "AnyOfGetPapersField2IListGetPapersFieldItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersField2), TypeInfoPropertyName = "GetPapersField22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersFieldItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersFieldItem), TypeInfoPropertyName = "GetPapersFieldItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsPapersClaimResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetDailyPapersResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetDailyPapersResponseItemPaper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItemPaperAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetDailyPapersResponseItemPaperAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetDailyPapersResponseItemPaperAuthorUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetDailyPapersResponseItemPaperSubmittedOnDailyBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetDailyPapersResponseItemSubmittedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseItemAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseItemAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseItemAuthorUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseItemOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePapersIndexResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseAuthorUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseSubmittedOnDailyBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider), TypeInfoPropertyName = "GetPapersResponseLinkedModelAvailableInferenceProviderProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus), TypeInfoPropertyName = "GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus), TypeInfoPropertyName = "GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask), TypeInfoPropertyName = "GetPapersResponseLinkedModelAvailableInferenceProviderTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderFeatures))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetPapersResponseLinkedModelGated?>), TypeInfoPropertyName = "AnyOfBooleanGetPapersResponseLinkedModelGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelGated), TypeInfoPropertyName = "GetPapersResponseLinkedModelGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1, global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2>), TypeInfoPropertyName = "OneOfGetPapersResponseLinkedModelAuthorDataVariant1GetPapersResponseLinkedModelAuthorDataVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan), TypeInfoPropertyName = "GetPapersResponseLinkedModelAuthorDataVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan), TypeInfoPropertyName = "GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole), TypeInfoPropertyName = "GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer), TypeInfoPropertyName = "GetPapersResponseLinkedDatasetDatasetsServerInfoViewer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie), TypeInfoPropertyName = "GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat), TypeInfoPropertyName = "GetPapersResponseLinkedDatasetDatasetsServerInfoFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie), TypeInfoPropertyName = "GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetPapersResponseLinkedDatasetGated?>), TypeInfoPropertyName = "AnyOfBooleanGetPapersResponseLinkedDatasetGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetGated), TypeInfoPropertyName = "GetPapersResponseLinkedDatasetGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseLinkedSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseComment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseComment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseCommentAuthorVariant1, global::HuggingFace.GetPapersResponseCommentAuthorVariant2>), TypeInfoPropertyName = "OneOfGetPapersResponseCommentAuthorVariant1GetPapersResponseCommentAuthorVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant1OauthApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant1OauthAppImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant1Plan), TypeInfoPropertyName = "GetPapersResponseCommentAuthorVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2OauthApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2OauthAppImageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan), TypeInfoPropertyName = "GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole), TypeInfoPropertyName = "GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataHiddenReason), TypeInfoPropertyName = "GetPapersResponseCommentDataHiddenReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1, global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2>), TypeInfoPropertyName = "OneOfGetPapersResponseCommentDataLatestAuthorVariant1GetPapersResponseCommentDataLatestAuthorVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1Plan), TypeInfoPropertyName = "GetPapersResponseCommentDataLatestAuthorVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan), TypeInfoPropertyName = "GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole), TypeInfoPropertyName = "GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetPapersResponseCommentDataReaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataReaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataReactionReaction), TypeInfoPropertyName = "GetPapersResponseCommentDataReactionReaction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataIdentifiedLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePapersLinksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetDailyPapersSort?), TypeInfoPropertyName = "NullableGetDailyPapersSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetPapersField2?, global::System.Collections.Generic.IList<global::HuggingFace.GetPapersFieldItem>>?), TypeInfoPropertyName = "NullableAnyOfGetPapersField2IListGetPapersFieldItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersField2?), TypeInfoPropertyName = "NullableGetPapersField22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersFieldItem?), TypeInfoPropertyName = "NullableGetPapersFieldItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedModelAvailableInferenceProviderProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedModelAvailableInferenceProviderModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedModelAvailableInferenceProviderTask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetPapersResponseLinkedModelGated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanGetPapersResponseLinkedModelGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelGated?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedModelGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1, global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2>?), TypeInfoPropertyName = "NullableOneOfGetPapersResponseLinkedModelAuthorDataVariant1GetPapersResponseLinkedModelAuthorDataVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedModelAuthorDataVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedDatasetDatasetsServerInfoViewer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedDatasetDatasetsServerInfoFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedDatasetDatasetsServerInfoModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetPapersResponseLinkedDatasetGated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanGetPapersResponseLinkedDatasetGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseLinkedDatasetGated?), TypeInfoPropertyName = "NullableGetPapersResponseLinkedDatasetGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseCommentAuthorVariant1, global::HuggingFace.GetPapersResponseCommentAuthorVariant2>?), TypeInfoPropertyName = "NullableOneOfGetPapersResponseCommentAuthorVariant1GetPapersResponseCommentAuthorVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant1Plan?), TypeInfoPropertyName = "NullableGetPapersResponseCommentAuthorVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan?), TypeInfoPropertyName = "NullableGetPapersResponseCommentAuthorVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole?), TypeInfoPropertyName = "NullableGetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataHiddenReason?), TypeInfoPropertyName = "NullableGetPapersResponseCommentDataHiddenReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1, global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2>?), TypeInfoPropertyName = "NullableOneOfGetPapersResponseCommentDataLatestAuthorVariant1GetPapersResponseCommentDataLatestAuthorVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1Plan?), TypeInfoPropertyName = "NullableGetPapersResponseCommentDataLatestAuthorVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan?), TypeInfoPropertyName = "NullableGetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole?), TypeInfoPropertyName = "NullableGetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPapersResponseCommentDataReactionReaction?), TypeInfoPropertyName = "NullableGetPapersResponseCommentDataReactionReaction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetPapersField2?, global::System.Collections.Generic.List<global::HuggingFace.GetPapersFieldItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersFieldItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetDailyPapersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetDailyPapersResponseItemPaperAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseItemAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseLinkedSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseComment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetPapersResponseCommentDataReaction>))]
    internal sealed partial class PapersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PapersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PapersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PapersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetPapersField2?, global::System.Collections.Generic.IList<global::HuggingFace.GetPapersFieldItem>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, bool?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.GetPapersResponseLinkedModelGated?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1, global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.GetPapersResponseLinkedDatasetGated?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetPapersResponseCommentAuthorVariant1, global::HuggingFace.GetPapersResponseCommentAuthorVariant2>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1, global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2>());
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
                    typeToConvert == typeof(global::HuggingFace.GetDailyPapersSort)

                    || typeToConvert == typeof(global::HuggingFace.GetDailyPapersSort?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersField2)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersField2?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersFieldItem)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersFieldItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelGated)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelGated?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetGated)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetGated?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant1Plan)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant1Plan?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataHiddenReason)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataHiddenReason?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1Plan)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1Plan?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataReactionReaction)

                    || typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataReactionReaction?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.GetDailyPapersSort))
                {
                    return new global::HuggingFace.JsonConverters.GetDailyPapersSortJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetDailyPapersSort?))
                {
                    return new global::HuggingFace.JsonConverters.GetDailyPapersSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersField2))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersField2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersField2?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersField2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersFieldItem))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersFieldItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersFieldItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersFieldItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProvider?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderProviderStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderTaskJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAvailableInferenceProviderTask?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAvailableInferenceProviderTaskNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelGated))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelGatedJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelGated?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelGatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAuthorDataVariant1PlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant1Plan?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAuthorDataVariant1PlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedModelAuthorDataVariant2PrimaryOrgUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetDatasetsServerInfoViewerJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoViewer?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetDatasetsServerInfoViewerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarieJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarie?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetDatasetsServerInfoLibrarieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetDatasetsServerInfoFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoFormat?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetDatasetsServerInfoFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitie?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetDatasetsServerInfoModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetGated))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetGatedJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseLinkedDatasetGated?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseLinkedDatasetGatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant1Plan))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentAuthorVariant1PlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant1Plan?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentAuthorVariant1PlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentAuthorVariant2PrimaryOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataHiddenReason))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataHiddenReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataHiddenReason?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataHiddenReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1Plan))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataLatestAuthorVariant1PlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant1Plan?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataLatestAuthorVariant1PlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataReactionReaction))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataReactionReactionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPapersResponseCommentDataReactionReaction?))
                {
                    return new global::HuggingFace.JsonConverters.GetPapersResponseCommentDataReactionReactionNullableJsonConverter();
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
                    0 => new PapersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}