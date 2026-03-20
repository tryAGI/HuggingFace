#nullable enable

namespace HuggingFace
{
    public partial interface INotificationsClient
    {

        /// <summary>
        /// List notifications<br/>
        /// List notifications for the user
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response> GetNotificationsAsync(
            int? p = default,
            global::HuggingFace.ReadStatus? readStatus = default,
            global::HuggingFace.RepoType2? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.Mention? mention = default,
            global::System.DateTime? lastUpdate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}