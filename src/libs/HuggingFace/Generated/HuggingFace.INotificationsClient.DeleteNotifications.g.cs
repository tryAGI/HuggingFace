#nullable enable

namespace HuggingFace
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// Delete notifications<br/>
        /// Delete notifications, either by specifying discussionIds or by applying to all notifications with search parameters
        /// </summary>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="readStatus">
        /// Default Value: all
        /// </param>
        /// <param name="repoType"></param>
        /// <param name="repoName"></param>
        /// <param name="postAuthor"></param>
        /// <param name="paperId"></param>
        /// <param name="articleId"></param>
        /// <param name="mention">
        /// Default Value: all
        /// </param>
        /// <param name="lastUpdate"></param>
        /// <param name="applyToAll">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteNotificationsAsync(

            global::HuggingFace.DeleteNotificationsRequest request,
            int? p = default,
            global::HuggingFace.DeleteNotificationsReadStatus? readStatus = default,
            global::HuggingFace.DeleteNotificationsRepoType? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.DeleteNotificationsMention? mention = default,
            global::System.DateTime? lastUpdate = default,
            object? applyToAll = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete notifications<br/>
        /// Delete notifications, either by specifying discussionIds or by applying to all notifications with search parameters
        /// </summary>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="readStatus">
        /// Default Value: all
        /// </param>
        /// <param name="repoType"></param>
        /// <param name="repoName"></param>
        /// <param name="postAuthor"></param>
        /// <param name="paperId"></param>
        /// <param name="articleId"></param>
        /// <param name="mention">
        /// Default Value: all
        /// </param>
        /// <param name="lastUpdate"></param>
        /// <param name="applyToAll">
        /// Default Value: false
        /// </param>
        /// <param name="discussionIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteNotificationsAsync(
            int? p = default,
            global::HuggingFace.DeleteNotificationsReadStatus? readStatus = default,
            global::HuggingFace.DeleteNotificationsRepoType? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.DeleteNotificationsMention? mention = default,
            global::System.DateTime? lastUpdate = default,
            object? applyToAll = default,
            global::System.Collections.Generic.IList<string>? discussionIds = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}