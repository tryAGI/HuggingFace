
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Encrypted JWT token and key ID (only if encrypted=true was requested)
    /// </summary>
    public sealed partial class ResponseEncryptedToken
    {
        /// <summary>
        /// The encrypted JWT token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Encrypted { get; set; }

        /// <summary>
        /// Key ID used to encrypt the token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEncryptedToken" /> class.
        /// </summary>
        /// <param name="encrypted">
        /// The encrypted JWT token
        /// </param>
        /// <param name="keyId">
        /// Key ID used to encrypt the token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseEncryptedToken(
            string encrypted,
            string keyId)
        {
            this.Encrypted = encrypted ?? throw new global::System.ArgumentNullException(nameof(encrypted));
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEncryptedToken" /> class.
        /// </summary>
        public ResponseEncryptedToken()
        {
        }
    }
}