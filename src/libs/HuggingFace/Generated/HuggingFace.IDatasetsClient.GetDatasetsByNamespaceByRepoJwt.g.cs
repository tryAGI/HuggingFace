#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Generate JWT<br/>
        /// Generate a JWT token for accessing a repository. Supports optional write access for spaces in dev mode, custom expiration, and encryption.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="write"></param>
        /// <param name="expiration">
        /// Requested expiration datetime, capped at the default (10 minutes with write, 24 hours for spaces, 1 hour otherwise). Use expires_in instead.
        /// </param>
        /// <param name="expiresIn">
        /// Requested lifetime in seconds, capped at the default (600s with write, 86400s for spaces, 3600s otherwise)
        /// </param>
        /// <param name="encrypted"></param>
        /// <param name="inferenceApi"></param>
        /// <param name="includeProStatus">
        /// Use billing_details instead.
        /// </param>
        /// <param name="billingDetails"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetDatasetsJwtResponse> GetDatasetsByNamespaceByRepoJwtAsync(
            string @namespace,
            string repo,
            object? write = default,
            global::System.DateTime? expiration = default,
            int? expiresIn = default,
            object? encrypted = default,
            object? inferenceApi = default,
            object? includeProStatus = default,
            object? billingDetails = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate JWT<br/>
        /// Generate a JWT token for accessing a repository. Supports optional write access for spaces in dev mode, custom expiration, and encryption.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="write"></param>
        /// <param name="expiration">
        /// Requested expiration datetime, capped at the default (10 minutes with write, 24 hours for spaces, 1 hour otherwise). Use expires_in instead.
        /// </param>
        /// <param name="expiresIn">
        /// Requested lifetime in seconds, capped at the default (600s with write, 86400s for spaces, 3600s otherwise)
        /// </param>
        /// <param name="encrypted"></param>
        /// <param name="inferenceApi"></param>
        /// <param name="includeProStatus">
        /// Use billing_details instead.
        /// </param>
        /// <param name="billingDetails"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetDatasetsJwtResponse>> GetDatasetsByNamespaceByRepoJwtAsResponseAsync(
            string @namespace,
            string repo,
            object? write = default,
            global::System.DateTime? expiration = default,
            int? expiresIn = default,
            object? encrypted = default,
            object? inferenceApi = default,
            object? includeProStatus = default,
            object? billingDetails = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}