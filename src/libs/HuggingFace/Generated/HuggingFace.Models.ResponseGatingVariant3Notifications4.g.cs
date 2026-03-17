
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseGatingVariant3Notifications4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseGatingVariant3NotificationsMode4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseGatingVariant3NotificationsMode4 Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseGatingVariant3Notifications4" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseGatingVariant3Notifications4(
            global::HuggingFace.ResponseGatingVariant3NotificationsMode4 mode,
            string? email)
        {
            this.Mode = mode;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseGatingVariant3Notifications4" /> class.
        /// </summary>
        public ResponseGatingVariant3Notifications4()
        {
        }
    }
}