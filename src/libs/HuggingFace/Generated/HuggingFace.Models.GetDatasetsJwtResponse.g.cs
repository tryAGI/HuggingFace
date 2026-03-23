
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetsJwtResponse
    {
        /// <summary>
        /// The JWT token with Bearer prefix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Token expiration timestamp in seconds (JWT standard)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp")]
        public int? Exp { get; set; }

        /// <summary>
        /// The JWT token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Encrypted JWT token and key ID (only if encrypted=true was requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedToken")]
        public global::HuggingFace.GetDatasetsJwtResponseEncryptedToken? EncryptedToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsJwtResponse" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// The JWT token with Bearer prefix
        /// </param>
        /// <param name="exp">
        /// Token expiration timestamp in seconds (JWT standard)
        /// </param>
        /// <param name="token">
        /// The JWT token
        /// </param>
        /// <param name="encryptedToken">
        /// Encrypted JWT token and key ID (only if encrypted=true was requested)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDatasetsJwtResponse(
            string accessToken,
            string token,
            int? exp,
            global::HuggingFace.GetDatasetsJwtResponseEncryptedToken? encryptedToken)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Exp = exp;
            this.EncryptedToken = encryptedToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsJwtResponse" /> class.
        /// </summary>
        public GetDatasetsJwtResponse()
        {
        }
    }
}