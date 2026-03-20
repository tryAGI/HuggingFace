#nullable enable

namespace HuggingFace
{
    public partial interface IDocsClient
    {
        /// <summary>
        /// List docs<br/>
        /// Get list of available documentation
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem7>> GetDocsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}