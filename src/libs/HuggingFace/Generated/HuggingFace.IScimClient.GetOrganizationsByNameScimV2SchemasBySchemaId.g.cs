#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get SCIM Schema by ID<br/>
        /// Returns a single SCIM 2.0 schema definition by its schema URI.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="schemaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response13> GetOrganizationsByNameScimV2SchemasBySchemaIdAsync(
            string name,
            string schemaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}