#nullable enable

namespace HuggingFace
{
    public partial interface IDocsClient
    {

        /// <summary>
        /// Full-text search docs<br/>
        /// Full-text search across Hugging Face documentation
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit">
        /// Default Value: 9
        /// </param>
        /// <param name="domain"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response53> GetDocsSearchFullTextAsync(
            string q,
            int? limit = default,
            string? domain = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}