#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Rotate SSO credentials<br/>
        /// Update SSO credentials of the organization's SSO configuration. SSO stays enabled and does not need to be re-tested, so rotation causes no downtime. Requires a paid plan.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutOrganizationsByNameSettingsSsoCredentialsAsync(
            string name,

            global::HuggingFace.AnyOf<global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1, global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2> request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate SSO credentials<br/>
        /// Update SSO credentials of the organization's SSO configuration. SSO stays enabled and does not need to be re-tested, so rotation causes no downtime. Requires a paid plan.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<string>> PutOrganizationsByNameSettingsSsoCredentialsAsResponseAsync(
            string name,

            global::HuggingFace.AnyOf<global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant1, global::HuggingFace.PutOrganizationsSettingsSsoCredentialsRequestVariant2> request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate SSO credentials<br/>
        /// Update SSO credentials of the organization's SSO configuration. SSO stays enabled and does not need to be re-tested, so rotation causes no downtime. Requires a paid plan.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutOrganizationsByNameSettingsSsoCredentialsAsync(
            string name,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}