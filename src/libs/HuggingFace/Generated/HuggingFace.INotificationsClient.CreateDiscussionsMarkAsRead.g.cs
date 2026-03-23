#nullable enable

namespace HuggingFace
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// Change read status<br/>
        /// Mark discussions as read or unread. If `applyToAll` is true, all notifications for the user matching the search parameters will be marked as read or unread.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDiscussionsMarkAsReadAsync(

            global::HuggingFace.CreateDiscussionsMarkAsReadRequest request,
            int? p = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadReadStatus? readStatus = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadRepoType? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadMention? mention = default,
            global::System.DateTime? lastUpdate = default,
            object? applyToAll = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change read status<br/>
        /// Mark discussions as read or unread. If `applyToAll` is true, all notifications for the user matching the search parameters will be marked as read or unread.
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
        /// <param name="discussionIds">
        /// Default Value: []
        /// </param>
        /// <param name="read">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDiscussionsMarkAsReadAsync(
            int? p = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadReadStatus? readStatus = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadRepoType? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadMention? mention = default,
            global::System.DateTime? lastUpdate = default,
            object? applyToAll = default,
            global::System.Collections.Generic.IList<string>? discussionIds = default,
            bool? read = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}