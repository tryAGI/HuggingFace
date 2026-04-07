
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesRequestVariant3Configuration
    {
        /// <summary>
        /// The amount of credits to purchase (defaults to $5)<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountUsd")]
        public double? AmountUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant3Configuration" /> class.
        /// </summary>
        /// <param name="amountUsd">
        /// The amount of credits to purchase (defaults to $5)<br/>
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesRequestVariant3Configuration(
            double? amountUsd)
        {
            this.AmountUsd = amountUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant3Configuration" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesRequestVariant3Configuration()
        {
        }
    }
}