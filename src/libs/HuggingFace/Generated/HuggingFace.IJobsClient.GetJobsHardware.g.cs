#nullable enable

namespace HuggingFace
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Get job hardware<br/>
        /// Get available job hardware
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetJobsHardwareResponseItem>> GetJobsHardwareAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}