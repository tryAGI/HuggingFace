
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesRequestVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"platform"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = "platform";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant1" /> class.
        /// </summary>
        /// <param name="serviceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesRequestVariant1(
            string serviceId = "platform")
        {
            this.ServiceId = serviceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant1" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesRequestVariant1()
        {
        }
    }
}