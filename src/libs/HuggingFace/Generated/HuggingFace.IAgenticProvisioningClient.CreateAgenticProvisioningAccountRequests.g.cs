#nullable enable

namespace HuggingFace
{
    public partial interface IAgenticProvisioningClient
    {
        /// <summary>
        /// Create an Agentic Provisioning account request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant1, global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant2>> CreateAgenticProvisioningAccountRequestsAsync(

            global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Agentic Provisioning account request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant1, global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant2>>> CreateAgenticProvisioningAccountRequestsAsResponseAsync(

            global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Agentic Provisioning account request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="scopes"></param>
        /// <param name="phone"></param>
        /// <param name="country"></param>
        /// <param name="kyc"></param>
        /// <param name="clientCapabilities"></param>
        /// <param name="configuration"></param>
        /// <param name="confirmationSecret"></param>
        /// <param name="expiresAt"></param>
        /// <param name="orchestrator"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant1, global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant2>> CreateAgenticProvisioningAccountRequestsAsync(
            string id,
            string email,
            global::System.Collections.Generic.IList<string> scopes,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestClientCapabilitie> clientCapabilities,
            string confirmationSecret,
            global::System.DateTime expiresAt,
            global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestOrchestrator orchestrator,
            string @object = "account_request",
            string? name = default,
            string? phone = default,
            string? country = default,
            global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestKyc? kyc = default,
            object? configuration = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}