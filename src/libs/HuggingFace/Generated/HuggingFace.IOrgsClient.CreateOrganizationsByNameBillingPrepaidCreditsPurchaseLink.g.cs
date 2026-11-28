#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Credits purchase link<br/>
        /// Get a link to the org billing page with a credits purchase prefilled, also sent to the requesting user by email. Nothing is charged until they confirm the purchase on that page.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsBillingPrepaidCreditsPurchaseLinkResponse> CreateOrganizationsByNameBillingPrepaidCreditsPurchaseLinkAsync(
            string name,

            global::HuggingFace.CreateOrganizationsBillingPrepaidCreditsPurchaseLinkRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Credits purchase link<br/>
        /// Get a link to the org billing page with a credits purchase prefilled, also sent to the requesting user by email. Nothing is charged until they confirm the purchase on that page.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOrganizationsBillingPrepaidCreditsPurchaseLinkResponse>> CreateOrganizationsByNameBillingPrepaidCreditsPurchaseLinkAsResponseAsync(
            string name,

            global::HuggingFace.CreateOrganizationsBillingPrepaidCreditsPurchaseLinkRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Credits purchase link<br/>
        /// Get a link to the org billing page with a credits purchase prefilled, also sent to the requesting user by email. Nothing is charged until they confirm the purchase on that page.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amountUsd"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsBillingPrepaidCreditsPurchaseLinkResponse> CreateOrganizationsByNameBillingPrepaidCreditsPurchaseLinkAsync(
            string name,
            int amountUsd,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}