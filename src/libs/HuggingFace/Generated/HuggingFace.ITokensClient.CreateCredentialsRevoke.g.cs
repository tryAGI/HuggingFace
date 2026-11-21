#nullable enable

namespace HuggingFace
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Revoke leaked tokens<br/>
        /// Publicly invalidate leaked Hugging Face access tokens or S3 credentials. Possession of the raw token value, or of the S3 access key ID and secret, is the only proof required: no authentication is needed, and no rights over the owning account or org are necessary. Each raw token is fully invalidated. A leaked S3 credential is deleted and its paired token invalidated. The owning user is notified by email. Always returns 202, whether or not any of the provided tokens existed, so the response cannot be used to probe token validity.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateCredentialsRevokeAsync(

            global::HuggingFace.CreateCredentialsRevokeRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke leaked tokens<br/>
        /// Publicly invalidate leaked Hugging Face access tokens or S3 credentials. Possession of the raw token value, or of the S3 access key ID and secret, is the only proof required: no authentication is needed, and no rights over the owning account or org are necessary. Each raw token is fully invalidated. A leaked S3 credential is deleted and its paired token invalidated. The owning user is notified by email. Always returns 202, whether or not any of the provided tokens existed, so the response cannot be used to probe token validity.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> CreateCredentialsRevokeAsResponseAsync(

            global::HuggingFace.CreateCredentialsRevokeRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke leaked tokens<br/>
        /// Publicly invalidate leaked Hugging Face access tokens or S3 credentials. Possession of the raw token value, or of the S3 access key ID and secret, is the only proof required: no authentication is needed, and no rights over the owning account or org are necessary. Each raw token is fully invalidated. A leaked S3 credential is deleted and its paired token invalidated. The owning user is notified by email. Always returns 202, whether or not any of the provided tokens existed, so the response cannot be used to probe token validity.
        /// </summary>
        /// <param name="credentials">
        /// Raw access token values or S3 credentials (access key ID and secret) to invalidate, at most 1000.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateCredentialsRevokeAsync(
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<string, global::HuggingFace.CreateCredentialsRevokeRequestCredential>> credentials,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}