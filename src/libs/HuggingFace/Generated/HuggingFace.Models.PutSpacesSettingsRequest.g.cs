
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PutSpacesSettingsRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PutSpacesSettingsRequestVisibilityJsonConverter))]
        public global::HuggingFace.PutSpacesSettingsRequestVisibility? Visibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionsDisabled")]
        public bool? DiscussionsDisabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionsSorting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PutSpacesSettingsRequestDiscussionsSortingJsonConverter))]
        public global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting? DiscussionsSorting { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gated")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, global::HuggingFace.PutSpacesSettingsRequestGated?>))]
        public global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsRequestGated?>? Gated { get; set; }

        /// <summary>
        /// If true, members of the owning org (except admins) must also go through the gated access-request flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgMembersGated")]
        public bool? OrgMembersGated { get; set; }

        /// <summary>
        /// What Hugging Face shares with the repo authors when a user requests access. Defaults to the username and email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatedProfileSharing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant1, global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant1, global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant2>? GatedProfileSharing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatedNotificationsEmail")]
        public string? GatedNotificationsEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gatedNotificationsMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PutSpacesSettingsRequestGatedNotificationsModeJsonConverter))]
        public global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode? GatedNotificationsMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSpacesSettingsRequest" /> class.
        /// </summary>
        /// <param name="private"></param>
        /// <param name="visibility">
        /// Repository visibility. `protected` is only supported for Spaces.
        /// </param>
        /// <param name="discussionsDisabled"></param>
        /// <param name="discussionsSorting"></param>
        /// <param name="gated"></param>
        /// <param name="orgMembersGated">
        /// If true, members of the owning org (except admins) must also go through the gated access-request flow.
        /// </param>
        /// <param name="gatedProfileSharing">
        /// What Hugging Face shares with the repo authors when a user requests access. Defaults to the username and email.
        /// </param>
        /// <param name="gatedNotificationsEmail"></param>
        /// <param name="gatedNotificationsMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutSpacesSettingsRequest(
            bool? @private,
            global::HuggingFace.PutSpacesSettingsRequestVisibility? visibility,
            bool? discussionsDisabled,
            global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting? discussionsSorting,
            global::HuggingFace.AnyOf<bool?, global::HuggingFace.PutSpacesSettingsRequestGated?>? gated,
            bool? orgMembersGated,
            global::HuggingFace.AnyOf<global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant1, global::HuggingFace.PutSpacesSettingsRequestGatedProfileSharingVariant2>? gatedProfileSharing,
            string? gatedNotificationsEmail,
            global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode? gatedNotificationsMode)
        {
            this.Private = @private;
            this.Visibility = visibility;
            this.DiscussionsDisabled = discussionsDisabled;
            this.DiscussionsSorting = discussionsSorting;
            this.Gated = gated;
            this.OrgMembersGated = orgMembersGated;
            this.GatedProfileSharing = gatedProfileSharing;
            this.GatedNotificationsEmail = gatedNotificationsEmail;
            this.GatedNotificationsMode = gatedNotificationsMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSpacesSettingsRequest" /> class.
        /// </summary>
        public PutSpacesSettingsRequest()
        {
        }

    }
}