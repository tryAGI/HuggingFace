#nullable enable

namespace HuggingFace
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Register a new OAuth app
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOauthRegisterResponse> CreateOauthRegisterAsync(

            global::HuggingFace.CreateOauthRegisterRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a new OAuth app
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOauthRegisterResponse>> CreateOauthRegisterAsResponseAsync(

            global::HuggingFace.CreateOauthRegisterRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register a new OAuth app
        /// </summary>
        /// <param name="redirectUris"></param>
        /// <param name="clientName"></param>
        /// <param name="clientUri"></param>
        /// <param name="logoUri"></param>
        /// <param name="scope"></param>
        /// <param name="contacts"></param>
        /// <param name="tokenEndpointAuthMethod"></param>
        /// <param name="softwareId"></param>
        /// <param name="softwareVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOauthRegisterResponse> CreateOauthRegisterAsync(
            global::System.Collections.Generic.IList<string>? redirectUris = default,
            string? clientName = default,
            string? clientUri = default,
            string? logoUri = default,
            string? scope = default,
            global::System.Collections.Generic.IList<string>? contacts = default,
            global::HuggingFace.CreateOauthRegisterRequestTokenEndpointAuthMethod? tokenEndpointAuthMethod = default,
            string? softwareId = default,
            string? softwareVersion = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}