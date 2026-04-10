#nullable enable

namespace HuggingFace
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// Update watch settings<br/>
        /// Update watch settings for the user. Get notified when discussions happen on your watched items.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task EditSettingsWatchAsync(

            global::HuggingFace.PatchSettingsWatchRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update watch settings<br/>
        /// Update watch settings for the user. Get notified when discussions happen on your watched items.
        /// </summary>
        /// <param name="delete">
        /// Default Value: []
        /// </param>
        /// <param name="add">
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditSettingsWatchAsync(
            global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestDeleteItem>? delete = default,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchSettingsWatchRequestAddItem>? add = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}