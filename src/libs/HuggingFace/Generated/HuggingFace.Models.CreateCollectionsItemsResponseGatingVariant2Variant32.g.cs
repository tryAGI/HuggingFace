
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCollectionsItemsResponseGatingVariant2Variant32
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
        public required global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3Notifications2 Notifications { get; set; }

        /// <summary>
        /// What Hugging Face shares with the repo authors when a user requests access. Defaults to the username and email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileSharing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant12, global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant22>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant12, global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant22>? ProfileSharing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseGatingVariant2Variant32" /> class.
        /// </summary>
        /// <param name="notifications"></param>
        /// <param name="profileSharing">
        /// What Hugging Face shares with the repo authors when a user requests access. Defaults to the username and email.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsItemsResponseGatingVariant2Variant32(
            global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3Notifications2 notifications,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant12, global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant22>? profileSharing,
            string mode = "manual")
        {
            this.Mode = mode;
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
            this.ProfileSharing = profileSharing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseGatingVariant2Variant32" /> class.
        /// </summary>
        public CreateCollectionsItemsResponseGatingVariant2Variant32()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateCollectionsItemsResponseGatingVariant2Variant32"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateCollectionsItemsResponseGatingVariant2Variant32 FromNotifications(global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant3Notifications2 notifications)
        {
            return new CreateCollectionsItemsResponseGatingVariant2Variant32
            {
                Notifications = notifications,
            };
        }

    }
}