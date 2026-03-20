#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {

        /// <summary>
        /// Get SCIM Schemas<br/>
        /// Returns the SCIM 2.0 schema definitions for User and Group resources.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem6>> GetOrganizationsByNameScimV2SchemasAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}