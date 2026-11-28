
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationsBillingCreditsResponse
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOrganizationsBillingCreditsResponseBillingModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetOrganizationsBillingCreditsResponseBillingMode BillingMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balances")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingCreditsResponseBalance> Balances { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingCreditsResponse" /> class.
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
        public GetOrganizationsBillingCreditsResponse(
            double balanceUsd,
            global::HuggingFace.GetOrganizationsBillingCreditsResponseBillingMode billingMode,
            global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsBillingCreditsResponseBalance> balances)
        {
            this.BalanceUsd = balanceUsd;
            this.BillingMode = billingMode;
            this.Balances = balances ?? throw new global::System.ArgumentNullException(nameof(balances));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsBillingCreditsResponse" /> class.
        /// </summary>
        public GetOrganizationsBillingCreditsResponse()
        {
        }

    }
}