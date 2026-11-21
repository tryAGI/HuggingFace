
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetSettingsBillingCreditsResponse
    {
        /// <summary>
        /// Total credits balance, in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balanceUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BalanceUsd { get; set; }

        /// <summary>
        /// `prepaid` accounts can only use their credits, `postpaid` ones are billed for usage beyond them
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetSettingsBillingCreditsResponseBillingModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetSettingsBillingCreditsResponseBillingMode BillingMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingCreditsResponseBalance> Balances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsBillingCreditsResponse" /> class.
        /// </summary>
        /// <param name="balanceUsd">
        /// Total credits balance, in USD
        /// </param>
        /// <param name="billingMode">
        /// `prepaid` accounts can only use their credits, `postpaid` ones are billed for usage beyond them
        /// </param>
        /// <param name="balances"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSettingsBillingCreditsResponse(
            double balanceUsd,
            global::HuggingFace.GetSettingsBillingCreditsResponseBillingMode billingMode,
            global::System.Collections.Generic.IList<global::HuggingFace.GetSettingsBillingCreditsResponseBalance> balances)
        {
            this.BalanceUsd = balanceUsd;
            this.BillingMode = billingMode;
            this.Balances = balances ?? throw new global::System.ArgumentNullException(nameof(balances));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSettingsBillingCreditsResponse" /> class.
        /// </summary>
        public GetSettingsBillingCreditsResponse()
        {
        }

    }
}