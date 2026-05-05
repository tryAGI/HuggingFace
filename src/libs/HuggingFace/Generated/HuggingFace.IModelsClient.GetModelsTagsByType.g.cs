#nullable enable

namespace HuggingFace
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get model tags<br/>
        /// Get all possible tags used for models, grouped by tag type. Optionally restrict to only one tag type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTagsByTypeResponseItem>>> GetModelsTagsByTypeAsync(
            global::HuggingFace.GetModelsTagsByTypeType? type = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get model tags<br/>
        /// Get all possible tags used for models, grouped by tag type. Optionally restrict to only one tag type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetModelsTagsByTypeResponseItem>>>> GetModelsTagsByTypeAsResponseAsync(
            global::HuggingFace.GetModelsTagsByTypeType? type = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}