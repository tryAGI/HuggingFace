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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsScimV2SchemasResponse> GetOrganizationsByNameScimV2SchemasBySchemaIdAsync(
            string name,
            string schemaId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get SCIM Schema by ID<br/>
        /// Returns a single SCIM 2.0 schema definition by its schema URI.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="schemaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetOrganizationsScimV2SchemasResponse>> GetOrganizationsByNameScimV2SchemasBySchemaIdAsResponseAsync(
            string name,
            string schemaId,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}