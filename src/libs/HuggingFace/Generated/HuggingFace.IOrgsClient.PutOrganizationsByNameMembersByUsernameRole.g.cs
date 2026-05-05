#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Change member role<br/>
        /// Change the role of a member in the organization. Need a paid plan.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task PutOrganizationsByNameMembersByUsernameRoleAsync(
            string name,
            string username,

            global::HuggingFace.PutOrganizationsMembersRoleRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change member role<br/>
        /// Change the role of a member in the organization. Need a paid plan.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> PutOrganizationsByNameMembersByUsernameRoleAsResponseAsync(
            string name,
            string username,

            global::HuggingFace.PutOrganizationsMembersRoleRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change member role<br/>
        /// Change the role of a member in the organization. Need a paid plan.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="role"></param>
        /// <param name="resourceGroups"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutOrganizationsByNameMembersByUsernameRoleAsync(
            string name,
            string username,
            global::HuggingFace.AnyOf<global::HuggingFace.PutOrganizationsMembersRoleRequestRole?, string> role,
            global::System.Collections.Generic.IList<global::HuggingFace.PutOrganizationsMembersRoleRequestResourceGroup>? resourceGroups = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}