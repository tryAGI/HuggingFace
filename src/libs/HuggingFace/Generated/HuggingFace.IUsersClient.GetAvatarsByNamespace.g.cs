#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {

        /// <summary>
        /// Get avatar<br/>
        /// Display the avatar for any user or organization. This endpoint redirects to the avatar URL for either a user or an organization
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAvatarsByNamespaceAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}