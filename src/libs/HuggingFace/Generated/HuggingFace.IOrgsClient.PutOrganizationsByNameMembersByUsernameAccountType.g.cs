#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Change account type<br/>
        /// Convert a member into an external collaborator, who isn't required to sign in with SSO, or back into a member. Need a paid plan. Doesn't affect the role, which must be changed separately.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task PutOrganizationsByNameMembersByUsernameAccountTypeAsync(
            string name,
            string username,

            global::HuggingFace.PutOrganizationsMembersAccountTypeRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change account type<br/>
        /// Convert a member into an external collaborator, who isn't required to sign in with SSO, or back into a member. Need a paid plan. Doesn't affect the role, which must be changed separately.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> PutOrganizationsByNameMembersByUsernameAccountTypeAsResponseAsync(
            string name,
            string username,

            global::HuggingFace.PutOrganizationsMembersAccountTypeRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change account type<br/>
        /// Convert a member into an external collaborator, who isn't required to sign in with SSO, or back into a member. Need a paid plan. Doesn't affect the role, which must be changed separately.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="accountType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutOrganizationsByNameMembersByUsernameAccountTypeAsync(
            string name,
            string username,
            global::HuggingFace.PutOrganizationsMembersAccountTypeRequestAccountType accountType,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}