
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesType), TypeInfoPropertyName = "GetSettingsRepositoriesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesSort), TypeInfoPropertyName = "GetSettingsRepositoriesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesDirection), TypeInfoPropertyName = "GetSettingsRepositoriesDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowersExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowersExpandItem), TypeInfoPropertyName = "GetUsersFollowersExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsMcpResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsMcpResponseSpaceTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsMcpResponseSpaceTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsRepositoriesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemType), TypeInfoPropertyName = "GetSettingsRepositoriesResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemVisibility), TypeInfoPropertyName = "GetSettingsRepositoriesResponseItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriodSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriodSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsBillingUsageJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsBillingUsageJobsResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingUsageJobsResponseUsageJobDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsBillingUsageJobsResponseUsageJobDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersOverviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetUsersOverviewResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersOverviewResponseOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersOverviewResponseServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetUsersOverviewResponseHardwareItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersOverviewResponseHardwareItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersSocialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersSocialsResponseSocialHandles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersAvatarResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetUsersLikesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersLikesResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersLikesResponseItemRepo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersLikesResponseItemRepoType), TypeInfoPropertyName = "GetUsersLikesResponseItemRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>), TypeInfoPropertyName = "AnyOfGetUsersFollowersResponseItemVariant1GetUsersFollowersResponseItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowersResponseItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowersResponseItemVariant1Org>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowersResponseItemVariant1Org))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowersResponseItemVariant1ServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowersResponseItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowingResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingResponseItemOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowingResponseItemOrg))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowingResponseItemServiceAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType), TypeInfoPropertyName = "GetUsersFollowingOrgsResponseItemOrgType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan), TypeInfoPropertyName = "GetUsersFollowingOrgsResponseItemPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>), TypeInfoPropertyName = "DictionaryStringObject_System_Collections_Generic_Dictionary_string_object_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesType?), TypeInfoPropertyName = "NullableGetSettingsRepositoriesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesSort?), TypeInfoPropertyName = "NullableGetSettingsRepositoriesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesDirection?), TypeInfoPropertyName = "NullableGetSettingsRepositoriesDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowersExpandItem?), TypeInfoPropertyName = "NullableGetUsersFollowersExpandItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemType?), TypeInfoPropertyName = "NullableGetSettingsRepositoriesResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemVisibility?), TypeInfoPropertyName = "NullableGetSettingsRepositoriesResponseItemVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersLikesResponseItemRepoType?), TypeInfoPropertyName = "NullableGetUsersLikesResponseItemRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>?), TypeInfoPropertyName = "NullableAnyOfGetUsersFollowersResponseItemVariant1GetUsersFollowersResponseItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType?), TypeInfoPropertyName = "NullableGetUsersFollowingOrgsResponseItemOrgType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan?), TypeInfoPropertyName = "NullableGetUsersFollowingOrgsResponseItemPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowersExpandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsMcpResponseSpaceTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsRepositoriesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsBillingUsageByInferenceSessionResponsePeriodSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetSettingsBillingUsageJobsResponseUsageJobDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetUsersOverviewResponseOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetUsersOverviewResponseHardwareItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetUsersLikesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowersResponseItemVariant1Org>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingResponseItemOrg>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingOrgsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetUsersFollowingOrgsResponseItemEmailDomain>))]
    internal sealed partial class UsersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UsersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UsersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>());
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
                    typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesType)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesType?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesSort)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesSort?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesDirection)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesDirection?)

                    || typeToConvert == typeof(global::HuggingFace.GetUsersFollowersExpandItem)

                    || typeToConvert == typeof(global::HuggingFace.GetUsersFollowersExpandItem?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemType)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemType?)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemVisibility)

                    || typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemVisibility?)

                    || typeToConvert == typeof(global::HuggingFace.GetUsersLikesResponseItemRepoType)

                    || typeToConvert == typeof(global::HuggingFace.GetUsersLikesResponseItemRepoType?)

                    || typeToConvert == typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType)

                    || typeToConvert == typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType?)

                    || typeToConvert == typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan)

                    || typeToConvert == typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesType))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesType?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesSort))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesSortJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesSort?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesDirection))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesDirection?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetUsersFollowersExpandItem))
                {
                    return new global::HuggingFace.JsonConverters.GetUsersFollowersExpandItemJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetUsersFollowersExpandItem?))
                {
                    return new global::HuggingFace.JsonConverters.GetUsersFollowersExpandItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemType))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemType?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemVisibility))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesResponseItemVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetSettingsRepositoriesResponseItemVisibility?))
                {
                    return new global::HuggingFace.JsonConverters.GetSettingsRepositoriesResponseItemVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetUsersLikesResponseItemRepoType))
                {
                    return new global::HuggingFace.JsonConverters.GetUsersLikesResponseItemRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetUsersLikesResponseItemRepoType?))
                {
                    return new global::HuggingFace.JsonConverters.GetUsersLikesResponseItemRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType))
                {
                    return new global::HuggingFace.JsonConverters.GetUsersFollowingOrgsResponseItemOrgTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemOrgType?))
                {
                    return new global::HuggingFace.JsonConverters.GetUsersFollowingOrgsResponseItemOrgTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan))
                {
                    return new global::HuggingFace.JsonConverters.GetUsersFollowingOrgsResponseItemPlanJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetUsersFollowingOrgsResponseItemPlan?))
                {
                    return new global::HuggingFace.JsonConverters.GetUsersFollowingOrgsResponseItemPlanNullableJsonConverter();
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
                    0 => new UsersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::HuggingFace.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}