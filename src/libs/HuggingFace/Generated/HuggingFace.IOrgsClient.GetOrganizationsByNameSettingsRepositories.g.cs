#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List organization repositories with storage info
        /// </summary>
        /// <param name="name"></param>
        /// <param name="search">
        /// Filter repositories by name (case-insensitive substring match)
        /// </param>
        /// <param name="type">
        /// Filter by repository type
        /// </param>
        /// <param name="limit">
        /// Max number of repositories to return
        /// </param>
        /// <param name="sort">
        /// Sort field (default: storage)<br/>
        /// Default Value: storage
        /// </param>
        /// <param name="direction">
        /// Sort direction (default: desc)<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem>> GetOrganizationsByNameSettingsRepositoriesAsync(
            string name,
            string? search = default,
            global::HuggingFace.GetOrganizationsSettingsRepositoriesType? type = default,
            int? limit = default,
            global::HuggingFace.GetOrganizationsSettingsRepositoriesSort? sort = default,
            global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection? direction = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organization repositories with storage info
        /// </summary>
        /// <param name="name"></param>
        /// <param name="search">
        /// Filter repositories by name (case-insensitive substring match)
        /// </param>
        /// <param name="type">
        /// Filter by repository type
        /// </param>
        /// <param name="limit">
        /// Max number of repositories to return
        /// </param>
        /// <param name="sort">
        /// Sort field (default: storage)<br/>
        /// Default Value: storage
        /// </param>
        /// <param name="direction">
        /// Sort direction (default: desc)<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsSettingsRepositoriesResponseItem>>> GetOrganizationsByNameSettingsRepositoriesAsResponseAsync(
            string name,
            string? search = default,
            global::HuggingFace.GetOrganizationsSettingsRepositoriesType? type = default,
            int? limit = default,
            global::HuggingFace.GetOrganizationsSettingsRepositoriesSort? sort = default,
            global::HuggingFace.GetOrganizationsSettingsRepositoriesDirection? direction = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}