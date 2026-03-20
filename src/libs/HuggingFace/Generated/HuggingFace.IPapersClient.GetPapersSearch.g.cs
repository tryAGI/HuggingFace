#nullable enable

namespace HuggingFace
{
    public partial interface IPapersClient
    {

        /// <summary>
        /// Search papers<br/>
        /// Perform a hybrid semantic / full-text-search on papers
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetPapersSearchAsync(
            string? q = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}