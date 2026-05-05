#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Check upload method<br/>
        /// Check if a file should be uploaded through the Large File mechanism or directly.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateModelsPreuploadResponse> CreateModelsByNamespaceByRepoPreuploadByRevAsync(
            string @namespace,
            string repo,
            string rev,

            global::HuggingFace.CreateModelsPreuploadRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check upload method<br/>
        /// Check if a file should be uploaded through the Large File mechanism or directly.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateModelsPreuploadResponse>> CreateModelsByNamespaceByRepoPreuploadByRevAsResponseAsync(
            string @namespace,
            string repo,
            string rev,

            global::HuggingFace.CreateModelsPreuploadRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check upload method<br/>
        /// Check if a file should be uploaded through the Large File mechanism or directly.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="files"></param>
        /// <param name="gitAttributes">
        /// Provide this parameter if you plan to modify `.gitattributes` yourself at the same time as uploading LFS files. Note that this is not needed if you solely rely on automatic LFS detection from HF: the commit endpoint will automatically edit the `.gitattributes` file to track the files passed to its `lfsFiles` param.
        /// </param>
        /// <param name="gitIgnore">
        /// Content of the .gitignore file for the revision. Optional, otherwise takes the existing content of `.gitignore` for the revision.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateModelsPreuploadResponse> CreateModelsByNamespaceByRepoPreuploadByRevAsync(
            string @namespace,
            string repo,
            string rev,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateModelsPreuploadRequestFile> files,
            string? gitAttributes = default,
            string? gitIgnore = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}