#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Retrieve user avatar<br/>
        /// This endpoint returns a JSON with the avatar URL for the user.<br/>
        /// If called with the `Sec-Fetch-Dest: image` header, it instead redirects to the avatar URL
        /// </summary>
        /// <param name="username"></param>
        /// <param name="redirect">
        /// Redirect to the avatar url instead of returning it
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetUsersAvatarResponse> GetUsersByUsernameAvatarAsync(
            string username,
            object? redirect = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}