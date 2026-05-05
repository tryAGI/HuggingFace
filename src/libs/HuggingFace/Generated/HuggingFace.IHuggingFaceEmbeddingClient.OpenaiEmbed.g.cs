#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceEmbeddingClient
    {
        /// <summary>
        /// OpenAI compatible route. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.OpenAICompatResponse> OpenaiEmbedAsync(

            global::HuggingFace.OpenAICompatRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OpenAI compatible route. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.OpenAICompatResponse>> OpenaiEmbedAsResponseAsync(

            global::HuggingFace.OpenAICompatRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OpenAI compatible route. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="dimensions">
        /// Default Value: null<br/>
        /// Example: null
        /// </param>
        /// <param name="encodingFormat">
        /// Default Value: float
        /// </param>
        /// <param name="input"></param>
        /// <param name="model">
        /// Example: null
        /// </param>
        /// <param name="user">
        /// Example: null
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.OpenAICompatResponse> OpenaiEmbedAsync(
            global::HuggingFace.Input input,
            int? dimensions = default,
            global::HuggingFace.EncodingFormat? encodingFormat = default,
            string? model = default,
            string? user = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}