#nullable enable

namespace HuggingFace
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Create a SCIM provisioning user invitation<br/>
        /// Creates an invitation for a user to join the organization. The user must have an existing Hugging Face account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponse> CreateOrganizationsByNameScimProvisioningV2UsersAsync(
            string name,

            global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a SCIM provisioning user invitation<br/>
        /// Creates an invitation for a user to join the organization. The user must have an existing Hugging Face account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponse>> CreateOrganizationsByNameScimProvisioningV2UsersAsResponseAsync(
            string name,

            global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a SCIM provisioning user invitation<br/>
        /// Creates an invitation for a user to join the organization. The user must have an existing Hugging Face account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="schemas"></param>
        /// <param name="userName">
        /// Username of the existing Hugging Face user
        /// </param>
        /// <param name="emails"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="externalId">
        /// SSO unique identifier (SAML nameid or OIDC sub claim) - required for SSO login
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersResponse> CreateOrganizationsByNameScimProvisioningV2UsersAsync(
            string name,
            global::System.Collections.Generic.IList<string> schemas,
            string userName,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsScimProvisioningV2UsersRequestEmail> emails,
            string externalId,
            bool? active = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}