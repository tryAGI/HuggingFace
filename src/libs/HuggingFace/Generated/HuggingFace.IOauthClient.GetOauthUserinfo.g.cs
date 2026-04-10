#nullable enable

namespace HuggingFace
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Get user info<br/>
        /// Get information about the user. Only available through oauth access tokens. Information varies depending on the scope of the oauth app and what permissions the user granted to the oauth app.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOauthUserinfoResponse> GetOauthUserinfoAsync(
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}