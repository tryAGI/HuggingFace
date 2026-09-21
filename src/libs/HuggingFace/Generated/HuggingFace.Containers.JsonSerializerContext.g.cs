
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersRequestCdnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersRequestCdnItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersRequestCdnItemProvider), TypeInfoPropertyName = "CreateContainersRequestCdnItemProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersRequestCdnItemRegion), TypeInfoPropertyName = "CreateContainersRequestCdnItemRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersRequestRegion), TypeInfoPropertyName = "CreateContainersRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsRequestCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionProvider), TypeInfoPropertyName = "PutContainersSettingsRequestCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionRegion), TypeInfoPropertyName = "PutContainersSettingsRequestCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersPathsInfoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersTreeSort), TypeInfoPropertyName = "GetContainersTreeSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersTreeDirection), TypeInfoPropertyName = "GetContainersTreeDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetRegistryTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersXetWriteTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersXetReadTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseRepoType), TypeInfoPropertyName = "GetContainersResponseRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetContainersResponseCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseCdnRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseCdnRegionProvider), TypeInfoPropertyName = "GetContainersResponseCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseCdnRegionRegion), TypeInfoPropertyName = "GetContainersResponseCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PutContainersSettingsResponseCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider), TypeInfoPropertyName = "PutContainersSettingsResponseCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion), TypeInfoPropertyName = "PutContainersSettingsResponseCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetContainersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItemRepoType), TypeInfoPropertyName = "GetContainersResponseItemRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItemDisabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetContainersResponseItemCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItemCdnRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItemCdnRegionProvider), TypeInfoPropertyName = "GetContainersResponseItemCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItemCdnRegionRegion), TypeInfoPropertyName = "GetContainersResponseItemCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItemResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResolveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResolveResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResolveResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersBatchResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersBatchResponseFailedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersBatchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersBatchResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersBatchResponseFailedItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetContainersTreeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersTreeResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersTreeResponseItemType), TypeInfoPropertyName = "GetContainersTreeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateContainersPathsInfoResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersPathsInfoResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersPathsInfoResponseItemType), TypeInfoPropertyName = "CreateContainersPathsInfoResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>?), TypeInfoPropertyName = "NullableAnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersRequestCdnItemProvider?), TypeInfoPropertyName = "NullableCreateContainersRequestCdnItemProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersRequestCdnItemRegion?), TypeInfoPropertyName = "NullableCreateContainersRequestCdnItemRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersRequestRegion?), TypeInfoPropertyName = "NullableCreateContainersRequestRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionProvider?), TypeInfoPropertyName = "NullablePutContainersSettingsRequestCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionRegion?), TypeInfoPropertyName = "NullablePutContainersSettingsRequestCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersTreeSort?), TypeInfoPropertyName = "NullableGetContainersTreeSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersTreeDirection?), TypeInfoPropertyName = "NullableGetContainersTreeDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseRepoType?), TypeInfoPropertyName = "NullableGetContainersResponseRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseCdnRegionProvider?), TypeInfoPropertyName = "NullableGetContainersResponseCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseCdnRegionRegion?), TypeInfoPropertyName = "NullableGetContainersResponseCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider?), TypeInfoPropertyName = "NullablePutContainersSettingsResponseCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion?), TypeInfoPropertyName = "NullablePutContainersSettingsResponseCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItemRepoType?), TypeInfoPropertyName = "NullableGetContainersResponseItemRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItemCdnRegionProvider?), TypeInfoPropertyName = "NullableGetContainersResponseItemCdnRegionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersResponseItemCdnRegionRegion?), TypeInfoPropertyName = "NullableGetContainersResponseItemCdnRegionRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetContainersTreeResponseItemType?), TypeInfoPropertyName = "NullableGetContainersTreeResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateContainersPathsInfoResponseItemType?), TypeInfoPropertyName = "NullableCreateContainersPathsInfoResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateContainersRequestCdnItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PutContainersSettingsRequestCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetContainersResponseCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PutContainersSettingsResponseCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetContainersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetContainersResponseItemCdnRegion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateContainersBatchResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateContainersBatchResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetContainersTreeResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateContainersPathsInfoResponseItem>))]
    internal sealed partial class ContainersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContainersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ContainersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ContainersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::HuggingFace.CreateContainersRequestCdnItemProvider)

                    || typeToConvert == typeof(global::HuggingFace.CreateContainersRequestCdnItemProvider?)

                    || typeToConvert == typeof(global::HuggingFace.CreateContainersRequestCdnItemRegion)

                    || typeToConvert == typeof(global::HuggingFace.CreateContainersRequestCdnItemRegion?)

                    || typeToConvert == typeof(global::HuggingFace.CreateContainersRequestRegion)

                    || typeToConvert == typeof(global::HuggingFace.CreateContainersRequestRegion?)

                    || typeToConvert == typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionProvider)

                    || typeToConvert == typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionProvider?)

                    || typeToConvert == typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionRegion)

                    || typeToConvert == typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionRegion?)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersTreeSort)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersTreeSort?)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersTreeDirection)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersTreeDirection?)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseRepoType)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseRepoType?)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseCdnRegionProvider)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseCdnRegionProvider?)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseCdnRegionRegion)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseCdnRegionRegion?)

                    || typeToConvert == typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider)

                    || typeToConvert == typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider?)

                    || typeToConvert == typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion)

                    || typeToConvert == typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion?)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemRepoType)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemRepoType?)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemCdnRegionProvider)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemCdnRegionProvider?)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemCdnRegionRegion)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemCdnRegionRegion?)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersTreeResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetContainersTreeResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateContainersPathsInfoResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.CreateContainersPathsInfoResponseItemType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateContainersRequestCdnItemProvider))
                {
                    return new global::HuggingFace.JsonConverters.CreateContainersRequestCdnItemProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateContainersRequestCdnItemProvider?))
                {
                    return new global::HuggingFace.JsonConverters.CreateContainersRequestCdnItemProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateContainersRequestCdnItemRegion))
                {
                    return new global::HuggingFace.JsonConverters.CreateContainersRequestCdnItemRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateContainersRequestCdnItemRegion?))
                {
                    return new global::HuggingFace.JsonConverters.CreateContainersRequestCdnItemRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateContainersRequestRegion))
                {
                    return new global::HuggingFace.JsonConverters.CreateContainersRequestRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateContainersRequestRegion?))
                {
                    return new global::HuggingFace.JsonConverters.CreateContainersRequestRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionProvider))
                {
                    return new global::HuggingFace.JsonConverters.PutContainersSettingsRequestCdnRegionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionProvider?))
                {
                    return new global::HuggingFace.JsonConverters.PutContainersSettingsRequestCdnRegionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionRegion))
                {
                    return new global::HuggingFace.JsonConverters.PutContainersSettingsRequestCdnRegionRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutContainersSettingsRequestCdnRegionRegion?))
                {
                    return new global::HuggingFace.JsonConverters.PutContainersSettingsRequestCdnRegionRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersTreeSort))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersTreeSortJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersTreeSort?))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersTreeSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersTreeDirection))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersTreeDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersTreeDirection?))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersTreeDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseRepoType))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseRepoType?))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseCdnRegionProvider))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseCdnRegionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseCdnRegionProvider?))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseCdnRegionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseCdnRegionRegion))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseCdnRegionRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseCdnRegionRegion?))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseCdnRegionRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider))
                {
                    return new global::HuggingFace.JsonConverters.PutContainersSettingsResponseCdnRegionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionProvider?))
                {
                    return new global::HuggingFace.JsonConverters.PutContainersSettingsResponseCdnRegionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion))
                {
                    return new global::HuggingFace.JsonConverters.PutContainersSettingsResponseCdnRegionRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutContainersSettingsResponseCdnRegionRegion?))
                {
                    return new global::HuggingFace.JsonConverters.PutContainersSettingsResponseCdnRegionRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemRepoType))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseItemRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemRepoType?))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseItemRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemCdnRegionProvider))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseItemCdnRegionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemCdnRegionProvider?))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseItemCdnRegionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemCdnRegionRegion))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseItemCdnRegionRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersResponseItemCdnRegionRegion?))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersResponseItemCdnRegionRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersTreeResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersTreeResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetContainersTreeResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetContainersTreeResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateContainersPathsInfoResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.CreateContainersPathsInfoResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateContainersPathsInfoResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateContainersPathsInfoResponseItemTypeNullableJsonConverter();
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
                    0 => new ContainersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}