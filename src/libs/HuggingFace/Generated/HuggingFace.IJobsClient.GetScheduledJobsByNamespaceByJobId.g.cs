#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {

        /// <summary>
        /// Get a scheduled job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response175> GetScheduledJobsByNamespaceByJobIdAsync(
            string @namespace,
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}