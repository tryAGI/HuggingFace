#nullable enable

namespace HuggingFace
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Get user info<br/>
        /// Get information about the user. Only available through oauth access tokens. Information varies depending on the scope of the oauth app and what permissions the user granted to the oauth app.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response48> CreateOauthUserinfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}