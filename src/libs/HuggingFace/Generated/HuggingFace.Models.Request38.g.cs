
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request38
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionsDisabled")]
        public bool? DiscussionsDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionsSorting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestDiscussionsSortingJsonConverter))]
        public global::HuggingFace.RequestDiscussionsSorting? DiscussionsSorting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.RequestGatedEnum2?>))]
        public global::HuggingFace.AnyOf<string, global::HuggingFace.RequestGatedEnum2?>? Gated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatedNotificationsEmail")]
        public string? GatedNotificationsEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatedNotificationsMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestGatedNotificationsModeJsonConverter))]
        public global::HuggingFace.RequestGatedNotificationsMode? GatedNotificationsMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request38" /> class.
        /// </summary>
        /// <param name="private"></param>
        /// <param name="discussionsDisabled"></param>
        /// <param name="discussionsSorting"></param>
        /// <param name="gated"></param>
        /// <param name="gatedNotificationsEmail"></param>
        /// <param name="gatedNotificationsMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request38(
            bool? @private,
            bool? discussionsDisabled,
            global::HuggingFace.RequestDiscussionsSorting? discussionsSorting,
            global::HuggingFace.AnyOf<string, global::HuggingFace.RequestGatedEnum2?>? gated,
            string? gatedNotificationsEmail,
            global::HuggingFace.RequestGatedNotificationsMode? gatedNotificationsMode)
        {
            this.Private = @private;
            this.DiscussionsDisabled = discussionsDisabled;
            this.DiscussionsSorting = discussionsSorting;
            this.Gated = gated;
            this.GatedNotificationsEmail = gatedNotificationsEmail;
            this.GatedNotificationsMode = gatedNotificationsMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request38" /> class.
        /// </summary>
        public Request38()
        {
        }
    }
}