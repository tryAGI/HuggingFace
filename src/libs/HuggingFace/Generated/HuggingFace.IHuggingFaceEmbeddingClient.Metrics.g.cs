#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceEmbeddingClient
    {

        /// <summary>
        /// Prometheus metrics scrape endpoint
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MetricsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}