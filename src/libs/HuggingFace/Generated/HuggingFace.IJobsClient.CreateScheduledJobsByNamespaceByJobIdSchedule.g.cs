#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {

        /// <summary>
        /// Update a scheduled job schedule
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response178> CreateScheduledJobsByNamespaceByJobIdScheduleAsync(
            string @namespace,
            string jobId,

            global::HuggingFace.Request89 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a scheduled job schedule
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobId"></param>
        /// <param name="schedule">
        /// CRON schedule expression (e.g., '0 9 * * 1' for 9 AM every Monday).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response178> CreateScheduledJobsByNamespaceByJobIdScheduleAsync(
            string @namespace,
            string jobId,
            string schedule,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}