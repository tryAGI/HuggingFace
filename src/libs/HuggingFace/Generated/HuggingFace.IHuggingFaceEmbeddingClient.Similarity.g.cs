#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceEmbeddingClient
    {
        /// <summary>
        /// Get Sentence Similarity. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<float>> SimilarityAsync(

            global::HuggingFace.SimilarityRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Sentence Similarity. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<float>>> SimilarityAsResponseAsync(

            global::HuggingFace.SimilarityRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Sentence Similarity. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="parameters">
        /// Default Value: null
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<float>> SimilarityAsync(
            global::HuggingFace.SimilarityInput inputs,
            global::HuggingFace.SimilarityParameters? parameters = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}