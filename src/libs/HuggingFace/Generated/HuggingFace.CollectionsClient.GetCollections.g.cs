
#nullable enable

namespace HuggingFace
{
    public partial class CollectionsClient
    {
        partial void PrepareGetCollectionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>? item,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? owner,
            ref string? q,
            ref global::HuggingFace.Sort3? sort,
            ref string? cursor,
            object? expand,
            ref double? limit);
        partial void PrepareGetCollectionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>? item,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? owner,
            string? q,
            global::HuggingFace.Sort3? sort,
            string? cursor,
            object? expand,
            double? limit);
        partial void ProcessGetCollectionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetCollectionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get collections
        /// </summary>
        /// <param name="item"></param>
        /// <param name="owner"></param>
        /// <param name="q"></param>
        /// <param name="sort">
        /// Default Value: trending
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="expand">
        /// Default Value: true
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1Item>, global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant2Item>>> GetCollectionsAsync(
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string>? item = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.Dictionary<string, string>>? owner = default,
            string? q = default,
            global::HuggingFace.Sort3? sort = default,
            string? cursor = default,
            object? expand = default,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetCollectionsArguments(
                httpClient: HttpClient,
                item: ref item,
                owner: ref owner,
                q: ref q,
                sort: ref sort,
                cursor: ref cursor,
                expand: expand,
                limit: ref limit);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/api/collections",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("item", item?.ToString())
                .AddOptionalParameter("owner", owner?.ToString())
                .AddOptionalParameter("q", q)
                .AddOptionalParameter("sort", sort?.ToValueString())
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("expand", expand?.ToString())
                .AddOptionalParameter("limit", limit?.ToString()) 
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
            PrepareGetCollectionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                item: item,
                owner: owner,
                q: q,
                sort: sort,
                cursor: cursor,
                expand: expand,
                limit: limit);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetCollectionsResponse(
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
                ProcessGetCollectionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1Item>, global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant2Item>>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant1Item>, global::System.Collections.Generic.IList<global::HuggingFace.ResponseVariant2Item>>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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