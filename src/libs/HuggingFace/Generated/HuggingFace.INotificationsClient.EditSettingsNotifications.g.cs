#nullable enable

namespace HuggingFace
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// Update notification settings<br/>
        /// Update notification settings for the user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task EditSettingsNotificationsAsync(

            global::HuggingFace.PatchSettingsNotificationsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update notification settings<br/>
        /// Update notification settings for the user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> EditSettingsNotificationsAsResponseAsync(

            global::HuggingFace.PatchSettingsNotificationsRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update notification settings<br/>
        /// Update notification settings for the user
        /// </summary>
        /// <param name="notifications"></param>
        /// <param name="prepaidAmount">
        /// To be provided when enabling launch_prepaid_credits
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditSettingsNotificationsAsync(
            global::HuggingFace.PatchSettingsNotificationsRequestNotifications notifications,
            string? prepaidAmount = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}