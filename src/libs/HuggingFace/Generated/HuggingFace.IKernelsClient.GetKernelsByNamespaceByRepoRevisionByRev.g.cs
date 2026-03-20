#nullable enable

namespace HuggingFace
{
    public partial interface IKernelsClient
    {

        /// <summary>
        /// Get kernel
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response113> GetKernelsByNamespaceByRepoRevisionByRevAsync(
            string @namespace,
            string repo,
            string rev,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}