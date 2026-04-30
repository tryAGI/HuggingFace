
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesRequestVariant4Configuration
    {
        /// <summary>
        /// Optional pay-as-you-go auto top-up ceiling, in USD. If set, usage above the plan's included quota is billed via the shared payment token (minimum $15). If omitted, the plan's included quota is a hard cap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rechargeAmountUsd")]
        public double? RechargeAmountUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant4Configuration" /> class.
        /// </summary>
        /// <param name="rechargeAmountUsd">
        /// Optional pay-as-you-go auto top-up ceiling, in USD. If set, usage above the plan's included quota is billed via the shared payment token (minimum $15). If omitted, the plan's included quota is a hard cap.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesRequestVariant4Configuration(
            double? rechargeAmountUsd)
        {
            this.RechargeAmountUsd = rechargeAmountUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant4Configuration" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesRequestVariant4Configuration()
        {
        }
    }
}