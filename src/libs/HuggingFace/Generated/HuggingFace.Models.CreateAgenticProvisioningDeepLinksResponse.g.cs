
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningDeepLinksResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Purpose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningDeepLinksResponse" /> class.
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="url"></param>
        /// <param name="expiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningDeepLinksResponse(
            string purpose,
            string url,
            string expiresAt)
        {
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningDeepLinksResponse" /> class.
        /// </summary>
        public CreateAgenticProvisioningDeepLinksResponse()
        {
        }
    }
}