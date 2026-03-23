#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get SCIM Service Provider Configuration<br/>
        /// Returns the SCIM 2.0 Service Provider configuration, describing the server's capabilities and supported authentication schemes.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsScimV2ServiceProviderConfigResponse> GetOrganizationsByNameScimV2ServiceProviderConfigAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}