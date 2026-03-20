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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem22>>> GetModelsTagsByTypeAsync(
            global::HuggingFace.Type3? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}