
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSpacesCustomDomainRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesCustomDomainRequest" /> class.
        /// </summary>
        /// <param name="domain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpacesCustomDomainRequest(
            string domain)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesCustomDomainRequest" /> class.
        /// </summary>
        public CreateSpacesCustomDomainRequest()
        {
        }

    }
}