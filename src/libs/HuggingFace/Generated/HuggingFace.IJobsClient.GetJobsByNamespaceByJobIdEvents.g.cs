#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Stream job events<br/>
        /// Stream the events of a job, using SSE
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetJobsByNamespaceByJobIdEventsAsync(
            string @namespace,
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}