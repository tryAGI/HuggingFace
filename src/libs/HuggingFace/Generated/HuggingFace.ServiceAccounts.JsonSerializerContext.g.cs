
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission), TypeInfoPropertyName = "CreateOrganizationsServiceAccountsTokensRequestPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission), TypeInfoPropertyName = "CreateOrganizationsServiceAccountsTokensRequestRepoPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission), TypeInfoPropertyName = "PatchOrganizationsServiceAccountsTokensRequestPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission), TypeInfoPropertyName = "PatchOrganizationsServiceAccountsTokensRequestRepoPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole), TypeInfoPropertyName = "GetOrganizationsServiceAccountsResponseAccessTokenRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission), TypeInfoPropertyName = "GetOrganizationsServiceAccountsResponseAccessTokenPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission), TypeInfoPropertyName = "GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensResponseTokenInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRotateResponseTokenInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission?), TypeInfoPropertyName = "NullableCreateOrganizationsServiceAccountsTokensRequestPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission?), TypeInfoPropertyName = "NullableCreateOrganizationsServiceAccountsTokensRequestRepoPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission?), TypeInfoPropertyName = "NullablePatchOrganizationsServiceAccountsTokensRequestPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission?), TypeInfoPropertyName = "NullablePatchOrganizationsServiceAccountsTokensRequestRepoPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole?), TypeInfoPropertyName = "NullableGetOrganizationsServiceAccountsResponseAccessTokenRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission?), TypeInfoPropertyName = "NullableGetOrganizationsServiceAccountsResponseAccessTokenPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission?), TypeInfoPropertyName = "NullableGetOrganizationsServiceAccountsResponseAccessTokenRepoPermission2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission>))]
    internal sealed partial class ServiceAccountsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServiceAccountsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ServiceAccountsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ServiceAccountsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission)

                    || typeToConvert == typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission?)

                    || typeToConvert == typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission)

                    || typeToConvert == typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission?)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission?)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission)

                    || typeToConvert == typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission?)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission)

                    || typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission))
                {
                    return new global::HuggingFace.JsonConverters.CreateOrganizationsServiceAccountsTokensRequestPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestPermission?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOrganizationsServiceAccountsTokensRequestPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission))
                {
                    return new global::HuggingFace.JsonConverters.CreateOrganizationsServiceAccountsTokensRequestRepoPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateOrganizationsServiceAccountsTokensRequestRepoPermission?))
                {
                    return new global::HuggingFace.JsonConverters.CreateOrganizationsServiceAccountsTokensRequestRepoPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsServiceAccountsTokensRequestPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestPermission?))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsServiceAccountsTokensRequestPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsServiceAccountsTokensRequestRepoPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchOrganizationsServiceAccountsTokensRequestRepoPermission?))
                {
                    return new global::HuggingFace.JsonConverters.PatchOrganizationsServiceAccountsTokensRequestRepoPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsServiceAccountsResponseAccessTokenRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRole?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsServiceAccountsResponseAccessTokenRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsServiceAccountsResponseAccessTokenPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenPermission?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsServiceAccountsResponseAccessTokenPermissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermissionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission?))
                {
                    return new global::HuggingFace.JsonConverters.GetOrganizationsServiceAccountsResponseAccessTokenRepoPermissionNullableJsonConverter();
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
                    0 => new ServiceAccountsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}