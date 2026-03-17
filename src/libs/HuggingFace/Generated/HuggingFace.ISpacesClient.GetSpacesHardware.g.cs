#nullable enable

namespace HuggingFace
{
    public partial interface ISpacesClient
    {
        /// <summary>
        /// List space hardware<br/>
        /// Get available space hardware
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem18>> GetSpacesHardwareAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}