
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseAuth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        public global::HuggingFace.ResponseAuthAccessToken? AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public global::HuggingFace.ResponseAuthResource? Resource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAuth" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="accessToken"></param>
        /// <param name="expiresAt"></param>
        /// <param name="resource"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAuth(
            string type,
            global::HuggingFace.ResponseAuthAccessToken? accessToken,
            global::System.DateTime? expiresAt,
            global::HuggingFace.ResponseAuthResource? resource)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.AccessToken = accessToken;
            this.ExpiresAt = expiresAt;
            this.Resource = resource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAuth" /> class.
        /// </summary>
        public ResponseAuth()
        {
        }
    }
}