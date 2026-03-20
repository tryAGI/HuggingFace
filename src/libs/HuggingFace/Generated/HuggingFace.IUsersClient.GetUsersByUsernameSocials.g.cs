#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {

        /// <summary>
        /// Get social handles<br/>
        /// Get a user's social media handles
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response60> GetUsersByUsernameSocialsAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}