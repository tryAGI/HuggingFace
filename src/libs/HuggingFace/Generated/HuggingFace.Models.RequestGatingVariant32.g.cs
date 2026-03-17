
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestGatingVariant32
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
        public required global::HuggingFace.RequestGatingVariant3Notifications2 Notifications { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGatingVariant32" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="notifications"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestGatingVariant32(
            global::HuggingFace.RequestGatingVariant3Notifications2 notifications,
            string mode = "manual")
        {
            this.Notifications = notifications ?? throw new global::System.ArgumentNullException(nameof(notifications));
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestGatingVariant32" /> class.
        /// </summary>
        public RequestGatingVariant32()
        {
        }
    }
}