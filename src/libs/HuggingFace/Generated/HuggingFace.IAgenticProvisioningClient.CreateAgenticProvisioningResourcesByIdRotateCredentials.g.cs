#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Rotate the credentials for a resource
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRotateCredentialsResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRotateCredentialsResponseVariant2>> CreateAgenticProvisioningResourcesByIdRotateCredentialsAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}