
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSettingsBillingPrepaidCreditsPurchaseLinkRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AmountUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsBillingPrepaidCreditsPurchaseLinkRequest" /> class.
        /// </summary>
        /// <param name="amountUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsBillingPrepaidCreditsPurchaseLinkRequest(
            int amountUsd)
        {
            this.AmountUsd = amountUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsBillingPrepaidCreditsPurchaseLinkRequest" /> class.
        /// </summary>
        public CreateSettingsBillingPrepaidCreditsPurchaseLinkRequest()
        {
        }

    }
}