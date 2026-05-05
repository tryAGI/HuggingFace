#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Update a resource's service (e.g. plan upgrade)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3>> CreateAgenticProvisioningResourcesByIdUpdateServiceAsync(
            string id,

            global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a resource's service (e.g. plan upgrade)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3>>> CreateAgenticProvisioningResourcesByIdUpdateServiceAsResponseAsync(
            string id,

            global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a resource's service (e.g. plan upgrade)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="serviceId"></param>
        /// <param name="configuration"></param>
        /// <param name="paymentCredentials"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3>> CreateAgenticProvisioningResourcesByIdUpdateServiceAsync(
            string id,
            string? serviceId = default,
            global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceRequestConfiguration? configuration = default,
            global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceRequestPaymentCredentials? paymentCredentials = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}