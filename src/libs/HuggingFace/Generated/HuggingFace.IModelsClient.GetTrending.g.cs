#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get trending<br/>
        /// Get the trending repositories
        /// </summary>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response95> GetTrendingAsync(
            global::HuggingFace.Type5? type = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}