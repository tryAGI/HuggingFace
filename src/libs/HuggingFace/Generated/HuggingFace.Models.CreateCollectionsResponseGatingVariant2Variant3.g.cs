
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCollectionsResponseGatingVariant2Variant3
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"manual"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string Mode { get; set; } = "manual";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3Notifications Notifications { get; set; }

        /// <summary>
        /// What Hugging Face shares with the repo authors when a user requests access. Defaults to the username and email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileSharing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3ProfileSharingVariant1, global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3ProfileSharingVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3ProfileSharingVariant1, global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3ProfileSharingVariant2>? ProfileSharing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseGatingVariant2Variant3" /> class.
        /// </summary>
        /// <param name="notifications"></param>
        /// <param name="profileSharing">
        /// What Hugging Face shares with the repo authors when a user requests access. Defaults to the username and email.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsResponseGatingVariant2Variant3(
            global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3Notifications notifications,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3ProfileSharingVariant1, global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3ProfileSharingVariant2>? profileSharing,
            string mode = "manual")
        {
            this.Mode = mode;
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
            this.ProfileSharing = profileSharing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResponseGatingVariant2Variant3" /> class.
        /// </summary>
        public CreateCollectionsResponseGatingVariant2Variant3()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateCollectionsResponseGatingVariant2Variant3"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateCollectionsResponseGatingVariant2Variant3 FromNotifications(global::HuggingFace.CreateCollectionsResponseGatingVariant2Variant3Notifications notifications)
        {
            return new CreateCollectionsResponseGatingVariant2Variant3
            {
                Notifications = notifications,
            };
        }

    }
}