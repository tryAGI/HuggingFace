
#nullable enable

namespace HuggingFace
{
    public partial class NotificationsClient
    {
        partial void PrepareDeleteNotificationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? p,
            ref global::HuggingFace.DeleteNotificationsReadStatus? readStatus,
            ref global::HuggingFace.DeleteNotificationsRepoType? repoType,
            ref string? repoName,
            ref string? postAuthor,
            ref string? paperId,
            ref string? articleId,
            ref global::HuggingFace.DeleteNotificationsMention? mention,
            ref global::System.DateTime? lastUpdate,
            object? applyToAll,
            global::HuggingFace.DeleteNotificationsRequest request);
        partial void PrepareDeleteNotificationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? p,
            global::HuggingFace.DeleteNotificationsReadStatus? readStatus,
            global::HuggingFace.DeleteNotificationsRepoType? repoType,
            string? repoName,
            string? postAuthor,
            string? paperId,
            string? articleId,
            global::HuggingFace.DeleteNotificationsMention? mention,
            global::System.DateTime? lastUpdate,
            object? applyToAll,
            global::HuggingFace.DeleteNotificationsRequest request);
        partial void ProcessDeleteNotificationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete notifications<br/>
        /// Delete notifications, either by specifying discussionIds or by applying to all notifications with search parameters
        /// </summary>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="readStatus">
        /// Default Value: all
        /// </param>
        /// <param name="repoType"></param>
        /// <param name="repoName"></param>
        /// <param name="postAuthor"></param>
        /// <param name="paperId"></param>
        /// <param name="articleId"></param>
        /// <param name="mention">
        /// Default Value: all
        /// </param>
        /// <param name="lastUpdate"></param>
        /// <param name="applyToAll">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task DeleteNotificationsAsync(

            global::HuggingFace.DeleteNotificationsRequest request,
            int? p = default,
            global::HuggingFace.DeleteNotificationsReadStatus? readStatus = default,
            global::HuggingFace.DeleteNotificationsRepoType? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.DeleteNotificationsMention? mention = default,
            global::System.DateTime? lastUpdate = default,
            object? applyToAll = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDeleteNotificationsArguments(
                httpClient: HttpClient,
                p: ref p,
                readStatus: ref readStatus,
                repoType: ref repoType,
                repoName: ref repoName,
                postAuthor: ref postAuthor,
                paperId: ref paperId,
                articleId: ref articleId,
                mention: ref mention,
                lastUpdate: ref lastUpdate,
                applyToAll: applyToAll,
                request: request);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/api/notifications",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("p", p?.ToString())
                .AddOptionalParameter("readStatus", readStatus?.ToValueString())
                .AddOptionalParameter("repoType", repoType?.ToValueString())
                .AddOptionalParameter("repoName", repoName)
                .AddOptionalParameter("postAuthor", postAuthor)
                .AddOptionalParameter("paperId", paperId)
                .AddOptionalParameter("articleId", articleId)
                .AddOptionalParameter("mention", mention?.ToValueString())
                .AddOptionalParameter("lastUpdate", lastUpdate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("applyToAll", applyToAll?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDeleteNotificationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                p: p,
                readStatus: readStatus,
                repoType: repoType,
                repoName: repoName,
                postAuthor: postAuthor,
                paperId: paperId,
                articleId: articleId,
                mention: mention,
                lastUpdate: lastUpdate,
                applyToAll: applyToAll,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDeleteNotificationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                }
                catch (global::System.Exception __ex)
                {
                    throw new global::HuggingFace.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::HuggingFace.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Delete notifications<br/>
        /// Delete notifications, either by specifying discussionIds or by applying to all notifications with search parameters
        /// </summary>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="readStatus">
        /// Default Value: all
        /// </param>
        /// <param name="repoType"></param>
        /// <param name="repoName"></param>
        /// <param name="postAuthor"></param>
        /// <param name="paperId"></param>
        /// <param name="articleId"></param>
        /// <param name="mention">
        /// Default Value: all
        /// </param>
        /// <param name="lastUpdate"></param>
        /// <param name="applyToAll">
        /// Default Value: false
        /// </param>
        /// <param name="discussionIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DeleteNotificationsAsync(
            int? p = default,
            global::HuggingFace.DeleteNotificationsReadStatus? readStatus = default,
            global::HuggingFace.DeleteNotificationsRepoType? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.DeleteNotificationsMention? mention = default,
            global::System.DateTime? lastUpdate = default,
            object? applyToAll = default,
            global::System.Collections.Generic.IList<string>? discussionIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.DeleteNotificationsRequest
            {
                DiscussionIds = discussionIds,
            };

            await DeleteNotificationsAsync(
                p: p,
                readStatus: readStatus,
                repoType: repoType,
                repoName: repoName,
                postAuthor: postAuthor,
                paperId: paperId,
                articleId: articleId,
                mention: mention,
                lastUpdate: lastUpdate,
                applyToAll: applyToAll,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}