#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Duplicate a job<br/>
        /// Duplicate an existing job, re-using its spec
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response132> CreateJobsByNamespaceByJobIdDuplicateAsync(
            string @namespace,
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}