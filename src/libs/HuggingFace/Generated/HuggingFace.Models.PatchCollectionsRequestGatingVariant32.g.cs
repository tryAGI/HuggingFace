
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsRequestGatingVariant32
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
        public required global::HuggingFace.PatchCollectionsRequestGatingVariant3Notifications2 Notifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsRequestGatingVariant32" /> class.
        /// </summary>
        /// <param name="notifications"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsRequestGatingVariant32(
            global::HuggingFace.PatchCollectionsRequestGatingVariant3Notifications2 notifications,
            string mode = "manual")
        {
            this.Mode = mode;
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsRequestGatingVariant32" /> class.
        /// </summary>
        public PatchCollectionsRequestGatingVariant32()
        {
        }
    }
}