#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Create a deep link to the user's Hub page
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateAgenticProvisioningDeepLinksResponse> CreateAgenticProvisioningDeepLinksAsync(

            global::HuggingFace.CreateAgenticProvisioningDeepLinksRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a deep link to the user's Hub page
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateAgenticProvisioningDeepLinksResponse> CreateAgenticProvisioningDeepLinksAsync(
            string purpose,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}