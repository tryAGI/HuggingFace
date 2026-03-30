#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Get Agentic Provisioning services
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetAgenticProvisioningServicesResponse> GetAgenticProvisioningServicesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}