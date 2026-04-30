#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Provision a resource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant3>> CreateAgenticProvisioningResourcesAsync(

            global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant4> request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Provision a resource
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant3>> CreateAgenticProvisioningResourcesAsync(
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}