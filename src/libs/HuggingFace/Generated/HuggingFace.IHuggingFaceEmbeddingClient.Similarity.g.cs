#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceEmbeddingClient
    {
        /// <summary>
        /// Get Sentence Similarity. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<float>> SimilarityAsync(

            global::HuggingFace.SimilarityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Sentence Similarity. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="parameters">
        /// Default Value: null
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<float>> SimilarityAsync(
            global::HuggingFace.SimilarityInput inputs,
            global::HuggingFace.SimilarityParameters? parameters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}