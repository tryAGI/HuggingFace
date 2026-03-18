
#nullable enable

namespace HuggingFace
{
    public partial class NotificationsClient
    {
        partial void PrepareGetNotificationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? p,
            ref global::HuggingFace.ReadStatus? readStatus,
            ref global::HuggingFace.RepoType2? repoType,
            ref string? repoName,
            ref string? postAuthor,
            ref string? paperId,
            ref string? articleId,
            ref global::HuggingFace.Mention? mention,
            ref global::System.DateTime? lastUpdate);
        partial void PrepareGetNotificationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? p,
            global::HuggingFace.ReadStatus? readStatus,
            global::HuggingFace.RepoType2? repoType,
            string? repoName,
            string? postAuthor,
            string? paperId,
            string? articleId,
            global::HuggingFace.Mention? mention,
            global::System.DateTime? lastUpdate);
        partial void ProcessGetNotificationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetNotificationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List notifications<br/>
        /// List notifications for the user
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.Response> GetNotificationsAsync(
            int? p = default,
            global::HuggingFace.ReadStatus? readStatus = default,
            global::HuggingFace.RepoType2? repoType = default,
            string? repoName = default,
            string? postAuthor = default,
            string? paperId = default,
            string? articleId = default,
            global::HuggingFace.Mention? mention = default,
            global::System.DateTime? lastUpdate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetNotificationsArguments(
                httpClient: HttpClient,
                p: ref p,
                readStatus: ref readStatus,
                repoType: ref repoType,
                repoName: ref repoName,
                postAuthor: ref postAuthor,
                paperId: ref paperId,
                articleId: ref articleId,
                mention: ref mention,
                lastUpdate: ref lastUpdate);

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
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetNotificationsRequest(
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
                lastUpdate: lastUpdate);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetNotificationsResponse(
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
                ProcessGetNotificationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.Response.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    return
                        await global::HuggingFace.Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
    }
}