#nullable enable

namespace HuggingFace
{
    public partial interface ICollectionsClient
    {
        /// <summary>
        /// Get collections
        /// </summary>
        /// <param name="item"></param>
        /// <param name="owner"></param>
        /// <param name="q"></param>
        /// <param name="sort">
        /// Default Value: trending
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="expand">
        /// Default Value: true
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1Item>, global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant2Item>>> GetCollectionsAsync(
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>? item = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? owner = default,
            string? q = default,
            global::HuggingFace.Sort3? sort = default,
            string? cursor = default,
            object? expand = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}