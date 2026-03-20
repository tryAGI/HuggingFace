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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task PutOrganizationsByNameMembersByUsernameRoleAsync(
            string name,
            string username,

            global::HuggingFace.Request9 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change member role<br/>
        /// Change the role of a member in the organization. Need a paid plan.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="role"></param>
        /// <param name="resourceGroups"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutOrganizationsByNameMembersByUsernameRoleAsync(
            string name,
            string username,
            global::HuggingFace.RequestRole role,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestResourceGroup>? resourceGroups = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}