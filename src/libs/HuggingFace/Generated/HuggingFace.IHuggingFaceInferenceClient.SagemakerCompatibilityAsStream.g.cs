#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceInferenceClient
    {

        /// <summary>
        /// Generate tokens from Sagemaker request
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::HuggingFace.SagemakerStreamResponse> SagemakerCompatibilityAsStreamAsync(

            global::HuggingFace.SagemakerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate tokens from Sagemaker request
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::HuggingFace.SagemakerStreamResponse> SagemakerCompatibilityAsStreamAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}