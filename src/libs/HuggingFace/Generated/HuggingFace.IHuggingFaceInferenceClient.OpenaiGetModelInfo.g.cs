#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceInferenceClient
    {

        /// <summary>
        /// Get model info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.ModelInfo> OpenaiGetModelInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}