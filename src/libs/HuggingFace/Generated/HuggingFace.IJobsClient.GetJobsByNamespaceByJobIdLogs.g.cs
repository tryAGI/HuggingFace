#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Stream job logs<br/>
        /// Stream the logs of a job, using SSE
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetJobsByNamespaceByJobIdLogsAsync(
            string @namespace,
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}