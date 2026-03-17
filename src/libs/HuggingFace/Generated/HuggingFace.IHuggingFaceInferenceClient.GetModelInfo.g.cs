#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceInferenceClient
    {
        /// <summary>
        /// Text Generation Inference endpoint info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Info> GetModelInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}