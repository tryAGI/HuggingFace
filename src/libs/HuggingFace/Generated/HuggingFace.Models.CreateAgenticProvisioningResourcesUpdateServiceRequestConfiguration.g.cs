
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesUpdateServiceRequestConfiguration
    {
        /// <summary>
        /// Amount in USD charged per top-up. Usage is billed in increments of rechargeAmountUsd — the prepaid-credit balance is topped back up to this amount whenever it runs low, starting with the very first charge at provisioning (minimum $15, defaults to $15).<br/>
        /// Default Value: 15
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
        /// Amount in USD charged per top-up. Usage is billed in increments of rechargeAmountUsd — the prepaid-credit balance is topped back up to this amount whenever it runs low, starting with the very first charge at provisioning (minimum $15, defaults to $15).<br/>
        /// Default Value: 15
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