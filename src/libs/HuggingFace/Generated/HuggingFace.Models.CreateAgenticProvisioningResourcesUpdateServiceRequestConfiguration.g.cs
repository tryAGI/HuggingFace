
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesUpdateServiceRequestConfiguration
    {
        /// <summary>
        /// Set a number (USD, minimum $15) to enable or update pay-as-you-go auto top-up; pass null to disable; omit to leave it unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rechargeAmountUsd")]
        public double? RechargeAmountUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesUpdateServiceRequestConfiguration" /> class.
        /// </summary>
        /// <param name="rechargeAmountUsd">
        /// Set a number (USD, minimum $15) to enable or update pay-as-you-go auto top-up; pass null to disable; omit to leave it unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesUpdateServiceRequestConfiguration(
            double? rechargeAmountUsd)
        {
            this.RechargeAmountUsd = rechargeAmountUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesUpdateServiceRequestConfiguration" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesUpdateServiceRequestConfiguration()
        {
        }

    }
}