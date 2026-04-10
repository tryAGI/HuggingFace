#nullable enable

namespace HuggingFace
{
    public partial interface IDocsClient
    {
        /// <summary>
        /// Search docs<br/>
        /// Search any Hugging Face documentation
        /// </summary>
        /// <param name="q"></param>
        /// <param name="product"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetDocsSearchResponseItem>> GetDocsSearchAsync(
            string q,
            global::HuggingFace.GetDocsSearchProduct? product = default,
            int? limit = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}