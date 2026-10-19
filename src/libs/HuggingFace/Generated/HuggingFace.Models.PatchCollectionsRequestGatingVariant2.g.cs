
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchCollectionsRequestGatingVariant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant1, global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant1, global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant2>? ProfileSharing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsRequestGatingVariant2" /> class.
        /// </summary>
        /// <param name="profileSharing">
        /// What Hugging Face shares with the repo authors when a user requests access. Defaults to the username and email.
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsRequestGatingVariant2(
            global::HuggingFace.AnyOf<global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant1, global::HuggingFace.PatchCollectionsRequestGatingVariant2ProfileSharingVariant2>? profileSharing,
            string mode = "auto")
        {
            this.Mode = mode;
            this.ProfileSharing = profileSharing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsRequestGatingVariant2" /> class.
        /// </summary>
        public PatchCollectionsRequestGatingVariant2()
        {
        }

    }
}