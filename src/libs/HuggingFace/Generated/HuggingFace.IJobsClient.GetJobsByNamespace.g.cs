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
        /// Filter jobs by label. Format: 'key=value' (e.g., 'environment=production'). Repeat the parameter to filter by several labels.
        /// </param>
        /// <param name="stage">
        /// Filter jobs by status stage. Repeat the parameter to filter by several stages.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor obtained from the `rel="next"` link of a previous response's `Link` header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetJobsResponseItem>> GetJobsByNamespaceAsync(
            string @namespace,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? label = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>>? stage = default,
            string? cursor = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List jobs<br/>
        /// List of jobs for an entity
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="label">
        /// Filter jobs by label. Format: 'key=value' (e.g., 'environment=production'). Repeat the parameter to filter by several labels.
        /// </param>
        /// <param name="stage">
        /// Filter jobs by status stage. Repeat the parameter to filter by several stages.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor obtained from the `rel="next"` link of a previous response's `Link` header.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetJobsResponseItem>>> GetJobsByNamespaceAsResponseAsync(
            string @namespace,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? label = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetJobsStage2?, global::System.Collections.Generic.IList<global::HuggingFace.GetJobsStageItem>>? stage = default,
            string? cursor = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}