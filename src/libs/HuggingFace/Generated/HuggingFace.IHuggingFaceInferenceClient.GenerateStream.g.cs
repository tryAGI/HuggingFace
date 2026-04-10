#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceInferenceClient
    {
        /// <summary>
        /// Generate a stream of token using Server-Sent Events
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::HuggingFace.StreamResponse> GenerateStreamAsync(

            global::HuggingFace.GenerateRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a stream of token using Server-Sent Events
        /// </summary>
        /// <param name="inputs">
        /// Example: My name is Olivier and I
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::HuggingFace.StreamResponse> GenerateStreamAsync(
            string inputs,
            global::HuggingFace.GenerateParameters? parameters = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}