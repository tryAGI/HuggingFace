#nullable enable

namespace HuggingFace
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Initiate device authorization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response46> CreateOauthDeviceAsync(

            global::HuggingFace.Request23 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiate device authorization
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="scope"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response46> CreateOauthDeviceAsync(
            string clientId,
            string? scope = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}