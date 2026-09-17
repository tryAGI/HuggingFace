
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthRegisterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthRegisterRequestTokenEndpointAuthMethod), TypeInfoPropertyName = "CreateOauthRegisterRequestTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthDeviceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthRegisterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthRegisterResponseGrantType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthRegisterResponseGrantType), TypeInfoPropertyName = "CreateOauthRegisterResponseGrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthRegisterResponseTokenEndpointAuthMethod), TypeInfoPropertyName = "CreateOauthRegisterResponseTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthDeviceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseHardwareItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseHardwareItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseBillingMode), TypeInfoPropertyName = "GetOauthUserinfoResponseBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgPlan), TypeInfoPropertyName = "GetOauthUserinfoResponseOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode), TypeInfoPropertyName = "GetOauthUserinfoResponseOrgBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg), TypeInfoPropertyName = "GetOauthUserinfoResponseOrgRoleInOrg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction), TypeInfoPropertyName = "GetOauthUserinfoResponseOrgSecurityRestriction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroupRole), TypeInfoPropertyName = "GetOauthUserinfoResponseOrgResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseHardwareItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseHardwareItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseBillingMode), TypeInfoPropertyName = "CreateOauthUserinfoResponseBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgPlan), TypeInfoPropertyName = "CreateOauthUserinfoResponseOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgBillingMode), TypeInfoPropertyName = "CreateOauthUserinfoResponseOrgBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgRoleInOrg), TypeInfoPropertyName = "CreateOauthUserinfoResponseOrgRoleInOrg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction), TypeInfoPropertyName = "CreateOauthUserinfoResponseOrgSecurityRestriction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroupRole), TypeInfoPropertyName = "CreateOauthUserinfoResponseOrgResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthRegisterRequestTokenEndpointAuthMethod?), TypeInfoPropertyName = "NullableCreateOauthRegisterRequestTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthRegisterResponseGrantType?), TypeInfoPropertyName = "NullableCreateOauthRegisterResponseGrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthRegisterResponseTokenEndpointAuthMethod?), TypeInfoPropertyName = "NullableCreateOauthRegisterResponseTokenEndpointAuthMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseBillingMode?), TypeInfoPropertyName = "NullableGetOauthUserinfoResponseBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgPlan?), TypeInfoPropertyName = "NullableGetOauthUserinfoResponseOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode?), TypeInfoPropertyName = "NullableGetOauthUserinfoResponseOrgBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg?), TypeInfoPropertyName = "NullableGetOauthUserinfoResponseOrgRoleInOrg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction?), TypeInfoPropertyName = "NullableGetOauthUserinfoResponseOrgSecurityRestriction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroupRole?), TypeInfoPropertyName = "NullableGetOauthUserinfoResponseOrgResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseBillingMode?), TypeInfoPropertyName = "NullableCreateOauthUserinfoResponseBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgPlan?), TypeInfoPropertyName = "NullableCreateOauthUserinfoResponseOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgBillingMode?), TypeInfoPropertyName = "NullableCreateOauthUserinfoResponseOrgBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgRoleInOrg?), TypeInfoPropertyName = "NullableCreateOauthUserinfoResponseOrgRoleInOrg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction?), TypeInfoPropertyName = "NullableCreateOauthUserinfoResponseOrgSecurityRestriction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroupRole?), TypeInfoPropertyName = "NullableCreateOauthUserinfoResponseOrgResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateOauthRegisterResponseGrantType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseHardwareItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseHardwareItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroup>))]
    internal sealed partial class OauthSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OauthSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OauthSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OauthSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterRequestTokenEndpointAuthMethod)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterRequestTokenEndpointAuthMethod?)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterResponseGrantType)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterResponseGrantType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterResponseTokenEndpointAuthMethod)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterResponseTokenEndpointAuthMethod?)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseBillingMode)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseBillingMode?)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode?)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg?)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction?)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroupRole)

                    || typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroupRole?)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseBillingMode)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseBillingMode?)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgBillingMode)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgBillingMode?)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgRoleInOrg)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgRoleInOrg?)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction?)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroupRole)

                    || typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroupRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterRequestTokenEndpointAuthMethod))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthRegisterRequestTokenEndpointAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterRequestTokenEndpointAuthMethod?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthRegisterRequestTokenEndpointAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterResponseGrantType))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthRegisterResponseGrantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterResponseGrantType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthRegisterResponseGrantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterResponseTokenEndpointAuthMethod))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthRegisterResponseTokenEndpointAuthMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthRegisterResponseTokenEndpointAuthMethod?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthRegisterResponseTokenEndpointAuthMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseBillingMode))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseBillingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseBillingMode?))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseBillingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgBillingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode?))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgBillingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgRoleInOrgJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg?))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgRoleInOrgNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgSecurityRestrictionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction?))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgSecurityRestrictionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroupRole))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgResourceGroupRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroupRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgResourceGroupRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseBillingMode))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseBillingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseBillingMode?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseBillingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgBillingMode))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgBillingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgBillingMode?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgBillingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgRoleInOrg))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgRoleInOrgJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgRoleInOrg?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgRoleInOrgNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgSecurityRestrictionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgSecurityRestriction?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgSecurityRestrictionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroupRole))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgResourceGroupRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOauthUserinfoResponseOrgResourceGroupRole?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseOrgResourceGroupRoleNullableJsonConverter();
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
                    0 => new OauthSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}