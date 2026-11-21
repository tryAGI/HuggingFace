
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateOrganizationsBillingPrepaidCreditsPurchaseLinkResponse
    {
        /// <summary>
        /// Billing page link that opens the prefilled purchase, to share with the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsBillingPrepaidCreditsPurchaseLinkResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// Billing page link that opens the prefilled purchase, to share with the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrganizationsBillingPrepaidCreditsPurchaseLinkResponse(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationsBillingPrepaidCreditsPurchaseLinkResponse" /> class.
        /// </summary>
        public CreateOrganizationsBillingPrepaidCreditsPurchaseLinkResponse()
        {
        }

    }
}