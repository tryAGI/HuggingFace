#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Create branch
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSpacesByNamespaceByRepoBranchByRevAsync(
            string @namespace,
            string repo,
            string rev,

            global::HuggingFace.Request42 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create branch
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="startingPoint">
        /// The commit to start from
        /// </param>
        /// <param name="emptyBranch">
        /// Create an empty branch<br/>
        /// Default Value: false
        /// </param>
        /// <param name="overwrite">
        /// Overwrite the branch if it already exists<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateSpacesByNamespaceByRepoBranchByRevAsync(
            string @namespace,
            string repo,
            string rev,
            string? startingPoint = default,
            bool? emptyBranch = default,
            bool? overwrite = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}