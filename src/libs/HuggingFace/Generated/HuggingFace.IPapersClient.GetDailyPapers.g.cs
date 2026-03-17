#nullable enable

namespace HuggingFace
{
    public partial interface IPapersClient
    {
        /// <summary>
        /// Get Daily Papers
        /// </summary>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="date"></param>
        /// <param name="week"></param>
        /// <param name="month"></param>
        /// <param name="submitter"></param>
        /// <param name="sort">
        /// Default Value: publishedAt
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem20>> GetDailyPapersAsync(
            int? p = default,
            int? limit = default,
            global::System.DateTime? date = default,
            string? week = default,
            string? month = default,
            string? submitter = default,
            global::HuggingFace.Sort2? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}