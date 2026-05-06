#nullable enable

namespace HuggingFace
{
    public partial interface IBucketsClient
    {
        /// <summary>
        /// Batch file operations<br/>
        /// Accepts NDJSON (newline-delimited JSON) where each line is an addFile, copyFile, or deleteFile instruction.<br/>
        /// All add/copy operations must come before all delete operations.<br/>
        /// JSON-lines payload:<br/>
        /// ```json<br/>
        /// 	'{"type":"addFile","path":"...","xetHash":"...","mtime":...,"contentType":"..."}' +<br/>
        /// 	'{"type":"copyFile","path":"...","xetHash":"...","sourceRepoType":"...","sourceRepoId":"..."}' +<br/>
        /// 	'{"type":"deleteFile","path":"..."}'<br/>
        /// ```
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateBucketsBatchResponse> CreateBucketsByNamespaceByRepoBatchAsync(
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch file operations<br/>
        /// Accepts NDJSON (newline-delimited JSON) where each line is an addFile, copyFile, or deleteFile instruction.<br/>
        /// All add/copy operations must come before all delete operations.<br/>
        /// JSON-lines payload:<br/>
        /// ```json<br/>
        /// 	'{"type":"addFile","path":"...","xetHash":"...","mtime":...,"contentType":"..."}' +<br/>
        /// 	'{"type":"copyFile","path":"...","xetHash":"...","sourceRepoType":"...","sourceRepoId":"..."}' +<br/>
        /// 	'{"type":"deleteFile","path":"..."}'<br/>
        /// ```
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateBucketsBatchResponse>> CreateBucketsByNamespaceByRepoBatchAsResponseAsync(
            string @namespace,
            string repo,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}