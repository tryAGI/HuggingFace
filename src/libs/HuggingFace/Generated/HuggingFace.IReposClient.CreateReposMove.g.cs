#nullable enable

namespace HuggingFace
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Move repo<br/>
        /// Move or rename a repo
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateReposMoveAsync(

            global::HuggingFace.Request53 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Move repo<br/>
        /// Move or rename a repo
        /// </summary>
        /// <param name="fromRepo"></param>
        /// <param name="toRepo"></param>
        /// <param name="type">
        /// Default Value: model
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateReposMoveAsync(
            string fromRepo,
            string toRepo,
            global::HuggingFace.RequestType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}