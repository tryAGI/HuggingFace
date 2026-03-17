#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceInferenceClient
    {
        /// <summary>
        /// Health check method
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task HealthAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}