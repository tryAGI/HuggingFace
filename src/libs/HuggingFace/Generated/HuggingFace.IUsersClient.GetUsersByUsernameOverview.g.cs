#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// User overview
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetUsersOverviewResponse> GetUsersByUsernameOverviewAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}