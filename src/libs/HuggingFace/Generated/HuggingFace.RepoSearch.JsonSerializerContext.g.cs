
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLang?, string>), TypeInfoPropertyName = "AnyOfCreateQuicksearchRequestLangString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestLang), TypeInfoPropertyName = "CreateQuicksearchRequestLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLibrary?, string>), TypeInfoPropertyName = "AnyOfCreateQuicksearchRequestLibraryString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestLibrary), TypeInfoPropertyName = "CreateQuicksearchRequestLibrary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListCreateQuicksearchRequestTypeVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item), TypeInfoPropertyName = "CreateQuicksearchRequestTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListCreateQuicksearchRequestOrgsFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item), TypeInfoPropertyName = "CreateQuicksearchRequestOrgsFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListCreateQuicksearchRequestReposFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item), TypeInfoPropertyName = "CreateQuicksearchRequestReposFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>), TypeInfoPropertyName = "AnyOfIListCreateQuicksearchRequestPipelinesVariant1ItemAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item), TypeInfoPropertyName = "CreateQuicksearchRequestPipelinesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestRepoType?, string>), TypeInfoPropertyName = "AnyOfCreateQuicksearchRequestRepoTypeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestRepoType), TypeInfoPropertyName = "CreateQuicksearchRequestRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLang2?, string>), TypeInfoPropertyName = "AnyOfGetQuicksearchLang2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchLang2), TypeInfoPropertyName = "GetQuicksearchLang22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLibrary2?, string>), TypeInfoPropertyName = "AnyOfGetQuicksearchLibrary2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchLibrary2), TypeInfoPropertyName = "GetQuicksearchLibrary22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListGetQuicksearchTypeVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchTypeVariant1Item), TypeInfoPropertyName = "GetQuicksearchTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListGetQuicksearchOrgsFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item), TypeInfoPropertyName = "GetQuicksearchOrgsFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListGetQuicksearchReposFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchReposFilterVariant1Item), TypeInfoPropertyName = "GetQuicksearchReposFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>), TypeInfoPropertyName = "AnyOfIListGetQuicksearchPipelinesVariant1ItemAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchPipelinesVariant1Item), TypeInfoPropertyName = "GetQuicksearchPipelinesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchRepoType2?, string>), TypeInfoPropertyName = "AnyOfGetQuicksearchRepoType2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchRepoType2), TypeInfoPropertyName = "GetQuicksearchRepoType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLang2?, string>), TypeInfoPropertyName = "AnyOfCreateQuicksearchLang2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchLang2), TypeInfoPropertyName = "CreateQuicksearchLang22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLibrary2?, string>), TypeInfoPropertyName = "AnyOfCreateQuicksearchLibrary2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchLibrary2), TypeInfoPropertyName = "CreateQuicksearchLibrary22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListCreateQuicksearchTypeVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchTypeVariant1Item), TypeInfoPropertyName = "CreateQuicksearchTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListCreateQuicksearchOrgsFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item), TypeInfoPropertyName = "CreateQuicksearchOrgsFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListCreateQuicksearchReposFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchReposFilterVariant1Item), TypeInfoPropertyName = "CreateQuicksearchReposFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>), TypeInfoPropertyName = "AnyOfIListCreateQuicksearchPipelinesVariant1ItemAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchPipelinesVariant1Item), TypeInfoPropertyName = "CreateQuicksearchPipelinesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRepoType2?, string>), TypeInfoPropertyName = "AnyOfCreateQuicksearchRepoType2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRepoType2), TypeInfoPropertyName = "CreateQuicksearchRepoType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>>), TypeInfoPropertyName = "AnyOfGetSearchFullTextType2IListGetSearchFullTextTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSearchFullTextType2), TypeInfoPropertyName = "GetSearchFullTextType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSearchFullTextTypeItem), TypeInfoPropertyName = "GetSearchFullTextTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponseDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponseOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponseSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponsePaper>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponsePaper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponseCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponseBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseKernel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponseKernel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchResponseBlog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchResponseBlog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponseDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponseOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponseSpace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponsePaper>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponsePaper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponseCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponseBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseKernel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponseKernel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchResponseBlog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchResponseBlog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLang?, string>?), TypeInfoPropertyName = "NullableAnyOfCreateQuicksearchRequestLangString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestLang?), TypeInfoPropertyName = "NullableCreateQuicksearchRequestLang2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLibrary?, string>?), TypeInfoPropertyName = "NullableAnyOfCreateQuicksearchRequestLibraryString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestLibrary?), TypeInfoPropertyName = "NullableCreateQuicksearchRequestLibrary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListCreateQuicksearchRequestTypeVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item?), TypeInfoPropertyName = "NullableCreateQuicksearchRequestTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListCreateQuicksearchRequestOrgsFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item?), TypeInfoPropertyName = "NullableCreateQuicksearchRequestOrgsFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListCreateQuicksearchRequestReposFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item?), TypeInfoPropertyName = "NullableCreateQuicksearchRequestReposFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>?), TypeInfoPropertyName = "NullableAnyOfIListCreateQuicksearchRequestPipelinesVariant1ItemAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item?), TypeInfoPropertyName = "NullableCreateQuicksearchRequestPipelinesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestRepoType?, string>?), TypeInfoPropertyName = "NullableAnyOfCreateQuicksearchRequestRepoTypeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRequestRepoType?), TypeInfoPropertyName = "NullableCreateQuicksearchRequestRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLang2?, string>?), TypeInfoPropertyName = "NullableAnyOfGetQuicksearchLang2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchLang2?), TypeInfoPropertyName = "NullableGetQuicksearchLang22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLibrary2?, string>?), TypeInfoPropertyName = "NullableAnyOfGetQuicksearchLibrary2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchLibrary2?), TypeInfoPropertyName = "NullableGetQuicksearchLibrary22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListGetQuicksearchTypeVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchTypeVariant1Item?), TypeInfoPropertyName = "NullableGetQuicksearchTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListGetQuicksearchOrgsFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item?), TypeInfoPropertyName = "NullableGetQuicksearchOrgsFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListGetQuicksearchReposFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchReposFilterVariant1Item?), TypeInfoPropertyName = "NullableGetQuicksearchReposFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>?), TypeInfoPropertyName = "NullableAnyOfIListGetQuicksearchPipelinesVariant1ItemAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchPipelinesVariant1Item?), TypeInfoPropertyName = "NullableGetQuicksearchPipelinesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchRepoType2?, string>?), TypeInfoPropertyName = "NullableAnyOfGetQuicksearchRepoType2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetQuicksearchRepoType2?), TypeInfoPropertyName = "NullableGetQuicksearchRepoType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLang2?, string>?), TypeInfoPropertyName = "NullableAnyOfCreateQuicksearchLang2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchLang2?), TypeInfoPropertyName = "NullableCreateQuicksearchLang22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLibrary2?, string>?), TypeInfoPropertyName = "NullableAnyOfCreateQuicksearchLibrary2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchLibrary2?), TypeInfoPropertyName = "NullableCreateQuicksearchLibrary22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListCreateQuicksearchTypeVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchTypeVariant1Item?), TypeInfoPropertyName = "NullableCreateQuicksearchTypeVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListCreateQuicksearchOrgsFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item?), TypeInfoPropertyName = "NullableCreateQuicksearchOrgsFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfIListCreateQuicksearchReposFilterVariant1ItemIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchReposFilterVariant1Item?), TypeInfoPropertyName = "NullableCreateQuicksearchReposFilterVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>?), TypeInfoPropertyName = "NullableAnyOfIListCreateQuicksearchPipelinesVariant1ItemAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchPipelinesVariant1Item?), TypeInfoPropertyName = "NullableCreateQuicksearchPipelinesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRepoType2?, string>?), TypeInfoPropertyName = "NullableAnyOfCreateQuicksearchRepoType2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateQuicksearchRepoType2?), TypeInfoPropertyName = "NullableCreateQuicksearchRepoType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>>?), TypeInfoPropertyName = "NullableAnyOfGetSearchFullTextType2IListGetSearchFullTextTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSearchFullTextType2?), TypeInfoPropertyName = "NullableGetSearchFullTextType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSearchFullTextTypeItem?), TypeInfoPropertyName = "NullableGetSearchFullTextTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchTypeVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.List<global::HuggingFace.GetSearchFullTextTypeItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSearchFullTextTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponsePaper>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseKernel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetQuicksearchResponseBlog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseDataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseSpace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponsePaper>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseKernel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateQuicksearchResponseBlog>))]
    internal sealed partial class RepoSearchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RepoSearchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RepoSearchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RepoSearchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateQuicksearchRequestLang?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateQuicksearchRequestLibrary?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateQuicksearchRequestRepoType?, string>());
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetQuicksearchLang2?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetQuicksearchLibrary2?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetQuicksearchRepoType2?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateQuicksearchLang2?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateQuicksearchLibrary2?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateQuicksearchRepoType2?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetSearchFullTextType2?, global::System.Collections.Generic.IList<global::HuggingFace.GetSearchFullTextTypeItem>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>());
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
                    typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestLang)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestLang?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestLibrary)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestLibrary?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestRepoType)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestRepoType?)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchLang2)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchLang2?)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchLibrary2)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchLibrary2?)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchTypeVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchTypeVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchReposFilterVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchReposFilterVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchPipelinesVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchPipelinesVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchRepoType2)

                    || typeToConvert == typeof(global::HuggingFace.GetQuicksearchRepoType2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchLang2)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchLang2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchLibrary2)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchLibrary2?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchTypeVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchTypeVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchReposFilterVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchReposFilterVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchPipelinesVariant1Item)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchPipelinesVariant1Item?)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRepoType2)

                    || typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRepoType2?)

                    || typeToConvert == typeof(global::HuggingFace.GetSearchFullTextType2)

                    || typeToConvert == typeof(global::HuggingFace.GetSearchFullTextType2?)

                    || typeToConvert == typeof(global::HuggingFace.GetSearchFullTextTypeItem)

                    || typeToConvert == typeof(global::HuggingFace.GetSearchFullTextTypeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestLang))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestLangJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestLang?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestLangNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestLibrary))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestLibraryJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestLibrary?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestLibraryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestTypeVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestTypeVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestOrgsFilterVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestOrgsFilterVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestReposFilterVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestReposFilterVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestPipelinesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestPipelinesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestRepoType))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRequestRepoType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRequestRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchLang2))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchLang2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchLang2?))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchLang2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchLibrary2))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchLibrary2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchLibrary2?))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchLibrary2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchTypeVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchTypeVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchTypeVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchTypeVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchOrgsFilterVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchOrgsFilterVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchReposFilterVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchReposFilterVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchReposFilterVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchReposFilterVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchPipelinesVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchPipelinesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchPipelinesVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchPipelinesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchRepoType2))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchRepoType2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetQuicksearchRepoType2?))
                {
                    return new global::HuggingFace.JsonConverters.GetQuicksearchRepoType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchLang2))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchLang2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchLang2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchLang2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchLibrary2))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchLibrary2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchLibrary2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchLibrary2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchTypeVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchTypeVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchTypeVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchTypeVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchOrgsFilterVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchOrgsFilterVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchReposFilterVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchReposFilterVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchReposFilterVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchReposFilterVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchPipelinesVariant1Item))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchPipelinesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchPipelinesVariant1Item?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchPipelinesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRepoType2))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRepoType2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateQuicksearchRepoType2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateQuicksearchRepoType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSearchFullTextType2))
                {
                    return new global::HuggingFace.JsonConverters.GetSearchFullTextType2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSearchFullTextType2?))
                {
                    return new global::HuggingFace.JsonConverters.GetSearchFullTextType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSearchFullTextTypeItem))
                {
                    return new global::HuggingFace.JsonConverters.GetSearchFullTextTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSearchFullTextTypeItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetSearchFullTextTypeItemNullableJsonConverter();
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
                    0 => new RepoSearchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}