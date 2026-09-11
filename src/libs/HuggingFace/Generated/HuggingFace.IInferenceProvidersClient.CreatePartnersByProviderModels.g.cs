#nullable enable

namespace HuggingFace
{
    public partial interface IInferenceProvidersClient
    {
        /// <summary>
        /// Create provider mapping<br/>
        /// Register a model mapping for your inference provider. Requires a write token of the provider organization.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreatePartnersByProviderModelsAsync(
            global::HuggingFace.CreatePartnersModelsProvider provider,

            global::HuggingFace.AnyOf<global::HuggingFace.CreatePartnersModelsRequestVariant1, global::HuggingFace.CreatePartnersModelsRequestVariant2> request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create provider mapping<br/>
        /// Register a model mapping for your inference provider. Requires a write token of the provider organization.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreatePartnersByProviderModelsAsResponseAsync(
            global::HuggingFace.CreatePartnersModelsProvider provider,

            global::HuggingFace.AnyOf<global::HuggingFace.CreatePartnersModelsRequestVariant1, global::HuggingFace.CreatePartnersModelsRequestVariant2> request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create provider mapping<br/>
        /// Register a model mapping for your inference provider. Requires a write token of the provider organization.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreatePartnersByProviderModelsAsync(
            global::HuggingFace.CreatePartnersModelsProvider provider,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}