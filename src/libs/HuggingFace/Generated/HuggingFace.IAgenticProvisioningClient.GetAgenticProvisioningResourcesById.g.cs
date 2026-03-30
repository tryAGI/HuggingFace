#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Get a resource by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.GetAgenticProvisioningResourcesResponseVariant1, global::HuggingFace.GetAgenticProvisioningResourcesResponseVariant2, global::HuggingFace.GetAgenticProvisioningResourcesResponseVariant3, global::HuggingFace.GetAgenticProvisioningResourcesResponseVariant4>> GetAgenticProvisioningResourcesByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}