#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List user likes<br/>
        /// List public repos liked by a user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="limit">
        /// Max number of likes to return
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination. Always check to see if more results, a page can be empty or not filled.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetUsersLikesResponseItem>> GetUsersByUsernameLikesAsync(
            string username,
            int? limit = default,
            string? cursor = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List user likes<br/>
        /// List public repos liked by a user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="limit">
        /// Max number of likes to return
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination. Always check to see if more results, a page can be empty or not filled.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetUsersLikesResponseItem>>> GetUsersByUsernameLikesAsResponseAsync(
            string username,
            int? limit = default,
            string? cursor = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}