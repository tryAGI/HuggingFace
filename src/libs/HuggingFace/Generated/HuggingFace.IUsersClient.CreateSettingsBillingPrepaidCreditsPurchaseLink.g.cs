#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Credits purchase link<br/>
        /// Get a link to the billing page with a credits purchase prefilled, also sent to the user by email. Nothing is charged until the user confirms the purchase on that page.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsBillingPrepaidCreditsPurchaseLinkResponse> CreateSettingsBillingPrepaidCreditsPurchaseLinkAsync(

            global::HuggingFace.CreateSettingsBillingPrepaidCreditsPurchaseLinkRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Credits purchase link<br/>
        /// Get a link to the billing page with a credits purchase prefilled, also sent to the user by email. Nothing is charged until the user confirms the purchase on that page.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateSettingsBillingPrepaidCreditsPurchaseLinkResponse>> CreateSettingsBillingPrepaidCreditsPurchaseLinkAsResponseAsync(

            global::HuggingFace.CreateSettingsBillingPrepaidCreditsPurchaseLinkRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Credits purchase link<br/>
        /// Get a link to the billing page with a credits purchase prefilled, also sent to the user by email. Nothing is charged until the user confirms the purchase on that page.
        /// </summary>
        /// <param name="amountUsd"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSettingsBillingPrepaidCreditsPurchaseLinkResponse> CreateSettingsBillingPrepaidCreditsPurchaseLinkAsync(
            int amountUsd,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}