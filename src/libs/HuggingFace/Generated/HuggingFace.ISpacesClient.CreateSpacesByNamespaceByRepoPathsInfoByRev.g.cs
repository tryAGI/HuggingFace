#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// List paths info
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItem>> CreateSpacesByNamespaceByRepoPathsInfoByRevAsync(
            string @namespace,
            string repo,
            string rev,

            global::HuggingFace.CreateSpacesPathsInfoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List paths info
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="paths"></param>
        /// <param name="expand">
        /// Expand the response with the last commit and security file status
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.CreateSpacesPathsInfoResponseItem>> CreateSpacesByNamespaceByRepoPathsInfoByRevAsync(
            string @namespace,
            string repo,
            string rev,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string> paths,
            global::HuggingFace.AnyOf<object, bool?> expand,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}