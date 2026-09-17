
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::HuggingFace.CreateSettingsInferenceProvidersRequest2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsInferenceProvidersRequest2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequestProvider), TypeInfoPropertyName = "CreateSettingsInferenceProvidersApiKeyRequestProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSettingsInferenceProvidersDefaultBillingEntityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutSettingsInferenceProvidersUsageLimitsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreatePartnersModelsRequestVariant1, global::HuggingFace.CreatePartnersModelsRequestVariant2>), TypeInfoPropertyName = "AnyOfCreatePartnersModelsRequestVariant1CreatePartnersModelsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Status), TypeInfoPropertyName = "CreatePartnersModelsRequestVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Task), TypeInfoPropertyName = "CreatePartnersModelsRequestVariant1Task2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Status), TypeInfoPropertyName = "CreatePartnersModelsRequestVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Task), TypeInfoPropertyName = "CreatePartnersModelsRequestVariant2Task2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutPartnersModelsStatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutPartnersModelsStatusRequestStatus), TypeInfoPropertyName = "PutPartnersModelsStatusRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPartnersModelsProvider), TypeInfoPropertyName = "GetPartnersModelsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPartnersModelsStatus), TypeInfoPropertyName = "GetPartnersModelsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsProvider), TypeInfoPropertyName = "CreatePartnersModelsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutPartnersModelsStatusProvider), TypeInfoPropertyName = "PutPartnersModelsStatusProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequestProvider?), TypeInfoPropertyName = "NullableCreateSettingsInferenceProvidersApiKeyRequestProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.CreatePartnersModelsRequestVariant1, global::HuggingFace.CreatePartnersModelsRequestVariant2>?), TypeInfoPropertyName = "NullableAnyOfCreatePartnersModelsRequestVariant1CreatePartnersModelsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Status?), TypeInfoPropertyName = "NullableCreatePartnersModelsRequestVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Task?), TypeInfoPropertyName = "NullableCreatePartnersModelsRequestVariant1Task2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Status?), TypeInfoPropertyName = "NullableCreatePartnersModelsRequestVariant2Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Task?), TypeInfoPropertyName = "NullableCreatePartnersModelsRequestVariant2Task2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutPartnersModelsStatusRequestStatus?), TypeInfoPropertyName = "NullablePutPartnersModelsStatusRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPartnersModelsProvider?), TypeInfoPropertyName = "NullableGetPartnersModelsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetPartnersModelsStatus?), TypeInfoPropertyName = "NullableGetPartnersModelsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreatePartnersModelsProvider?), TypeInfoPropertyName = "NullableCreatePartnersModelsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutPartnersModelsStatusProvider?), TypeInfoPropertyName = "NullablePutPartnersModelsStatusProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class InferenceProvidersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InferenceProvidersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static InferenceProvidersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private InferenceProvidersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreatePartnersModelsRequestVariant1, global::HuggingFace.CreatePartnersModelsRequestVariant2>());
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
                    typeToConvert == typeof(global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequestProvider)

                    || typeToConvert == typeof(global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequestProvider?)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Status)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Status?)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Task)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Task?)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Status)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Status?)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Task)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Task?)

                    || typeToConvert == typeof(global::HuggingFace.PutPartnersModelsStatusRequestStatus)

                    || typeToConvert == typeof(global::HuggingFace.PutPartnersModelsStatusRequestStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetPartnersModelsProvider)

                    || typeToConvert == typeof(global::HuggingFace.GetPartnersModelsProvider?)

                    || typeToConvert == typeof(global::HuggingFace.GetPartnersModelsStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetPartnersModelsStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsProvider)

                    || typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsProvider?)

                    || typeToConvert == typeof(global::HuggingFace.PutPartnersModelsStatusProvider)

                    || typeToConvert == typeof(global::HuggingFace.PutPartnersModelsStatusProvider?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequestProvider))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsInferenceProvidersApiKeyRequestProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateSettingsInferenceProvidersApiKeyRequestProvider?))
                {
                    return new global::HuggingFace.JsonConverters.CreateSettingsInferenceProvidersApiKeyRequestProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Status))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant1StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Status?))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant1StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Task))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant1TaskJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant1Task?))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant1TaskNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Status))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant2StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Status?))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant2StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Task))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant2TaskJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsRequestVariant2Task?))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant2TaskNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutPartnersModelsStatusRequestStatus))
                {
                    return new global::HuggingFace.JsonConverters.PutPartnersModelsStatusRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutPartnersModelsStatusRequestStatus?))
                {
                    return new global::HuggingFace.JsonConverters.PutPartnersModelsStatusRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPartnersModelsProvider))
                {
                    return new global::HuggingFace.JsonConverters.GetPartnersModelsProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPartnersModelsProvider?))
                {
                    return new global::HuggingFace.JsonConverters.GetPartnersModelsProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPartnersModelsStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetPartnersModelsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetPartnersModelsStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetPartnersModelsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsProvider))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreatePartnersModelsProvider?))
                {
                    return new global::HuggingFace.JsonConverters.CreatePartnersModelsProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutPartnersModelsStatusProvider))
                {
                    return new global::HuggingFace.JsonConverters.PutPartnersModelsStatusProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PutPartnersModelsStatusProvider?))
                {
                    return new global::HuggingFace.JsonConverters.PutPartnersModelsStatusProviderNullableJsonConverter();
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
                    0 => new InferenceProvidersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}