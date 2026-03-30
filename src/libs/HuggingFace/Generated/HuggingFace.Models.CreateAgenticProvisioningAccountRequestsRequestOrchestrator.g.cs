
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningAccountRequestsRequestOrchestrator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"stripe"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "stripe";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestOrchestratorStripe Stripe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsRequestOrchestrator" /> class.
        /// </summary>
        /// <param name="stripe"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningAccountRequestsRequestOrchestrator(
            global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestOrchestratorStripe stripe,
            string type = "stripe")
        {
            this.Type = type;
            this.Stripe = stripe ?? throw new global::System.ArgumentNullException(nameof(stripe));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsRequestOrchestrator" /> class.
        /// </summary>
        public CreateAgenticProvisioningAccountRequestsRequestOrchestrator()
        {
        }
    }
}