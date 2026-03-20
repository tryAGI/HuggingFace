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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.ResponseItem2>> GetOrganizationsByNameAuditLogExportAsync(
            string name,
            string? q = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}