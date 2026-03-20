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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response112> GetKernelsByNamespaceByRepoAsync(
            string @namespace,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}