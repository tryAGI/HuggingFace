#nullable enable

namespace HuggingFace
{
    public partial interface IInferenceProvidersClient
    {
        /// <summary>
        /// Update mapping status<br/>
        /// Update the status of one of your inference provider's model mappings.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="mappingId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task PutPartnersByProviderModelsByMappingIdStatusAsync(
            global::HuggingFace.PutPartnersModelsStatusProvider provider,
            string mappingId,

            global::HuggingFace.PutPartnersModelsStatusRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update mapping status<br/>
        /// Update the status of one of your inference provider's model mappings.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="mappingId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> PutPartnersByProviderModelsByMappingIdStatusAsResponseAsync(
            global::HuggingFace.PutPartnersModelsStatusProvider provider,
            string mappingId,

            global::HuggingFace.PutPartnersModelsStatusRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update mapping status<br/>
        /// Update the status of one of your inference provider's model mappings.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="mappingId"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutPartnersByProviderModelsByMappingIdStatusAsync(
            global::HuggingFace.PutPartnersModelsStatusProvider provider,
            string mappingId,
            global::HuggingFace.PutPartnersModelsStatusRequestStatus status,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}