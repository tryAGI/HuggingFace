#nullable enable

namespace HuggingFace
{
    public partial interface IPapersClient
    {
        /// <summary>
        /// Index a paper<br/>
        /// Index a paper from arXiv by its ID. If the paper is already indexed, only its authors can re-index it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePapersIndexResponse> CreatePapersIndexAsync(

            global::HuggingFace.CreatePapersIndexRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Index a paper<br/>
        /// Index a paper from arXiv by its ID. If the paper is already indexed, only its authors can re-index it.
        /// </summary>
        /// <param name="arxivId">
        /// The arXiv ID of the paper to index (e.g. 2301.00001)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreatePapersIndexResponse> CreatePapersIndexAsync(
            string arxivId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}