#nullable enable

namespace HuggingFace
{
    public partial interface IDiscussionsClient
    {

        /// <summary>
        /// Delete a discussion
        /// </summary>
        /// <param name="username"></param>
        /// <param name="postSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePostsByUsernameByPostSlugAsync(
            string username,
            string postSlug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}