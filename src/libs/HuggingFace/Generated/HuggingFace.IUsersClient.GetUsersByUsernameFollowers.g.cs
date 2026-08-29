#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List user followers
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cursor">
        /// Cursor for pagination
        /// </param>
        /// <param name="limit">
        /// Max number of followers to return<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>>> GetUsersByUsernameFollowersAsync(
            string username,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowersExpandItem>? expand = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List user followers
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cursor">
        /// Cursor for pagination
        /// </param>
        /// <param name="limit">
        /// Max number of followers to return<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetUsersFollowersResponseItemVariant1, global::HuggingFace.GetUsersFollowersResponseItemVariant2>>>> GetUsersByUsernameFollowersAsResponseAsync(
            string username,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::HuggingFace.GetUsersFollowersExpandItem>? expand = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}