#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Export the audit log<br/>
        /// Export the audit log events in JSON format for a Team or Enterprise organization. The export is limited to the last 100,000 events.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="q"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsAuditLogExportResponseItem>> GetOrganizationsByNameAuditLogExportAsync(
            string name,
            string? q = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export the audit log<br/>
        /// Export the audit log events in JSON format for a Team or Enterprise organization. The export is limited to the last 100,000 events.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="q"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetOrganizationsAuditLogExportResponseItem>>> GetOrganizationsByNameAuditLogExportAsResponseAsync(
            string name,
            string? q = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}