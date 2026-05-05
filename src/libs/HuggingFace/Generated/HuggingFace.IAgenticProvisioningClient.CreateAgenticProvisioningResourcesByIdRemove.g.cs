#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Remove / de-provision a resource
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRemoveResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRemoveResponseVariant2>> CreateAgenticProvisioningResourcesByIdRemoveAsync(
            string id,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove / de-provision a resource
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRemoveResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRemoveResponseVariant2>>> CreateAgenticProvisioningResourcesByIdRemoveAsResponseAsync(
            string id,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}