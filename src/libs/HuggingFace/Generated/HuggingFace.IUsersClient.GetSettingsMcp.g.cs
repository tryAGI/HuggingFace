#nullable enable

namespace HuggingFace
{
    public partial interface IUsersClient
    {

        /// <summary>
        /// Get MCP tools<br/>
        /// Get the MCP tools for the current user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response2> GetSettingsMcpAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}