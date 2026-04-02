#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List folder content<br/>
        /// List the content of a repository tree, with pagination support.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="expand">
        /// If true, returns returns associated commit data for each entry and security scanner metadata.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="recursive">
        /// If true, returns the tree recursively.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// 1.000 by default, 100 by default for expand=true
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItem>> GetModelsByNamespaceByRepoTreeByRevByPathAsync(
            string @namespace,
            string repo,
            string rev,
            string path,
            object? expand = default,
            object? recursive = default,
            int? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List folder content<br/>
        /// List the content of a repository tree, with pagination support.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="expand">
        /// If true, returns returns associated commit data for each entry and security scanner metadata.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="recursive">
        /// If true, returns the tree recursively.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// 1.000 by default, 100 by default for expand=true
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTreeResponseItem>>> GetModelsByNamespaceByRepoTreeByRevByPathAsResponseAsync(
            string @namespace,
            string repo,
            string rev,
            string path,
            object? expand = default,
            object? recursive = default,
            int? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}