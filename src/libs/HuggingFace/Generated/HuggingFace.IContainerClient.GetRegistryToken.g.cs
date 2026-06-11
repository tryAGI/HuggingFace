#nullable enable

namespace HuggingFace
{
    public partial interface IContainerClient
    {
        /// <summary>
        /// Registry token<br/>
        /// Mints a short-lived EdDSA JWT for the HuggingFace container registry, verifiable via the JWK at `/api/keys/jwt`.
        /// </summary>
        /// <param name="service">
        /// Registry service identifier — placed in the JWT `aud` claim.
        /// </param>
        /// <param name="scope">
        /// Docker Distribution scope(s), e.g. `repository:org/img:push,pull`. May be repeated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetRegistryTokenResponse> GetRegistryTokenAsync(
            string service,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? scope = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Registry token<br/>
        /// Mints a short-lived EdDSA JWT for the HuggingFace container registry, verifiable via the JWK at `/api/keys/jwt`.
        /// </summary>
        /// <param name="service">
        /// Registry service identifier — placed in the JWT `aud` claim.
        /// </param>
        /// <param name="scope">
        /// Docker Distribution scope(s), e.g. `repository:org/img:push,pull`. May be repeated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetRegistryTokenResponse>> GetRegistryTokenAsResponseAsync(
            string service,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? scope = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}