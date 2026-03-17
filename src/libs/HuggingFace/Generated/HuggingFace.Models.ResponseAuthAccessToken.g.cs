
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseAuthAccessToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseAuthAccessTokenRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseAuthAccessTokenRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fineGrained")]
        public global::HuggingFace.ResponseAuthAccessTokenFineGrained? FineGrained { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAuthAccessToken" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="role"></param>
        /// <param name="fineGrained"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAuthAccessToken(
            string displayName,
            global::HuggingFace.ResponseAuthAccessTokenRole role,
            global::System.DateTime createdAt,
            global::HuggingFace.ResponseAuthAccessTokenFineGrained? fineGrained)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Role = role;
            this.CreatedAt = createdAt;
            this.FineGrained = fineGrained;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAuthAccessToken" /> class.
        /// </summary>
        public ResponseAuthAccessToken()
        {
        }
    }
}