
#nullable enable

namespace HuggingFace
{
    public partial class KernelsClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_GetKernelsSecurityRequirement0 =
            new global::HuggingFace.EndPointSecurityRequirement
            {
                Authorizations = new global::HuggingFace.EndPointAuthorizationRequirement[]
                {                    new global::HuggingFace.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_GetKernelsSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_GetKernelsSecurityRequirement0,
            };
        partial void PrepareGetKernelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? search,
            ref global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? author,
            ref global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? id,
            ref global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? arxivIds,
            ref global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? filter,
            ref global::HuggingFace.GetKernelsSort? sort,
            ref global::HuggingFace.GetKernelsDirection? direction,
            ref int? limit,
            ref string? cursor,
            ref bool? full,
            ref bool? gated,
            ref global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>? expand);
        partial void PrepareGetKernelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? search,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? author,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? id,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? arxivIds,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? filter,
            global::HuggingFace.GetKernelsSort? sort,
            global::HuggingFace.GetKernelsDirection? direction,
            int? limit,
            string? cursor,
            bool? full,
            bool? gated,
            global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>? expand);
        partial void ProcessGetKernelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetKernelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List kernels<br/>
        /// List kernels with optional filtering, sorting, and pagination
        /// </summary>
        /// <param name="search">
        /// Filter by search term
        /// </param>
        /// <param name="author">
        /// Filter by author
        /// </param>
        /// <param name="id">
        /// Filter by ID
        /// </param>
        /// <param name="arxivIds">
        /// Filter by Arxiv ID
        /// </param>
        /// <param name="filter">
        /// Filter by tags
        /// </param>
        /// <param name="sort">
        /// Sort field (e.g. downloads, likes, lastModified, trendingScore)<br/>
        /// Default Value: trendingScore
        /// </param>
        /// <param name="direction">
        /// Sort direction: 1 for ascending, -1 for descending<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from Link header
        /// </param>
        /// <param name="full">
        /// Return full kernel info including author, sha, lastModified, files, gated
        /// </param>
        /// <param name="gated">
        /// Filter by gated
        /// </param>
        /// <param name="expand">
        /// Display specific fields in the response
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>> GetKernelsAsync(
            string? search = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? author = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? id = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? arxivIds = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? filter = default,
            global::HuggingFace.GetKernelsSort? sort = default,
            global::HuggingFace.GetKernelsDirection? direction = default,
            int? limit = default,
            string? cursor = default,
            bool? full = default,
            bool? gated = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>? expand = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetKernelsAsResponseAsync(
                search: search,
                author: author,
                id: id,
                arxivIds: arxivIds,
                filter: filter,
                sort: sort,
                direction: direction,
                limit: limit,
                cursor: cursor,
                full: full,
                gated: gated,
                expand: expand,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List kernels<br/>
        /// List kernels with optional filtering, sorting, and pagination
        /// </summary>
        /// <param name="search">
        /// Filter by search term
        /// </param>
        /// <param name="author">
        /// Filter by author
        /// </param>
        /// <param name="id">
        /// Filter by ID
        /// </param>
        /// <param name="arxivIds">
        /// Filter by Arxiv ID
        /// </param>
        /// <param name="filter">
        /// Filter by tags
        /// </param>
        /// <param name="sort">
        /// Sort field (e.g. downloads, likes, lastModified, trendingScore)<br/>
        /// Default Value: trendingScore
        /// </param>
        /// <param name="direction">
        /// Sort direction: 1 for ascending, -1 for descending<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from Link header
        /// </param>
        /// <param name="full">
        /// Return full kernel info including author, sha, lastModified, files, gated
        /// </param>
        /// <param name="gated">
        /// Filter by gated
        /// </param>
        /// <param name="expand">
        /// Display specific fields in the response
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>>> GetKernelsAsResponseAsync(
            string? search = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? author = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? id = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? arxivIds = default,
            global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>? filter = default,
            global::HuggingFace.GetKernelsSort? sort = default,
            global::HuggingFace.GetKernelsDirection? direction = default,
            int? limit = default,
            string? cursor = default,
            bool? full = default,
            bool? gated = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetKernelsExpand2?, global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsExpandItem>>? expand = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetKernelsArguments(
                httpClient: HttpClient,
                search: ref search,
                author: ref author,
                id: ref id,
                arxivIds: ref arxivIds,
                filter: ref filter,
                sort: ref sort,
                direction: ref direction,
                limit: ref limit,
                cursor: ref cursor,
                full: ref full,
                gated: ref gated,
                expand: ref expand);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetKernelsSecurityRequirements,
                operationName: "GetKernelsAsync");

            using var __timeoutCancellationTokenSource = global::HuggingFace.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::HuggingFace.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::HuggingFace.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::HuggingFace.PathBuilder(
                                path: "/api/kernels",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("author", author?.ToString())
                                .AddOptionalParameter("id", id?.ToString())
                                .AddOptionalParameter("arxivIds", arxivIds?.ToString())
                                .AddOptionalParameter("filter", filter?.ToString())
                                .AddOptionalParameter("sort", sort?.ToValueString())
                                .AddOptionalParameter("direction", direction?.ToValueString())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("cursor", cursor)
                                .AddOptionalParameter("full", full?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("gated", gated?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("expand", expand?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::HuggingFace.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::HuggingFace.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetKernelsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    search: search,
                    author: author,
                    id: id,
                    arxivIds: arxivIds,
                    filter: filter,
                    sort: sort,
                    direction: direction,
                    limit: limit,
                    cursor: cursor,
                    full: full,
                    gated: gated,
                    expand: expand);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::HuggingFace.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getKernels",
                                methodName: "GetKernelsAsync",
                                pathTemplate: "\"/api/kernels\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::HuggingFace.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getKernels",
                                methodName: "GetKernelsAsync",
                                pathTemplate: "\"/api/kernels\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::HuggingFace.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::HuggingFace.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::HuggingFace.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getKernels",
                                methodName: "GetKernelsAsync",
                                pathTemplate: "\"/api/kernels\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::HuggingFace.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetKernelsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getKernels",
                                methodName: "GetKernelsAsync",
                                pathTemplate: "\"/api/kernels\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getKernels",
                                methodName: "GetKernelsAsync",
                                pathTemplate: "\"/api/kernels\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetKernelsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::HuggingFace.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::HuggingFace.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = (global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetKernelsResponseItem>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::HuggingFace.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::HuggingFace.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}