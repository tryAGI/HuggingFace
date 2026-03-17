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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task EditSettingsWatchAsync(

            global::HuggingFace.Request3 request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditSettingsWatchAsync(
            global::System.Collections.Generic.IList<global::HuggingFace.RequestDeleteItem>? delete = default,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestAddItem>? add = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}