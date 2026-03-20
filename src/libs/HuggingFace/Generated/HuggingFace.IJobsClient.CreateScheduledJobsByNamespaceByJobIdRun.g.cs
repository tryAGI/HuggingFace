#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {

        /// <summary>
        /// Run job<br/>
        /// Trigger a scheduled job run. Trigger a scheduled job to run immediately. Throws an error if an instance is already running and job spec does not allow concurrent runs.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response176> CreateScheduledJobsByNamespaceByJobIdRunAsync(
            string @namespace,
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}