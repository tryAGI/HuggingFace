#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get network security settings<br/>
        /// Get the network security settings for an organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponse> GetOrganizationsByNameSettingsNetworkSecurityAsync(
            string name,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get network security settings<br/>
        /// Get the network security settings for an organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetOrganizationsSettingsNetworkSecurityResponse>> GetOrganizationsByNameSettingsNetworkSecurityAsResponseAsync(
            string name,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}