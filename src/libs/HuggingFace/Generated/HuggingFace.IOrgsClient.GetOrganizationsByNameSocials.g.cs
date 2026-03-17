#nullable enable

namespace HuggingFace
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get social handles<br/>
        /// Get an organization's social media handles
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response62> GetOrganizationsByNameSocialsAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}