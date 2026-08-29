
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCredentialsRevokeRequest
    {
        /// <summary>
        /// Raw access token values to invalidate, at most 1000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialsRevokeRequest" /> class.
        /// </summary>
        /// <param name="credentials">
        /// Raw access token values to invalidate, at most 1000.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCredentialsRevokeRequest(
            global::System.Collections.Generic.IList<string> credentials)
        {
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCredentialsRevokeRequest" /> class.
        /// </summary>
        public CreateCredentialsRevokeRequest()
        {
        }

    }
}