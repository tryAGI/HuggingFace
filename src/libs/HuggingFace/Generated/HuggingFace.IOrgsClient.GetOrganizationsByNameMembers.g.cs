#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get organization members<br/>
        /// Get a list of members for the organization with optional search and pagination.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="search"></param>
        /// <param name="email"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 500
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsMembersResponseItem>> GetOrganizationsByNameMembersAsync(
            string name,
            string? search = default,
            string? email = default,
            string? cursor = default,
            int? limit = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization members<br/>
        /// Get a list of members for the organization with optional search and pagination.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="search"></param>
        /// <param name="email"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 500
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsMembersResponseItem>>> GetOrganizationsByNameMembersAsResponseAsync(
            string name,
            string? search = default,
            string? email = default,
            string? cursor = default,
            int? limit = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}