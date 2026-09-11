#nullable enable

namespace HuggingFace
{
    public partial interface IInferenceProvidersClient
    {
        /// <summary>
        /// List provider mappings<br/>
        /// List the model mappings of an inference provider.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetPartnersByProviderModelsAsync(
            global::HuggingFace.GetPartnersModelsProvider provider,
            global::HuggingFace.GetPartnersModelsStatus? status = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List provider mappings<br/>
        /// List the model mappings of an inference provider.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> GetPartnersByProviderModelsAsResponseAsync(
            global::HuggingFace.GetPartnersModelsProvider provider,
            global::HuggingFace.GetPartnersModelsStatus? status = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}