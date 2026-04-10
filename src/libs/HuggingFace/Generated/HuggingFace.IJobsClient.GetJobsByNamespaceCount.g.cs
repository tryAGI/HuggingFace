#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Count jobs<br/>
        /// Count the number of jobs for an entity with optional status stage filter
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="stage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetJobsCountResponse> GetJobsByNamespaceCountAsync(
            string @namespace,
            global::HuggingFace.AnyOf<global::HuggingFace.GetJobsCountStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsCountStageItem>>? stage = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}