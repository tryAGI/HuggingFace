
#nullable enable

namespace HuggingFace
{
    public partial class BucketsClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_GetBucketsByNamespaceByRepoEventsSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_GetBucketsByNamespaceByRepoEventsSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_GetBucketsByNamespaceByRepoEventsSecurityRequirement0,
            };
        partial void PrepareGetBucketsByNamespaceByRepoEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace,
            ref string repo,
            ref string? cursor,
            ref global::System.DateTime? since);
        partial void PrepareGetBucketsByNamespaceByRepoEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace,
            string repo,
            string? cursor,
            global::System.DateTime? since);
        partial void ProcessGetBucketsByNamespaceByRepoEventsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Follow changes<br/>
        /// Server-sent events (`Accept: text/event-stream`) of the bucket's file changes, so clients can stop polling `/tree`.<br/>
        /// Events:<br/>
        /// - `ready`: `{"cursor"}` — replay (if any) is done, live changes follow. `cursor` may be absent if the feed has seen no change yet.<br/>
        /// - `changes`: `{"cursor", "changes": [{"path", "op": "add" | "update" | "delete", "size"?, "xetHash"?, "uploadedAt"?, "mtime"?, "mtimeNanos"?}]}` — a batch of changes coalesced over ~200ms. An `update` only carries the fields that changed (an identical re-upload has just `uploadedAt`); `mtime`/`mtimeNanos` are `null` when a re-upload cleared them. `xetHash` is omitted without content read access.<br/>
        /// - `reset`: `{"reason": "cursor_too_old"}` — the requested `cursor`/`since` is older than what the server buffers (about 15 minutes); the stream ends and the client must re-list. A `since` at or after the bucket's `updatedAt` never resets, however old.<br/>
        /// - `reconnect`: `{"cursor"}` — sent after 20 minutes or when the server shuts down (deploys), then the stream ends; reconnect with that cursor. Treat any other end of the stream the same way: reconnect with the last cursor you received.<br/>
        /// A `: ping` comment is sent every 30s. Resume with `?cursor=` (exclusive) or `?since=` (inclusive); without either, only live changes are sent.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cursor">
        /// Opaque cursor from a previous `ready`/`changes` event; resume after it
        /// </param>
        /// <param name="since">
        /// Resume from this instant instead of a cursor (e.g. the bucket's `updatedAt` you last saw)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task GetBucketsByNamespaceByRepoEventsAsync(
            string @namespace,
            string repo,
            string? cursor = default,
            global::System.DateTime? since = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            await GetBucketsByNamespaceByRepoEventsAsResponseAsync(
                @namespace: @namespace,
                repo: repo,
                cursor: cursor,
                since: since,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
        }
        /// <summary>
        /// Follow changes<br/>
        /// Server-sent events (`Accept: text/event-stream`) of the bucket's file changes, so clients can stop polling `/tree`.<br/>
        /// Events:<br/>
        /// - `ready`: `{"cursor"}` — replay (if any) is done, live changes follow. `cursor` may be absent if the feed has seen no change yet.<br/>
        /// - `changes`: `{"cursor", "changes": [{"path", "op": "add" | "update" | "delete", "size"?, "xetHash"?, "uploadedAt"?, "mtime"?, "mtimeNanos"?}]}` — a batch of changes coalesced over ~200ms. An `update` only carries the fields that changed (an identical re-upload has just `uploadedAt`); `mtime`/`mtimeNanos` are `null` when a re-upload cleared them. `xetHash` is omitted without content read access.<br/>
        /// - `reset`: `{"reason": "cursor_too_old"}` — the requested `cursor`/`since` is older than what the server buffers (about 15 minutes); the stream ends and the client must re-list. A `since` at or after the bucket's `updatedAt` never resets, however old.<br/>
        /// - `reconnect`: `{"cursor"}` — sent after 20 minutes or when the server shuts down (deploys), then the stream ends; reconnect with that cursor. Treat any other end of the stream the same way: reconnect with the last cursor you received.<br/>
        /// A `: ping` comment is sent every 30s. Resume with `?cursor=` (exclusive) or `?since=` (inclusive); without either, only live changes are sent.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cursor">
        /// Opaque cursor from a previous `ready`/`changes` event; resume after it
        /// </param>
        /// <param name="since">
        /// Resume from this instant instead of a cursor (e.g. the bucket's `updatedAt` you last saw)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse> GetBucketsByNamespaceByRepoEventsAsResponseAsync(
            string @namespace,
            string repo,
            string? cursor = default,
            global::System.DateTime? since = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetBucketsByNamespaceByRepoEventsArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace,
                repo: ref repo,
                cursor: ref cursor,
                since: ref since);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetBucketsByNamespaceByRepoEventsSecurityRequirements,
                operationName: "GetBucketsByNamespaceByRepoEventsAsync");

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
                                path: $"/api/buckets/{@namespace}/{repo}/events",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("cursor", cursor)
                                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
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
                PrepareGetBucketsByNamespaceByRepoEventsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    @namespace: @namespace!,
                    repo: repo!,
                    cursor: cursor,
                    since: since);

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
                                operationId: "getBucketsByNamespaceByRepoEvents",
                                methodName: "GetBucketsByNamespaceByRepoEventsAsync",
                                pathTemplate: "$\"/api/buckets/{@namespace}/{repo}/events\"",
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
                                operationId: "getBucketsByNamespaceByRepoEvents",
                                methodName: "GetBucketsByNamespaceByRepoEventsAsync",
                                pathTemplate: "$\"/api/buckets/{@namespace}/{repo}/events\"",
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
                                operationId: "getBucketsByNamespaceByRepoEvents",
                                methodName: "GetBucketsByNamespaceByRepoEventsAsync",
                                pathTemplate: "$\"/api/buckets/{@namespace}/{repo}/events\"",
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
                ProcessGetBucketsByNamespaceByRepoEventsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getBucketsByNamespaceByRepoEvents",
                                methodName: "GetBucketsByNamespaceByRepoEventsAsync",
                                pathTemplate: "$\"/api/buckets/{@namespace}/{repo}/events\"",
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
                                operationId: "getBucketsByNamespaceByRepoEvents",
                                methodName: "GetBucketsByNamespaceByRepoEventsAsync",
                                pathTemplate: "$\"/api/buckets/{@namespace}/{repo}/events\"",
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
                            // Live follow is not served by this instance, or not caught up yet; retry after `Retry-After` seconds
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::HuggingFace.GetBucketsEventsResponse? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::HuggingFace.GetBucketsEventsResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::HuggingFace.GetBucketsEventsResponse.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::HuggingFace.ApiException<global::HuggingFace.GetBucketsEventsResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                return new global::HuggingFace.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::HuggingFace.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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
                                    return new global::HuggingFace.AutoSDKHttpResponse(
                                        statusCode: __response.StatusCode,
                                        headers: global::HuggingFace.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri);
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