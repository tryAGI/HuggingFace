#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Create a scheduled job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response174> CreateScheduledJobsByNamespaceAsync(
            string @namespace,

            global::HuggingFace.Request88 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a scheduled job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="jobSpec"></param>
        /// <param name="schedule">
        /// CRON schedule expression (e.g., '0 9 * * 1' for 9 AM every Monday).
        /// </param>
        /// <param name="suspend">
        /// Whether the scheduled job is suspended (paused)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="concurrency">
        /// Whether multiple instances of this job can run concurrently<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response174> CreateScheduledJobsByNamespaceAsync(
            string @namespace,
            global::HuggingFace.RequestJobSpec jobSpec,
            string schedule,
            bool? suspend = default,
            bool? concurrency = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}