
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTargetType), TypeInfoPropertyName = "CreateBucketsLfsFilesDuplicateRequestTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsResourceGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsRequestCdnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsRequestCdnItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsRequestCdnItemProvider), TypeInfoPropertyName = "CreateBucketsRequestCdnItemProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsRequestCdnItemRegion), TypeInfoPropertyName = "CreateBucketsRequestCdnItemRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsRequestRegion), TypeInfoPropertyName = "CreateBucketsRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PutBucketsSettingsRequestCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionProvider), TypeInfoPropertyName = "PutBucketsSettingsRequestCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionRegion), TypeInfoPropertyName = "PutBucketsSettingsRequestCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsPathsInfoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsTreeSort), TypeInfoPropertyName = "GetBucketsTreeSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsTreeDirection), TypeInfoPropertyName = "GetBucketsTreeDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsXetWriteTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsXetReadTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsResourceGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsResourceGroupResponseType), TypeInfoPropertyName = "CreateBucketsResourceGroupResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResourceGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsResponseCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseCdnRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseCdnRegionProvider), TypeInfoPropertyName = "GetBucketsResponseCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseCdnRegionRegion), TypeInfoPropertyName = "GetBucketsResponseCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PutBucketsSettingsResponseCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionProvider), TypeInfoPropertyName = "PutBucketsSettingsResponseCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionRegion), TypeInfoPropertyName = "PutBucketsSettingsResponseCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseItemDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsResponseItemCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseItemCdnRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionProvider), TypeInfoPropertyName = "GetBucketsResponseItemCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionRegion), TypeInfoPropertyName = "GetBucketsResponseItemCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseItemResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResolveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResolveResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResolveResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsBatchResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsBatchResponseFailedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsBatchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsBatchResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsBatchResponseFailedItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetBucketsTreeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsTreeResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsTreeResponseItemType), TypeInfoPropertyName = "GetBucketsTreeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateBucketsPathsInfoResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsPathsInfoResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsPathsInfoResponseItemType), TypeInfoPropertyName = "CreateBucketsPathsInfoResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTargetType?), TypeInfoPropertyName = "NullableCreateBucketsLfsFilesDuplicateRequestTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>?), TypeInfoPropertyName = "NullableAnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsRequestCdnItemProvider?), TypeInfoPropertyName = "NullableCreateBucketsRequestCdnItemProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsRequestCdnItemRegion?), TypeInfoPropertyName = "NullableCreateBucketsRequestCdnItemRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsRequestRegion?), TypeInfoPropertyName = "NullableCreateBucketsRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionProvider?), TypeInfoPropertyName = "NullablePutBucketsSettingsRequestCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionRegion?), TypeInfoPropertyName = "NullablePutBucketsSettingsRequestCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsTreeSort?), TypeInfoPropertyName = "NullableGetBucketsTreeSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsTreeDirection?), TypeInfoPropertyName = "NullableGetBucketsTreeDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsResourceGroupResponseType?), TypeInfoPropertyName = "NullableCreateBucketsResourceGroupResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseCdnRegionProvider?), TypeInfoPropertyName = "NullableGetBucketsResponseCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseCdnRegionRegion?), TypeInfoPropertyName = "NullableGetBucketsResponseCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionProvider?), TypeInfoPropertyName = "NullablePutBucketsSettingsResponseCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionRegion?), TypeInfoPropertyName = "NullablePutBucketsSettingsResponseCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionProvider?), TypeInfoPropertyName = "NullableGetBucketsResponseItemCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionRegion?), TypeInfoPropertyName = "NullableGetBucketsResponseItemCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetBucketsTreeResponseItemType?), TypeInfoPropertyName = "NullableGetBucketsTreeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateBucketsPathsInfoResponseItemType?), TypeInfoPropertyName = "NullableCreateBucketsPathsInfoResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsRequestCdnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PutBucketsSettingsRequestCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsLfsFilesDuplicateResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetBucketsResponseCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PutBucketsSettingsResponseCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetBucketsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetBucketsResponseItemCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsBatchResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsBatchResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetBucketsTreeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateBucketsPathsInfoResponseItem>))]
    internal sealed partial class BucketsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BucketsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BucketsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BucketsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTargetType)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTargetType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestCdnItemProvider)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestCdnItemProvider?)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestCdnItemRegion)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestCdnItemRegion?)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestRegion)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestRegion?)

                    || typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionProvider)

                    || typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionProvider?)

                    || typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionRegion)

                    || typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionRegion?)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsTreeSort)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsTreeSort?)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsTreeDirection)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsTreeDirection?)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsResourceGroupResponseType)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsResourceGroupResponseType?)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsResponseCdnRegionProvider)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsResponseCdnRegionProvider?)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsResponseCdnRegionRegion)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsResponseCdnRegionRegion?)

                    || typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionProvider)

                    || typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionProvider?)

                    || typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionRegion)

                    || typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionRegion?)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionProvider)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionProvider?)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionRegion)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionRegion?)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsTreeResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetBucketsTreeResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsPathsInfoResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.CreateBucketsPathsInfoResponseItemType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTargetType))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsLfsFilesDuplicateRequestTargetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsLfsFilesDuplicateRequestTargetType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsLfsFilesDuplicateRequestTargetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestCdnItemProvider))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsRequestCdnItemProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestCdnItemProvider?))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsRequestCdnItemProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestCdnItemRegion))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsRequestCdnItemRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestCdnItemRegion?))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsRequestCdnItemRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestRegion))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsRequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsRequestRegion?))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsRequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionProvider))
                {
                    return new global::HuggingFace.JsonConverters.PutBucketsSettingsRequestCdnRegionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionProvider?))
                {
                    return new global::HuggingFace.JsonConverters.PutBucketsSettingsRequestCdnRegionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionRegion))
                {
                    return new global::HuggingFace.JsonConverters.PutBucketsSettingsRequestCdnRegionRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsRequestCdnRegionRegion?))
                {
                    return new global::HuggingFace.JsonConverters.PutBucketsSettingsRequestCdnRegionRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsTreeSort))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsTreeSortJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsTreeSort?))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsTreeSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsTreeDirection))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsTreeDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsTreeDirection?))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsTreeDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsResourceGroupResponseType))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsResourceGroupResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsResourceGroupResponseType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsResourceGroupResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsResponseCdnRegionProvider))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsResponseCdnRegionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsResponseCdnRegionProvider?))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsResponseCdnRegionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsResponseCdnRegionRegion))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsResponseCdnRegionRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsResponseCdnRegionRegion?))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsResponseCdnRegionRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionProvider))
                {
                    return new global::HuggingFace.JsonConverters.PutBucketsSettingsResponseCdnRegionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionProvider?))
                {
                    return new global::HuggingFace.JsonConverters.PutBucketsSettingsResponseCdnRegionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionRegion))
                {
                    return new global::HuggingFace.JsonConverters.PutBucketsSettingsResponseCdnRegionRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutBucketsSettingsResponseCdnRegionRegion?))
                {
                    return new global::HuggingFace.JsonConverters.PutBucketsSettingsResponseCdnRegionRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionProvider))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsResponseItemCdnRegionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionProvider?))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsResponseItemCdnRegionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionRegion))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsResponseItemCdnRegionRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsResponseItemCdnRegionRegion?))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsResponseItemCdnRegionRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsTreeResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsTreeResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetBucketsTreeResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetBucketsTreeResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsPathsInfoResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsPathsInfoResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateBucketsPathsInfoResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateBucketsPathsInfoResponseItemTypeNullableJsonConverter();
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
                    0 => new BucketsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}