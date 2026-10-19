
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCollectionsItemsResponseGatingVariant2Variant22
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"auto"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string Mode { get; set; } = "auto";

        /// <summary>
        /// What Hugging Face shares with the repo authors when a user requests access. Defaults to the username and email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profileSharing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant12, global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant22>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant12, global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant22>? ProfileSharing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseGatingVariant2Variant22" /> class.
        /// </summary>
        /// <param name="profileSharing">
        /// What Hugging Face shares with the repo authors when a user requests access. Defaults to the username and email.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsItemsResponseGatingVariant2Variant22(
            global::HuggingFace.AnyOf<global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant12, global::HuggingFace.CreateCollectionsItemsResponseGatingVariant2Variant2ProfileSharingVariant22>? profileSharing,
            string mode = "auto")
        {
            this.Mode = mode;
            this.ProfileSharing = profileSharing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseGatingVariant2Variant22" /> class.
        /// </summary>
        public CreateCollectionsItemsResponseGatingVariant2Variant22()
        {
        }

    }
}