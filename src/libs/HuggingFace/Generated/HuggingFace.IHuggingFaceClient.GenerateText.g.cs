#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceClient
    {
        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GenerateTextResponseValue>> GenerateTextAsync(
            string modelId,
            global::HuggingFace.GenerateTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="inputs">
        /// The prompt that you want to complete.<br/>
        /// Example: This is a test.
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GenerateTextResponseValue>> GenerateTextAsync(
            string modelId,
            string? inputs,
            global::HuggingFace.GenerateTextRequestParameters? parameters = default,
            global::HuggingFace.GenerateTextRequestOptions? options = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}