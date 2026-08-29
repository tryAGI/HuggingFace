#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List followed organizations
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cursor">
        /// Cursor for pagination
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItem>> GetUsersByUsernameFollowingOrgsAsync(
            string username,
            string? cursor = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List followed organizations
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cursor">
        /// Cursor for pagination
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowingOrgsResponseItem>>> GetUsersByUsernameFollowingOrgsAsResponseAsync(
            string username,
            string? cursor = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}