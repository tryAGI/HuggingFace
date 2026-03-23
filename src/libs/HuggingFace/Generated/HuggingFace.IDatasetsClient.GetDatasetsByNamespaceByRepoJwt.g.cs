#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Generate JWT<br/>
        /// Generate a JWT token for accessing a repository. Supports optional write access for spaces in dev mode, custom expiration, and encryption.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="write"></param>
        /// <param name="expiration"></param>
        /// <param name="encrypted"></param>
        /// <param name="inferenceApi"></param>
        /// <param name="includeProStatus"></param>
        /// <param name="billingDetails"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetDatasetsJwtResponse> GetDatasetsByNamespaceByRepoJwtAsync(
            string @namespace,
            string repo,
            object? write = default,
            global::System.DateTime? expiration = default,
            object? encrypted = default,
            object? inferenceApi = default,
            object? includeProStatus = default,
            object? billingDetails = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}