#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {

        /// <summary>
        /// Get SCIM Resource Types<br/>
        /// Returns the list of SCIM 2.0 resource types supported by this server (User and Group).
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem5>> GetOrganizationsByNameScimV2ResourceTypesAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}