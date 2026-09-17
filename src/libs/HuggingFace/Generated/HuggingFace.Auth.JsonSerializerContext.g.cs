
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenRole), TypeInfoPropertyName = "GetWhoamiV2ResponseAuthAccessTokenRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrained))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType), TypeInfoPropertyName = "GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem), TypeInfoPropertyName = "GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseBillingMode), TypeInfoPropertyName = "GetWhoamiV2ResponseBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode), TypeInfoPropertyName = "GetWhoamiV2ResponseOrgBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgPlan), TypeInfoPropertyName = "GetWhoamiV2ResponseOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg), TypeInfoPropertyName = "GetWhoamiV2ResponseOrgRoleInOrg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction), TypeInfoPropertyName = "GetWhoamiV2ResponseOrgSecurityRestriction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroupRole), TypeInfoPropertyName = "GetWhoamiV2ResponseOrgResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenRole?), TypeInfoPropertyName = "NullableGetWhoamiV2ResponseAuthAccessTokenRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType?), TypeInfoPropertyName = "NullableGetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem?), TypeInfoPropertyName = "NullableGetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseBillingMode?), TypeInfoPropertyName = "NullableGetWhoamiV2ResponseBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode?), TypeInfoPropertyName = "NullableGetWhoamiV2ResponseOrgBillingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgPlan?), TypeInfoPropertyName = "NullableGetWhoamiV2ResponseOrgPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg?), TypeInfoPropertyName = "NullableGetWhoamiV2ResponseOrgRoleInOrg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction?), TypeInfoPropertyName = "NullableGetWhoamiV2ResponseOrgSecurityRestriction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroupRole?), TypeInfoPropertyName = "NullableGetWhoamiV2ResponseOrgResourceGroupRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup>))]
    internal sealed partial class AuthSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AuthSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AuthSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenRole)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType?)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseBillingMode)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseBillingMode?)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode?)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgPlan?)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg?)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction?)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroupRole)

                    || typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroupRole?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenRole))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseAuthAccessTokenRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseAuthAccessTokenRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityType?))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseAuthAccessTokenFineGrainedScopedItemEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseAuthAccessTokenFineGrainedGlobalItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseBillingMode))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseBillingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseBillingMode?))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseBillingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgBillingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode?))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgBillingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgPlanNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgRoleInOrgJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg?))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgRoleInOrgNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgSecurityRestrictionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction?))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgSecurityRestrictionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroupRole))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgResourceGroupRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroupRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgResourceGroupRoleNullableJsonConverter();
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
                    0 => new AuthSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}