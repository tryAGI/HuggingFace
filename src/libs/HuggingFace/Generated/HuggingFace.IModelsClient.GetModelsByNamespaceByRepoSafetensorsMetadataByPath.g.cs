#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get safetensors metadata<br/>
        /// Get the parsed headers of all the shards of a sharded safetensors model in a single request, instead of reading the index and then the header of every shard.<br/>
        /// Only the `main` revision is served: the `ETag` is the commit sha of `main`, and requests with a matching `If-None-Match` get a 304. Returns 400 when the path isn't a `.safetensors.index.json` file and 422 when the files can't be parsed.<br/>
        /// The response is brotli-compressed when the client accepts it, otherwise gzip-compressed or plain JSON.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetModelsSafetensorsMetadataResponse> GetModelsByNamespaceByRepoSafetensorsMetadataByPathAsync(
            string @namespace,
            string repo,
            string path,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get safetensors metadata<br/>
        /// Get the parsed headers of all the shards of a sharded safetensors model in a single request, instead of reading the index and then the header of every shard.<br/>
        /// Only the `main` revision is served: the `ETag` is the commit sha of `main`, and requests with a matching `If-None-Match` get a 304. Returns 400 when the path isn't a `.safetensors.index.json` file and 422 when the files can't be parsed.<br/>
        /// The response is brotli-compressed when the client accepts it, otherwise gzip-compressed or plain JSON.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetModelsSafetensorsMetadataResponse>> GetModelsByNamespaceByRepoSafetensorsMetadataByPathAsResponseAsync(
            string @namespace,
            string repo,
            string path,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}