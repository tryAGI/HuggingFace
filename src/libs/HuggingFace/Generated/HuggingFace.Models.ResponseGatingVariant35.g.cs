
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseGatingVariant35
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
        public required global::HuggingFace.ResponseGatingVariant3Notifications5 Notifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseGatingVariant35" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="notifications"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseGatingVariant35(
            global::HuggingFace.ResponseGatingVariant3Notifications5 notifications,
            string mode = "manual")
        {
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseGatingVariant35" /> class.
        /// </summary>
        public ResponseGatingVariant35()
        {
        }
    }
}