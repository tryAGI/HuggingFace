#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceEmbeddingClient
    {
        /// <summary>
        /// Get Ranks. Returns a 424 status code if the model is not a Sequence Classification model with<br/>
        /// a single class.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.Rank>> RerankAsync(

            global::HuggingFace.RerankRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Ranks. Returns a 424 status code if the model is not a Sequence Classification model with<br/>
        /// a single class.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.Rank>>> RerankAsResponseAsync(

            global::HuggingFace.RerankRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Ranks. Returns a 424 status code if the model is not a Sequence Classification model with<br/>
        /// a single class.
        /// </summary>
        /// <param name="query">
        /// Example: What is Deep Learning?
        /// </param>
        /// <param name="rawScores">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="returnText">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="texts">
        /// Example: [Deep Learning is ...]
        /// </param>
        /// <param name="truncate">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="truncationDirection">
        /// Default Value: right
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.Rank>> RerankAsync(
            string query,
            global::System.Collections.Generic.IList<string> texts,
            bool? rawScores = default,
            bool? returnText = default,
            bool? truncate = default,
            global::HuggingFace.TruncationDirection? truncationDirection = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}