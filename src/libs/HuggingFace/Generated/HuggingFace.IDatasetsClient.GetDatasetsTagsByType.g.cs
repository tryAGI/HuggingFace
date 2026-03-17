#nullable enable

namespace HuggingFace
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset tags<br/>
        /// Get all possible tags used for datasets, grouped by tag type. Optionally restrict to only one tag type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem17>>> GetDatasetsTagsByTypeAsync(
            global::HuggingFace.Type4? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}