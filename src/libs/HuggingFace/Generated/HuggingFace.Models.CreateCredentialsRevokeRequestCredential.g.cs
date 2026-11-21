
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCredentialsRevokeRequestCredential
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessKeyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretAccessKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretAccessKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialsRevokeRequestCredential" /> class.
        /// </summary>
        /// <param name="accessKeyId"></param>
        /// <param name="secretAccessKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCredentialsRevokeRequestCredential(
            string accessKeyId,
            string secretAccessKey)
        {
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.SecretAccessKey = secretAccessKey ?? throw new global::System.ArgumentNullException(nameof(secretAccessKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialsRevokeRequestCredential" /> class.
        /// </summary>
        public CreateCredentialsRevokeRequestCredential()
        {
        }

    }
}