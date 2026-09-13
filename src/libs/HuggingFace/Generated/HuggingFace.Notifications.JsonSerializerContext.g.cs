
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.OneOf<global::HuggingFace.GetNotificationsResponseNotificationVariant1, global::HuggingFace.GetNotificationsResponseNotificationVariant2, global::HuggingFace.GetNotificationsResponseNotificationVariant3, global::HuggingFace.GetNotificationsResponseNotificationVariant4>>), TypeInfoPropertyName = "GetNotificationsResponseNotificationVariant4_aead50af1b168734")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetNotificationsResponseNotificationVariant1, global::HuggingFace.GetNotificationsResponseNotificationVariant2, global::HuggingFace.GetNotificationsResponseNotificationVariant3, global::HuggingFace.GetNotificationsResponseNotificationVariant4>), TypeInfoPropertyName = "GetNotificationsResponseNotificationVariant4_2dc13260934ff273")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.OneOf<global::HuggingFace.GetNotificationsResponseNotificationVariant1, global::HuggingFace.GetNotificationsResponseNotificationVariant2, global::HuggingFace.GetNotificationsResponseNotificationVariant3, global::HuggingFace.GetNotificationsResponseNotificationVariant4>?), TypeInfoPropertyName = "GetNotificationsResponseNotificationVariant4_7ddfe3c5ed9d456b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.OneOf<global::HuggingFace.GetNotificationsResponseNotificationVariant1, global::HuggingFace.GetNotificationsResponseNotificationVariant2, global::HuggingFace.GetNotificationsResponseNotificationVariant3, global::HuggingFace.GetNotificationsResponseNotificationVariant4>>), TypeInfoPropertyName = "GetNotificationsResponseNotificationVariant4_3b2a86ea426e71ac")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.RepoId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.RepoIdType), TypeInfoPropertyName = "RepoIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteNotificationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateNotificationsMarkAsReadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchSettingsNotificationsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchSettingsNotificationsRequestNotifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchSettingsWatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchSettingsWatchRequestDeleteItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchSettingsWatchRequestDeleteItemType), TypeInfoPropertyName = "PatchSettingsWatchRequestDeleteItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestAddItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchSettingsWatchRequestAddItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchSettingsWatchRequestAddItemType), TypeInfoPropertyName = "PatchSettingsWatchRequestAddItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsReadStatus), TypeInfoPropertyName = "GetNotificationsReadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsRepoType), TypeInfoPropertyName = "GetNotificationsRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsMention), TypeInfoPropertyName = "GetNotificationsMention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteNotificationsReadStatus), TypeInfoPropertyName = "DeleteNotificationsReadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteNotificationsRepoType), TypeInfoPropertyName = "DeleteNotificationsRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteNotificationsMention), TypeInfoPropertyName = "DeleteNotificationsMention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateNotificationsMarkAsReadReadStatus), TypeInfoPropertyName = "CreateNotificationsMarkAsReadReadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateNotificationsMarkAsReadRepoType), TypeInfoPropertyName = "CreateNotificationsMarkAsReadRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateNotificationsMarkAsReadMention), TypeInfoPropertyName = "CreateNotificationsMarkAsReadMention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant1Paper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussionParticipatingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussionParticipatingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant2Discussion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionStatus), TypeInfoPropertyName = "GetNotificationsResponseNotificationVariant2DiscussionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionParticipatingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionParticipatingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant3Post))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant3PostParticipatingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant3PostParticipatingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant4Blog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetNotificationsResponseNotificationVariant4BlogParticipatingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant4BlogParticipatingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.RepoIdType?), TypeInfoPropertyName = "NullableRepoIdType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchSettingsWatchRequestDeleteItemType?), TypeInfoPropertyName = "NullablePatchSettingsWatchRequestDeleteItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.PatchSettingsWatchRequestAddItemType?), TypeInfoPropertyName = "NullablePatchSettingsWatchRequestAddItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsReadStatus?), TypeInfoPropertyName = "NullableGetNotificationsReadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsRepoType?), TypeInfoPropertyName = "NullableGetNotificationsRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsMention?), TypeInfoPropertyName = "NullableGetNotificationsMention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteNotificationsReadStatus?), TypeInfoPropertyName = "NullableDeleteNotificationsReadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteNotificationsRepoType?), TypeInfoPropertyName = "NullableDeleteNotificationsRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.DeleteNotificationsMention?), TypeInfoPropertyName = "NullableDeleteNotificationsMention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateNotificationsMarkAsReadReadStatus?), TypeInfoPropertyName = "NullableCreateNotificationsMarkAsReadReadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateNotificationsMarkAsReadRepoType?), TypeInfoPropertyName = "NullableCreateNotificationsMarkAsReadRepoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.CreateNotificationsMarkAsReadMention?), TypeInfoPropertyName = "NullableCreateNotificationsMarkAsReadMention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionStatus?), TypeInfoPropertyName = "NullableGetNotificationsResponseNotificationVariant2DiscussionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PatchSettingsWatchRequestDeleteItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.PatchSettingsWatchRequestAddItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant1PaperDiscussionParticipatingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionParticipatingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant3PostParticipatingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HuggingFace.GetNotificationsResponseNotificationVariant4BlogParticipatingItem>))]
    internal sealed partial class NotificationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NotificationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static NotificationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private NotificationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetNotificationsResponseNotificationVariant1, global::HuggingFace.GetNotificationsResponseNotificationVariant2, global::HuggingFace.GetNotificationsResponseNotificationVariant3, global::HuggingFace.GetNotificationsResponseNotificationVariant4>());
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
                    typeToConvert == typeof(global::HuggingFace.RepoIdType)

                    || typeToConvert == typeof(global::HuggingFace.RepoIdType?)

                    || typeToConvert == typeof(global::HuggingFace.PatchSettingsWatchRequestDeleteItemType)

                    || typeToConvert == typeof(global::HuggingFace.PatchSettingsWatchRequestDeleteItemType?)

                    || typeToConvert == typeof(global::HuggingFace.PatchSettingsWatchRequestAddItemType)

                    || typeToConvert == typeof(global::HuggingFace.PatchSettingsWatchRequestAddItemType?)

                    || typeToConvert == typeof(global::HuggingFace.GetNotificationsReadStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetNotificationsReadStatus?)

                    || typeToConvert == typeof(global::HuggingFace.GetNotificationsRepoType)

                    || typeToConvert == typeof(global::HuggingFace.GetNotificationsRepoType?)

                    || typeToConvert == typeof(global::HuggingFace.GetNotificationsMention)

                    || typeToConvert == typeof(global::HuggingFace.GetNotificationsMention?)

                    || typeToConvert == typeof(global::HuggingFace.DeleteNotificationsReadStatus)

                    || typeToConvert == typeof(global::HuggingFace.DeleteNotificationsReadStatus?)

                    || typeToConvert == typeof(global::HuggingFace.DeleteNotificationsRepoType)

                    || typeToConvert == typeof(global::HuggingFace.DeleteNotificationsRepoType?)

                    || typeToConvert == typeof(global::HuggingFace.DeleteNotificationsMention)

                    || typeToConvert == typeof(global::HuggingFace.DeleteNotificationsMention?)

                    || typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadReadStatus)

                    || typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadReadStatus?)

                    || typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadRepoType)

                    || typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadRepoType?)

                    || typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadMention)

                    || typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadMention?)

                    || typeToConvert == typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionStatus)

                    || typeToConvert == typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::HuggingFace.RepoIdType))
                {
                    return new global::HuggingFace.JsonConverters.RepoIdTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.RepoIdType?))
                {
                    return new global::HuggingFace.JsonConverters.RepoIdTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchSettingsWatchRequestDeleteItemType))
                {
                    return new global::HuggingFace.JsonConverters.PatchSettingsWatchRequestDeleteItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchSettingsWatchRequestDeleteItemType?))
                {
                    return new global::HuggingFace.JsonConverters.PatchSettingsWatchRequestDeleteItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchSettingsWatchRequestAddItemType))
                {
                    return new global::HuggingFace.JsonConverters.PatchSettingsWatchRequestAddItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.PatchSettingsWatchRequestAddItemType?))
                {
                    return new global::HuggingFace.JsonConverters.PatchSettingsWatchRequestAddItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetNotificationsReadStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetNotificationsReadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetNotificationsReadStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetNotificationsReadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetNotificationsRepoType))
                {
                    return new global::HuggingFace.JsonConverters.GetNotificationsRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetNotificationsRepoType?))
                {
                    return new global::HuggingFace.JsonConverters.GetNotificationsRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetNotificationsMention))
                {
                    return new global::HuggingFace.JsonConverters.GetNotificationsMentionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetNotificationsMention?))
                {
                    return new global::HuggingFace.JsonConverters.GetNotificationsMentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.DeleteNotificationsReadStatus))
                {
                    return new global::HuggingFace.JsonConverters.DeleteNotificationsReadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.DeleteNotificationsReadStatus?))
                {
                    return new global::HuggingFace.JsonConverters.DeleteNotificationsReadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.DeleteNotificationsRepoType))
                {
                    return new global::HuggingFace.JsonConverters.DeleteNotificationsRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.DeleteNotificationsRepoType?))
                {
                    return new global::HuggingFace.JsonConverters.DeleteNotificationsRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.DeleteNotificationsMention))
                {
                    return new global::HuggingFace.JsonConverters.DeleteNotificationsMentionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.DeleteNotificationsMention?))
                {
                    return new global::HuggingFace.JsonConverters.DeleteNotificationsMentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadReadStatus))
                {
                    return new global::HuggingFace.JsonConverters.CreateNotificationsMarkAsReadReadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadReadStatus?))
                {
                    return new global::HuggingFace.JsonConverters.CreateNotificationsMarkAsReadReadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadRepoType))
                {
                    return new global::HuggingFace.JsonConverters.CreateNotificationsMarkAsReadRepoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadRepoType?))
                {
                    return new global::HuggingFace.JsonConverters.CreateNotificationsMarkAsReadRepoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadMention))
                {
                    return new global::HuggingFace.JsonConverters.CreateNotificationsMarkAsReadMentionJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.CreateNotificationsMarkAsReadMention?))
                {
                    return new global::HuggingFace.JsonConverters.CreateNotificationsMarkAsReadMentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionStatus))
                {
                    return new global::HuggingFace.JsonConverters.GetNotificationsResponseNotificationVariant2DiscussionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::HuggingFace.GetNotificationsResponseNotificationVariant2DiscussionStatus?))
                {
                    return new global::HuggingFace.JsonConverters.GetNotificationsResponseNotificationVariant2DiscussionStatusNullableJsonConverter();
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
                    0 => new NotificationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}