#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// List jobs<br/>
        /// List of jobs for an entity
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="label">
        /// Filter jobs by label. Format: 'key=value' (e.g., 'environment=production').
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem28>> GetJobsByNamespaceAsync(
            string @namespace,
            string? label = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}