#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Duplicate xet files<br/>
        /// Duplicate xet-stored LFS files from this repo (source) into another repo (target) by xet hash, without re-uploading file bytes. The caller must then commit the files with their sha256/size as usual.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponse> CreateSpacesByNamespaceByRepoLfsFilesDuplicateAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateSpacesLfsFilesDuplicateRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate xet files<br/>
        /// Duplicate xet-stored LFS files from this repo (source) into another repo (target) by xet hash, without re-uploading file bytes. The caller must then commit the files with their sha256/size as usual.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponse>> CreateSpacesByNamespaceByRepoLfsFilesDuplicateAsResponseAsync(
            string @namespace,
            string repo,

            global::HuggingFace.CreateSpacesLfsFilesDuplicateRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate xet files<br/>
        /// Duplicate xet-stored LFS files from this repo (source) into another repo (target) by xet hash, without re-uploading file bytes. The caller must then commit the files with their sha256/size as usual.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="target"></param>
        /// <param name="files"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSpacesLfsFilesDuplicateResponse> CreateSpacesByNamespaceByRepoLfsFilesDuplicateAsync(
            string @namespace,
            string repo,
            global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestTarget target,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesLfsFilesDuplicateRequestFile> files,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}