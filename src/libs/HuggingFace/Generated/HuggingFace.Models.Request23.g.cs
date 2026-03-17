
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Initiate device authorization as per https://datatracker.ietf.org/doc/html/rfc8628#section-3.1
    /// </summary>
    public sealed partial class Request23
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request23" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request23(
            string clientId,
            string? scope)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request23" /> class.
        /// </summary>
        public Request23()
        {
        }
    }
}