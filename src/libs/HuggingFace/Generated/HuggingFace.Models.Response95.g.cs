
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response95
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Repository visibility. `protected` is only supported for Spaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseVisibilityJsonConverter))]
        public global::HuggingFace.ResponseVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionsDisabled")]
        public bool? DiscussionsDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionsSorting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseDiscussionsSortingJsonConverter))]
        public global::HuggingFace.ResponseDiscussionsSorting? DiscussionsSorting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.ResponseGatedEnum2?>))]
        public global::HuggingFace.AnyOf<string, global::HuggingFace.ResponseGatedEnum2?>? Gated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatedNotificationsEmail")]
        public string? GatedNotificationsEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatedNotificationsMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseGatedNotificationsModeJsonConverter))]
        public global::HuggingFace.ResponseGatedNotificationsMode? GatedNotificationsMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response95" /> class.
        /// </summary>
        /// <param name="private"></param>
        /// <param name="visibility">
        /// Repository visibility. `protected` is only supported for Spaces.
        /// </param>
        /// <param name="discussionsDisabled"></param>
        /// <param name="discussionsSorting"></param>
        /// <param name="gated"></param>
        /// <param name="gatedNotificationsEmail"></param>
        /// <param name="gatedNotificationsMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response95(
            bool? @private,
            global::HuggingFace.ResponseVisibility? visibility,
            bool? discussionsDisabled,
            global::HuggingFace.ResponseDiscussionsSorting? discussionsSorting,
            global::HuggingFace.AnyOf<string, global::HuggingFace.ResponseGatedEnum2?>? gated,
            string? gatedNotificationsEmail,
            global::HuggingFace.ResponseGatedNotificationsMode? gatedNotificationsMode)
        {
            this.Private = @private;
            this.Visibility = visibility;
            this.DiscussionsDisabled = discussionsDisabled;
            this.DiscussionsSorting = discussionsSorting;
            this.Gated = gated;
            this.GatedNotificationsEmail = gatedNotificationsEmail;
            this.GatedNotificationsMode = gatedNotificationsMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response95" /> class.
        /// </summary>
        public Response95()
        {
        }
    }
}