#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// Update repo settings<br/>
        /// Update the settings of a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutSpacesSettingsResponse> PutSpacesByNamespaceByRepoSettingsAsync(
            string @namespace,
            string repo,

            global::HuggingFace.PutSpacesSettingsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PutSpacesSettingsResponse> PutSpacesByNamespaceByRepoSettingsAsync(
            string @namespace,
            string repo,
            bool? @private = default,
            global::HuggingFace.PutSpacesSettingsRequestVisibility? visibility = default,
            bool? discussionsDisabled = default,
            global::HuggingFace.PutSpacesSettingsRequestDiscussionsSorting? discussionsSorting = default,
            global::HuggingFace.AnyOf<string, global::HuggingFace.PutSpacesSettingsRequestGatedEnum2?>? gated = default,
            string? gatedNotificationsEmail = default,
            global::HuggingFace.PutSpacesSettingsRequestGatedNotificationsMode? gatedNotificationsMode = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}