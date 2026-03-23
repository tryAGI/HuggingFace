#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get avatar<br/>
        /// Retrieve organization avatar. This endpoint returns a JSON with the avatar URL for the organization.<br/>
        /// If called with the `Sec-Fetch-Dest: image` header, it instead redirects to the avatar URL
        /// </summary>
        /// <param name="name"></param>
        /// <param name="redirect">
        /// Redirect to the avatar url instead of returning it
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetOrganizationsAvatarResponse> GetOrganizationsByNameAvatarAsync(
            string name,
            object? redirect = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}