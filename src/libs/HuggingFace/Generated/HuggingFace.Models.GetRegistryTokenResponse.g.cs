
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRegistryTokenResponse
    {
        /// <summary>
        /// EdDSA JWT signed by the moon JWT key, carrying `access[]`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Identical to `token` — Docker Distribution v2 accepts either field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// JWT lifetime in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresIn { get; set; }

        /// <summary>
        /// ISO-8601 timestamp at which the JWT was minted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issued_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime IssuedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegistryTokenResponse" /> class.
        /// </summary>
        /// <param name="token">
        /// EdDSA JWT signed by the moon JWT key, carrying `access[]`.
        /// </param>
        /// <param name="accessToken">
        /// Identical to `token` — Docker Distribution v2 accepts either field.
        /// </param>
        /// <param name="expiresIn">
        /// JWT lifetime in seconds.
        /// </param>
        /// <param name="issuedAt">
        /// ISO-8601 timestamp at which the JWT was minted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetRegistryTokenResponse(
            string token,
            string accessToken,
            int expiresIn,
            global::System.DateTime issuedAt)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.ExpiresIn = expiresIn;
            this.IssuedAt = issuedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRegistryTokenResponse" /> class.
        /// </summary>
        public GetRegistryTokenResponse()
        {
        }

    }
}