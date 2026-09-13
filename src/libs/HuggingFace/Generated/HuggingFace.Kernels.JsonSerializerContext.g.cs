
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTargetType), TypeInfoPropertyName = "CreateKernelsLfsFilesDuplicateRequestTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsAccessRequestApproveRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsLikersExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsLikersExpandItem), TypeInfoPropertyName = "GetKernelsLikersExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsSort), TypeInfoPropertyName = "GetKernelsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsDirection), TypeInfoPropertyName = "GetKernelsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>), TypeInfoPropertyName = "AnyOfGetKernelsExpand2IListGetKernelsExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsExpand2), TypeInfoPropertyName = "GetKernelsExpand22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsExpandItem), TypeInfoPropertyName = "GetKernelsExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, string, string>), TypeInfoPropertyName = "AnyOfBooleanStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem), TypeInfoPropertyName = "GetKernelsResponseItemBuildMetadataCompatibilityTorchItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO), TypeInfoPropertyName = "GetKernelsResponseItemBuildMetadataCompatibilityO2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem), TypeInfoPropertyName = "GetKernelsResponseItemBuildMetadataCompatibilityArchItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType), TypeInfoPropertyName = "GetKernelsResponseItemBuildMetadataBackendType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType), TypeInfoPropertyName = "GetKernelsResponseItemBuildMetadataBackendHardwareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBuilder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie), TypeInfoPropertyName = "GetKernelsResponseItemSupportedDriverFamilie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetKernelsResponseGated?>), TypeInfoPropertyName = "AnyOfBooleanGetKernelsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseGated), TypeInfoPropertyName = "GetKernelsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetKernelsResponseAuthorDataVariant1, global::HuggingFace.GetKernelsResponseAuthorDataVariant2>), TypeInfoPropertyName = "OneOfGetKernelsResponseAuthorDataVariant1GetKernelsResponseAuthorDataVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant1Plan), TypeInfoPropertyName = "GetKernelsResponseAuthorDataVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan), TypeInfoPropertyName = "GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole), TypeInfoPropertyName = "GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseSupportedDriverFamilie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseSupportedDriverFamilie), TypeInfoPropertyName = "GetKernelsResponseSupportedDriverFamilie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetKernelsRevisionResponseGated?>), TypeInfoPropertyName = "AnyOfBooleanGetKernelsRevisionResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseGated), TypeInfoPropertyName = "GetKernelsRevisionResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1, global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2>), TypeInfoPropertyName = "OneOfGetKernelsRevisionResponseAuthorDataVariant1GetKernelsRevisionResponseAuthorDataVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1Plan), TypeInfoPropertyName = "GetKernelsRevisionResponseAuthorDataVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan), TypeInfoPropertyName = "GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole), TypeInfoPropertyName = "GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie), TypeInfoPropertyName = "GetKernelsRevisionResponseSupportedDriverFamilie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTargetType?), TypeInfoPropertyName = "NullableCreateKernelsLfsFilesDuplicateRequestTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsLikersExpandItem?), TypeInfoPropertyName = "NullableGetKernelsLikersExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsSort?), TypeInfoPropertyName = "NullableGetKernelsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsDirection?), TypeInfoPropertyName = "NullableGetKernelsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>?), TypeInfoPropertyName = "NullableAnyOfGetKernelsExpand2IListGetKernelsExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsExpand2?), TypeInfoPropertyName = "NullableGetKernelsExpand22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsExpandItem?), TypeInfoPropertyName = "NullableGetKernelsExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, string, string>?), TypeInfoPropertyName = "NullableAnyOfBooleanStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem?), TypeInfoPropertyName = "NullableGetKernelsResponseItemBuildMetadataCompatibilityTorchItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO?), TypeInfoPropertyName = "NullableGetKernelsResponseItemBuildMetadataCompatibilityO2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem?), TypeInfoPropertyName = "NullableGetKernelsResponseItemBuildMetadataCompatibilityArchItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType?), TypeInfoPropertyName = "NullableGetKernelsResponseItemBuildMetadataBackendType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType?), TypeInfoPropertyName = "NullableGetKernelsResponseItemBuildMetadataBackendHardwareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie?), TypeInfoPropertyName = "NullableGetKernelsResponseItemSupportedDriverFamilie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetKernelsResponseGated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanGetKernelsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseGated?), TypeInfoPropertyName = "NullableGetKernelsResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetKernelsResponseAuthorDataVariant1, global::HuggingFace.GetKernelsResponseAuthorDataVariant2>?), TypeInfoPropertyName = "NullableOneOfGetKernelsResponseAuthorDataVariant1GetKernelsResponseAuthorDataVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant1Plan?), TypeInfoPropertyName = "NullableGetKernelsResponseAuthorDataVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan?), TypeInfoPropertyName = "NullableGetKernelsResponseAuthorDataVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole?), TypeInfoPropertyName = "NullableGetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsResponseSupportedDriverFamilie?), TypeInfoPropertyName = "NullableGetKernelsResponseSupportedDriverFamilie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<bool?, global::HuggingFace.GetKernelsRevisionResponseGated?>?), TypeInfoPropertyName = "NullableAnyOfBooleanGetKernelsRevisionResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseGated?), TypeInfoPropertyName = "NullableGetKernelsRevisionResponseGated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1, global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2>?), TypeInfoPropertyName = "NullableOneOfGetKernelsRevisionResponseAuthorDataVariant1GetKernelsRevisionResponseAuthorDataVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1Plan?), TypeInfoPropertyName = "NullableGetKernelsRevisionResponseAuthorDataVariant1Plan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan?), TypeInfoPropertyName = "NullableGetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole?), TypeInfoPropertyName = "NullableGetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie?), TypeInfoPropertyName = "NullableGetKernelsRevisionResponseSupportedDriverFamilie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsLikersExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.List<global::HuggingFace.GetKernelsExpandItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateKernelsLfsFilesDuplicateResponseFailedItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsResponseSupportedDriverFamilie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie>))]
    internal sealed partial class KernelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KernelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static KernelsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private KernelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>());
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.GetKernelsResponseGated?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetKernelsResponseAuthorDataVariant1, global::HuggingFace.GetKernelsResponseAuthorDataVariant2>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.GetKernelsRevisionResponseGated?>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1, global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2>());
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
                    typeToConvert == typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTargetType)

                    || typeToConvert == typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTargetType?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsLikersExpandItem)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsLikersExpandItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsSort)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsSort?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsDirection)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsDirection?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsExpand2)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsExpand2?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsExpandItem)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsExpandItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseGated)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseGated?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant1Plan)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant1Plan?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseSupportedDriverFamilie)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsResponseSupportedDriverFamilie?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseGated)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseGated?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1Plan)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1Plan?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie)

                    || typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTargetType))
                {
                    return new global::HuggingFace.JsonConverters.CreateKernelsLfsFilesDuplicateRequestTargetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateKernelsLfsFilesDuplicateRequestTargetType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateKernelsLfsFilesDuplicateRequestTargetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsLikersExpandItem))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsLikersExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsLikersExpandItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsLikersExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsSort))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsSortJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsSort?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsDirection))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsDirection?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsExpand2))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsExpand2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsExpand2?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsExpand2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsExpandItem))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsExpandItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataCompatibilityTorchItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityTorchItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataCompatibilityTorchItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataCompatibilityOJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityO?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataCompatibilityONullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataCompatibilityArchItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataCompatibilityArchItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataCompatibilityArchItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataBackendTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendType?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataBackendTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataBackendHardwareTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemBuildMetadataBackendHardwareType?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemBuildMetadataBackendHardwareTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemSupportedDriverFamilieJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseItemSupportedDriverFamilie?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseItemSupportedDriverFamilieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseGated))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseGatedJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseGated?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseGatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant1Plan))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseAuthorDataVariant1PlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant1Plan?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseAuthorDataVariant1PlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseAuthorDataVariant2PrimaryOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseSupportedDriverFamilie))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseSupportedDriverFamilieJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsResponseSupportedDriverFamilie?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsResponseSupportedDriverFamilieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseGated))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseGatedJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseGated?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseGatedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1Plan))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseAuthorDataVariant1PlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant1Plan?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseAuthorDataVariant1PlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseSupportedDriverFamilieJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetKernelsRevisionResponseSupportedDriverFamilie?))
                {
                    return new global::HuggingFace.JsonConverters.GetKernelsRevisionResponseSupportedDriverFamilieNullableJsonConverter();
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
                    0 => new KernelsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}