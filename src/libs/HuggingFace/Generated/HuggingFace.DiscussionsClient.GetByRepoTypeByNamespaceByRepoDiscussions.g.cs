
#nullable enable

namespace HuggingFace
{
    public partial class DiscussionsClient
    {
        partial void PrepareGetByRepoTypeByNamespaceByRepoDiscussionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::HuggingFace.RepoType27 repoType,
            ref string @namespace,
            ref string repo,
            ref int? p,
            ref global::HuggingFace.Type2? type,
            ref global::HuggingFace.Status? status,
            ref string? author,
            ref string? search,
            ref global::HuggingFace.Sort? sort);
        partial void PrepareGetByRepoTypeByNamespaceByRepoDiscussionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.RepoType27 repoType,
            string @namespace,
            string repo,
            int? p,
            global::HuggingFace.Type2? type,
            global::HuggingFace.Status? status,
            string? author,
            string? search,
            global::HuggingFace.Sort? sort);
        partial void ProcessGetByRepoTypeByNamespaceByRepoDiscussionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetByRepoTypeByNamespaceByRepoDiscussionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List discussions<br/>
        /// Get discussions for a repo
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="status">
        /// Default Value: all
        /// </param>
        /// <param name="author"></param>
        /// <param name="search"></param>
        /// <param name="sort">
        /// Default Value: recently-created
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.Response82> GetByRepoTypeByNamespaceByRepoDiscussionsAsync(
            global::HuggingFace.RepoType27 repoType,
            string @namespace,
            string repo,
            int? p = default,
            global::HuggingFace.Type2? type = default,
            global::HuggingFace.Status? status = default,
            string? author = default,
            string? search = default,
            global::HuggingFace.Sort? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetByRepoTypeByNamespaceByRepoDiscussionsArguments(
                httpClient: HttpClient,
                repoType: ref repoType,
                @namespace: ref @namespace,
                repo: ref repo,
                p: ref p,
                type: ref type,
                status: ref status,
                author: ref author,
                search: ref search,
                sort: ref sort);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/{repoType}/{@namespace}/{repo}/discussions",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("p", p?.ToString())
                .AddOptionalParameter("type", type?.ToValueString())
                .AddOptionalParameter("status", status?.ToValueString())
                .AddOptionalParameter("author", author)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sort", sort?.ToValueString()) 
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
            PrepareGetByRepoTypeByNamespaceByRepoDiscussionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                repoType: repoType,
                @namespace: @namespace,
                repo: repo,
                p: p,
                type: type,
                status: status,
                author: author,
                search: search,
                sort: sort);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetByRepoTypeByNamespaceByRepoDiscussionsResponse(
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
                ProcessGetByRepoTypeByNamespaceByRepoDiscussionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.Response82.FromJson(__content, JsonSerializerContext) ??
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
                        await global::HuggingFace.Response82.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::HuggingFace.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
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