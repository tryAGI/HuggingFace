
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateJobsRequestVariant1, global::HuggingFace.CreateJobsRequestVariant2>), TypeInfoPropertyName = "OneOfCreateJobsRequestVariant1CreateJobsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutJobsLabelsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutJobsExposeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateScheduledJobsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateScheduledJobsScheduleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutScheduledJobsLabelsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckPerms), TypeInfoPropertyName = "CreateJobsAuthCheckPerms2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckPerms2), TypeInfoPropertyName = "CreateJobsAuthCheckPerms22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>>), TypeInfoPropertyName = "AnyOfGetJobsStage2IListGetJobsStageItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsStage2), TypeInfoPropertyName = "GetJobsStage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsStageItem), TypeInfoPropertyName = "GetJobsStageItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetJobsCountStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsCountStageItem>>), TypeInfoPropertyName = "AnyOfGetJobsCountStage2IListGetJobsCountStageItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsCountStage2), TypeInfoPropertyName = "GetJobsCountStage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetJobsCountStageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsCountStageItem), TypeInfoPropertyName = "GetJobsCountStageItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckResponseNamespace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckResponseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckResponseNamespace2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckResponseUser2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetJobsHardwareResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsHardwareResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsHardwareResponseItemAccelerator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType), TypeInfoPropertyName = "GetJobsHardwareResponseItemAcceleratorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer), TypeInfoPropertyName = "GetJobsHardwareResponseItemAcceleratorManufacturer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetJobsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsCancelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsDuplicateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutJobsLabelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutJobsExposeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateScheduledJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetScheduledJobsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetScheduledJobsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetScheduledJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateScheduledJobsRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateScheduledJobsRunResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateScheduledJobsScheduleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PutScheduledJobsLabelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.CreateJobsRequestVariant1, global::HuggingFace.CreateJobsRequestVariant2>?), TypeInfoPropertyName = "NullableOneOfCreateJobsRequestVariant1CreateJobsRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckPerms?), TypeInfoPropertyName = "NullableCreateJobsAuthCheckPerms2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateJobsAuthCheckPerms2?), TypeInfoPropertyName = "NullableCreateJobsAuthCheckPerms22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>>?), TypeInfoPropertyName = "NullableAnyOfGetJobsStage2IListGetJobsStageItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsStage2?), TypeInfoPropertyName = "NullableGetJobsStage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsStageItem?), TypeInfoPropertyName = "NullableGetJobsStageItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetJobsCountStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsCountStageItem>>?), TypeInfoPropertyName = "NullableAnyOfGetJobsCountStage2IListGetJobsCountStageItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsCountStage2?), TypeInfoPropertyName = "NullableGetJobsCountStage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsCountStageItem?), TypeInfoPropertyName = "NullableGetJobsCountStageItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType?), TypeInfoPropertyName = "NullableGetJobsHardwareResponseItemAcceleratorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer?), TypeInfoPropertyName = "NullableGetJobsHardwareResponseItemAcceleratorManufacturer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.List<global::HuggingFace.GetJobsStageItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetJobsStageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetJobsCountStage2?, global::System.Collections.Generic.List<global::HuggingFace.GetJobsCountStageItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetJobsCountStageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetJobsHardwareResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetJobsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetScheduledJobsResponseItem>))]
    internal sealed partial class JobsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JobsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static JobsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private JobsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.CreateJobsRequestVariant1, global::HuggingFace.CreateJobsRequestVariant2>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>>());
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetJobsCountStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsCountStageItem>>());
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
                    typeToConvert == typeof(global::HuggingFace.CreateJobsAuthCheckPerms)

                    || typeToConvert == typeof(global::HuggingFace.CreateJobsAuthCheckPerms?)

                    || typeToConvert == typeof(global::HuggingFace.CreateJobsAuthCheckPerms2)

                    || typeToConvert == typeof(global::HuggingFace.CreateJobsAuthCheckPerms2?)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsStage2)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsStage2?)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsStageItem)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsStageItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsCountStage2)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsCountStage2?)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsCountStageItem)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsCountStageItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType?)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer)

                    || typeToConvert == typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.CreateJobsAuthCheckPerms))
                {
                    return new global::HuggingFace.JsonConverters.CreateJobsAuthCheckPermsJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateJobsAuthCheckPerms?))
                {
                    return new global::HuggingFace.JsonConverters.CreateJobsAuthCheckPermsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateJobsAuthCheckPerms2))
                {
                    return new global::HuggingFace.JsonConverters.CreateJobsAuthCheckPerms2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateJobsAuthCheckPerms2?))
                {
                    return new global::HuggingFace.JsonConverters.CreateJobsAuthCheckPerms2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsStage2))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsStage2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsStage2?))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsStage2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsStageItem))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsStageItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsStageItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsStageItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsCountStage2))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsCountStage2JsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsCountStage2?))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsCountStage2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsCountStageItem))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsCountStageItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsCountStageItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsCountStageItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsHardwareResponseItemAcceleratorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorType?))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsHardwareResponseItemAcceleratorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsHardwareResponseItemAcceleratorManufacturerJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetJobsHardwareResponseItemAcceleratorManufacturer?))
                {
                    return new global::HuggingFace.JsonConverters.GetJobsHardwareResponseItemAcceleratorManufacturerNullableJsonConverter();
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
                    0 => new JobsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::HuggingFace.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}