#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get the leaderboard for a dataset<br/>
        /// Returns the evaluation results ranked by score for a dataset/task
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem21>> GetDatasetsByNamespaceByRepoLeaderboardAsync(
            string @namespace,
            string repo,
            string? taskId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}