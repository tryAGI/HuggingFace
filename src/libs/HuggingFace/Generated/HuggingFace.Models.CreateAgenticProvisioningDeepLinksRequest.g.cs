
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningDeepLinksRequest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"dashboard"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        public string Purpose { get; set; } = "dashboard";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningDeepLinksRequest" /> class.
        /// </summary>
        /// <param name="purpose"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningDeepLinksRequest(
            string purpose = "dashboard")
        {
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningDeepLinksRequest" /> class.
        /// </summary>
        public CreateAgenticProvisioningDeepLinksRequest()
        {
        }
    }
}