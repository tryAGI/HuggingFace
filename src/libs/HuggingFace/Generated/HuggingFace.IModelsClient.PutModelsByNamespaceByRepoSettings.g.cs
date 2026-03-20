#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Update repo settings<br/>
        /// Update the settings of a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response95> PutModelsByNamespaceByRepoSettingsAsync(
            string @namespace,
            string repo,

            global::HuggingFace.Request48 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update repo settings<br/>
        /// Update the settings of a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="private"></param>
        /// <param name="visibility">
        /// Repository visibility. `protected` is only supported for Spaces.
        /// </param>
        /// <param name="discussionsDisabled"></param>
        /// <param name="discussionsSorting"></param>
        /// <param name="gated"></param>
        /// <param name="gatedNotificationsEmail"></param>
        /// <param name="gatedNotificationsMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response95> PutModelsByNamespaceByRepoSettingsAsync(
            string @namespace,
            string repo,
            bool? @private = default,
            global::HuggingFace.RequestVisibility? visibility = default,
            bool? discussionsDisabled = default,
            global::HuggingFace.RequestDiscussionsSorting? discussionsSorting = default,
            global::HuggingFace.AnyOf<string, global::HuggingFace.RequestGatedEnum2?>? gated = default,
            string? gatedNotificationsEmail = default,
            global::HuggingFace.RequestGatedNotificationsMode? gatedNotificationsMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}