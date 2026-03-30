
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
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeepLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningDeepLinksResponse" /> class.
        /// </summary>
        /// <param name="deepLink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningDeepLinksResponse(
            string deepLink)
        {
            this.DeepLink = deepLink ?? throw new global::System.ArgumentNullException(nameof(deepLink));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningDeepLinksResponse" /> class.
        /// </summary>
        public CreateAgenticProvisioningDeepLinksResponse()
        {
        }
    }
}