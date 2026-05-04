#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update network security settings<br/>
        /// Update the network security settings for an organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponse> EditOrganizationsByNameSettingsNetworkSecurityAsync(
            string name,

            global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update network security settings<br/>
        /// Update the network security settings for an organization.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="enforceAuth"></param>
        /// <param name="enforceIpRestriction"></param>
        /// <param name="highRateLimits"></param>
        /// <param name="ipRanges"></param>
        /// <param name="blockedContents"></param>
        /// <param name="allowedContents"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponse> EditOrganizationsByNameSettingsNetworkSecurityAsync(
            string name,
            bool? enforceAuth = default,
            bool? enforceIpRestriction = default,
            bool? highRateLimits = default,
            global::System.Collections.Generic.IList<string>? ipRanges = default,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestBlockedContent>? blockedContents = default,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityRequestAllowedContent>? allowedContents = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}