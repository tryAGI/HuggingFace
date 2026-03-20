#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceEmbeddingClient
    {

        /// <summary>
        /// Text Embeddings Inference endpoint info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Info> GetModelInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}