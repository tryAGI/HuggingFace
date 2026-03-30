#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Remove / de-provision a resource
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRemoveResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRemoveResponseVariant2>> CreateAgenticProvisioningResourcesByIdRemoveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}