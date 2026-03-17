
#nullable enable

namespace HuggingFace
{
    public partial class SpacesClient
    {
        partial void PrepareGetByRepoTypeByNamespaceByRepoByResolveTypeByRevByPathArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::HuggingFace.RepoType49 repoType,
            ref string @namespace,
            ref string repo,
            ref global::HuggingFace.ResolveType resolveType,
            ref string rev,
            ref string path,
            ref string? range,
            ref string? accept);
        partial void PrepareGetByRepoTypeByNamespaceByRepoByResolveTypeByRevByPathRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.RepoType49 repoType,
            string @namespace,
            string repo,
            global::HuggingFace.ResolveType resolveType,
            string rev,
            string path,
            string? range,
            string? accept);
        partial void ProcessGetByRepoTypeByNamespaceByRepoByResolveTypeByRevByPathResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetByRepoTypeByNamespaceByRepoByResolveTypeByRevByPathResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Resolve a file<br/>
        /// This endpoint requires to follow redirection
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="resolveType"></param>
        /// <param name="rev"></param>
        /// <param name="path">
        /// Wildcard path parameter
        /// </param>
        /// <param name="range">
        /// The range in bytes of the file to download
        /// </param>
        /// <param name="accept">
        /// Returns json information about the XET file info - if the file is a xet file
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.Response104> GetByRepoTypeByNamespaceByRepoByResolveTypeByRevByPathAsync(
            global::HuggingFace.RepoType49 repoType,
            string @namespace,
            string repo,
            global::HuggingFace.ResolveType resolveType,
            string rev,
            string path,
            string? range = default,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetByRepoTypeByNamespaceByRepoByResolveTypeByRevByPathArguments(
                httpClient: HttpClient,
                repoType: ref repoType,
                @namespace: ref @namespace,
                repo: ref repo,
                resolveType: ref resolveType,
                rev: ref rev,
                path: ref path,
                range: ref range,
                accept: ref accept);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/{repoType}/{@namespace}/{repo}/{resolveType}/{rev}/{path}",
                baseUri: HttpClient.BaseAddress); 
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

            if (range != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Range", range.ToString());
            }
            if (accept != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Accept", accept.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetByRepoTypeByNamespaceByRepoByResolveTypeByRevByPathRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                repoType: repoType,
                @namespace: @namespace,
                repo: repo,
                resolveType: resolveType,
                rev: rev,
                path: path,
                range: range,
                accept: accept);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetByRepoTypeByNamespaceByRepoByResolveTypeByRevByPathResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Redirection to file
            if ((int)__response.StatusCode == 302)
            {
                string? __content_302 = null;
                global::System.Exception? __exception_302 = null;
                string? __value_302 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_302 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_302 = global::System.Text.Json.JsonSerializer.Deserialize(__content_302, typeof(string), JsonSerializerContext) as string;
                    }
                    else
                    {
                        var __contentStream_302 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_302 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_302, typeof(string), JsonSerializerContext).ConfigureAwait(false) as string;
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_302 = __ex;
                }

                throw new global::HuggingFace.ApiException<string>(
                    message: __content_302 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_302,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_302,
                    ResponseObject = __value_302,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not modified
            if ((int)__response.StatusCode == 304)
            {
                string? __content_304 = null;
                global::System.Exception? __exception_304 = null;
                string? __value_304 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_304 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_304 = global::System.Text.Json.JsonSerializer.Deserialize(__content_304, typeof(string), JsonSerializerContext) as string;
                    }
                    else
                    {
                        var __contentStream_304 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_304 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_304, typeof(string), JsonSerializerContext).ConfigureAwait(false) as string;
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_304 = __ex;
                }

                throw new global::HuggingFace.ApiException<string>(
                    message: __content_304 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_304,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_304,
                    ResponseObject = __value_304,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Redirection to Xet endpoint
            if ((int)__response.StatusCode == 307)
            {
                string? __content_307 = null;
                global::System.Exception? __exception_307 = null;
                string? __value_307 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_307 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_307 = global::System.Text.Json.JsonSerializer.Deserialize(__content_307, typeof(string), JsonSerializerContext) as string;
                    }
                    else
                    {
                        var __contentStream_307 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_307 = await global::System.Text.Json.JsonSerializer.DeserializeAsync(__contentStream_307, typeof(string), JsonSerializerContext).ConfigureAwait(false) as string;
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_307 = __ex;
                }

                throw new global::HuggingFace.ApiException<string>(
                    message: __content_307 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_307,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_307,
                    ResponseObject = __value_307,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessGetByRepoTypeByNamespaceByRepoByResolveTypeByRevByPathResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.Response104.FromJson(__content, JsonSerializerContext) ??
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
                        await global::HuggingFace.Response104.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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