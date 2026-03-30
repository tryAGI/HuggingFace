#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Provision a resource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant3>> CreateAgenticProvisioningResourcesAsync(

            global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Provision a resource
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant3>> CreateAgenticProvisioningResourcesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}