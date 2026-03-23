
#nullable enable

namespace HuggingFace
{
    public partial class NotificationsClient
    {
        partial void PrepareCreateDiscussionsMarkAsReadArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? p,
            ref global::HuggingFace.CreateDiscussionsMarkAsReadReadStatus? readStatus,
            ref global::HuggingFace.CreateDiscussionsMarkAsReadRepoType? repoType,
            ref string? repoName,
            ref string? postAuthor,
            ref string? paperId,
            ref string? articleId,
            ref global::HuggingFace.CreateDiscussionsMarkAsReadMention? mention,
            ref global::System.DateTime? lastUpdate,
            object? applyToAll,
            global::HuggingFace.CreateDiscussionsMarkAsReadRequest request);
        partial void PrepareCreateDiscussionsMarkAsReadRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? p,
            global::HuggingFace.CreateDiscussionsMarkAsReadReadStatus? readStatus,
            global::HuggingFace.CreateDiscussionsMarkAsReadRepoType? repoType,
            string? repoName,
            string? postAuthor,
            string? paperId,
            string? articleId,
            global::HuggingFace.CreateDiscussionsMarkAsReadMention? mention,
            global::System.DateTime? lastUpdate,
            object? applyToAll,
            global::HuggingFace.CreateDiscussionsMarkAsReadRequest request);
        partial void ProcessCreateDiscussionsMarkAsReadResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Change read status<br/>
        /// Mark discussions as read or unread. If `applyToAll` is true, all notifications for the user matching the search parameters will be marked as read or unread.
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
        public async global::System.Threading.Tasks.Task CreateDiscussionsMarkAsReadAsync(

            global::HuggingFace.CreateDiscussionsMarkAsReadRequest request,
            int? p = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadReadStatus? readStatus = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadRepoType? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadMention? mention = default,
            global::System.DateTime? lastUpdate = default,
            object? applyToAll = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateDiscussionsMarkAsReadArguments(
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
                path: "/api/discussions/mark-as-read",
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
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCreateDiscussionsMarkAsReadRequest(
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
            ProcessCreateDiscussionsMarkAsReadResponse(
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

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

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
        /// Change read status<br/>
        /// Mark discussions as read or unread. If `applyToAll` is true, all notifications for the user matching the search parameters will be marked as read or unread.
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
        /// <param name="discussionIds">
        /// Default Value: []
        /// </param>
        /// <param name="read">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateDiscussionsMarkAsReadAsync(
            int? p = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadReadStatus? readStatus = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadRepoType? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.CreateDiscussionsMarkAsReadMention? mention = default,
            global::System.DateTime? lastUpdate = default,
            object? applyToAll = default,
            global::System.Collections.Generic.IList<string>? discussionIds = default,
            bool? read = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.CreateDiscussionsMarkAsReadRequest
            {
                DiscussionIds = discussionIds,
                Read = read,
            };

            await CreateDiscussionsMarkAsReadAsync(
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