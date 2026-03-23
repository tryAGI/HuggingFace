#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Squash ref<br/>
        /// Squash all commits in the current ref into a single commit with the given message. Action is irreversible.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSpacesSuperSquashResponse> CreateSpacesByNamespaceByRepoSuperSquashByRevAsync(
            string @namespace,
            string repo,
            string rev,

            global::HuggingFace.CreateSpacesSuperSquashRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Squash ref<br/>
        /// Squash all commits in the current ref into a single commit with the given message. Action is irreversible.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="message"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateSpacesSuperSquashResponse> CreateSpacesByNamespaceByRepoSuperSquashByRevAsync(
            string @namespace,
            string repo,
            string rev,
            string? message = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}