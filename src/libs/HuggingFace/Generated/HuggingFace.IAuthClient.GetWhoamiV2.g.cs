#nullable enable

namespace HuggingFace
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Get user info<br/>
        /// Get information about the user and auth method used
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response55> GetWhoamiV2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}