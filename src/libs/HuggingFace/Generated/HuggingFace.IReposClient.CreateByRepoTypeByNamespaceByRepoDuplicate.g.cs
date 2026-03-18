#nullable enable

namespace HuggingFace
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Duplicate a repository
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response98> CreateByRepoTypeByNamespaceByRepoDuplicateAsync(
            global::HuggingFace.RepoType45 repoType,
            string @namespace,
            string repo,

            global::HuggingFace.Request50 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Duplicate a repository
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="repository"></param>
        /// <param name="private"></param>
        /// <param name="visibility"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="hardware"></param>
        /// <param name="sleepTimeSeconds"></param>
        /// <param name="secrets">
        /// Default Value: []
        /// </param>
        /// <param name="variables">
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response98> CreateByRepoTypeByNamespaceByRepoDuplicateAsync(
            global::HuggingFace.RepoType45 repoType,
            string @namespace,
            string repo,
            string repository,
            bool? @private = default,
            global::HuggingFace.RequestVisibility2? visibility = default,
            string? resourceGroupId = default,
            global::HuggingFace.RequestHardware? hardware = default,
            global::HuggingFace.AnyOf<int?, string>? sleepTimeSeconds = default,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestSecret>? secrets = default,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestVariable>? variables = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}