
#nullable enable

namespace HuggingFace
{
    public partial class SpacesClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_CreateSpacesByNamespaceByRepoCommitByRevSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_CreateSpacesByNamespaceByRepoCommitByRevSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_CreateSpacesByNamespaceByRepoCommitByRevSecurityRequirement0,
            };
        partial void PrepareCreateSpacesByNamespaceByRepoCommitByRevArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace,
            ref string repo,
            ref string rev,
            object? createPr,
            object? hotReload,
            ref global::HuggingFace.CreateSpacesCommitContentType? contentType);
        partial void PrepareCreateSpacesByNamespaceByRepoCommitByRevRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace,
            string repo,
            string rev,
            object? createPr,
            object? hotReload,
            global::HuggingFace.CreateSpacesCommitContentType? contentType);
        partial void ProcessCreateSpacesByNamespaceByRepoCommitByRevResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSpacesByNamespaceByRepoCommitByRevResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Commit<br/>
        /// For legacy reason, we support both `application/json` and `application/x-ndjson` but we recommend using `application/x-ndjson` to create a commit.<br/>
        /// JSON-lines payload:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "key": "header",<br/>
        ///   "value": {<br/>
        ///     "summary": "string (REQUIRED)",<br/>
        ///     "description": "string (OPTIONAL - defaults to empty string)",<br/>
        ///     "parentCommit": "string (OPTIONAL - 40-character hex SHA)"<br/>
        ///   }<br/>
        /// }<br/>
        /// {<br/>
        ///   "key": "file", <br/>
        ///   "value": {<br/>
        ///     "path": "string (REQUIRED)",<br/>
        ///     "content": "string (OPTIONAL - required if oldPath not set)",<br/>
        ///     "encoding": "utf-8 | base64 (OPTIONAL - defaults to utf-8)",<br/>
        ///     "oldPath": "string (OPTIONAL - for move/rename operations)"<br/>
        ///   }<br/>
        /// }<br/>
        /// {<br/>
        ///   "key": "deletedEntry",<br/>
        ///   "value": {<br/>
        ///     "path": "string (REQUIRED)"<br/>
        ///   }<br/>
        /// }<br/>
        /// {<br/>
        ///   "key": "lfsFile",<br/>
        ///   "value": {<br/>
        ///     "path": "string (REQUIRED - max 1000 chars)",<br/>
        ///     "oid": "string (OPTIONAL - required if oldPath not set, 64 hex chars)",<br/>
        ///     "algo": "sha256 (OPTIONAL - only sha256 supported)",<br/>
        ///     "size": "number (OPTIONAL - required if oldPath is set)",<br/>
        ///     "oldPath": "string (OPTIONAL - for move/rename operations)"<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// JSON payload:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "summary": "string (REQUIRED)",<br/>
        ///   "description": "string (OPTIONAL - defaults to empty string)",<br/>
        ///   "parentCommit": "string (OPTIONAL - 40-character hex SHA)"<br/>
        ///   "files": [<br/>
        ///     {<br/>
        ///       "path": "string (REQUIRED)",<br/>
        ///       "content": "string (OPTIONAL - required if oldPath not set)",<br/>
        ///       "encoding": "utf-8 | base64 (OPTIONAL - defaults to utf-8)",<br/>
        ///       "oldPath": "string (OPTIONAL - for move/rename operations)"<br/>
        ///     }<br/>
        ///   ],<br/>
        ///   "deletedEntries": [<br/>
        ///     {<br/>
        ///       "path": "string (REQUIRED)"<br/>
        ///     }<br/>
        ///   ],<br/>
        ///   "lfsFiles": [<br/>
        ///     {<br/>
        ///       "path": "string (REQUIRED - max 1000 chars)",<br/>
        ///       "oid": "string (OPTIONAL - required if oldPath not set, 64 hex chars)",<br/>
        ///       "algo": "sha256 (OPTIONAL - only sha256 supported)",<br/>
        ///       "size": "number (OPTIONAL - required if oldPath is set)",<br/>
        ///       "oldPath": "string (OPTIONAL - for move/rename operations)"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="createPr">
        /// Whether to create a pull request from the commit
        /// </param>
        /// <param name="hotReload">
        /// For Spaces, whether to try to hot reload the commit (only for single python files updates)
        /// </param>
        /// <param name="contentType">
        /// `application/x-ndjson` if you to commit by json lines<br/>
        /// Default Value: application/x-ndjson
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.CreateSpacesCommitResponse> CreateSpacesByNamespaceByRepoCommitByRevAsync(
            string @namespace,
            string repo,
            string rev,
            object? createPr = default,
            object? hotReload = default,
            global::HuggingFace.CreateSpacesCommitContentType? contentType = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateSpacesByNamespaceByRepoCommitByRevArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace,
                repo: ref repo,
                rev: ref rev,
                createPr: createPr,
                hotReload: hotReload,
                contentType: ref contentType);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateSpacesByNamespaceByRepoCommitByRevSecurityRequirements,
                operationName: "CreateSpacesByNamespaceByRepoCommitByRevAsync");

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
                                path: $"/api/spaces/{@namespace}/{repo}/commit/{rev}",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("create_pr", createPr?.ToString())
                                .AddOptionalParameter("hot_reload", hotReload?.ToString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::HuggingFace.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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

            if (contentType != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Content-Type", contentType?.ToValueString() ?? string.Empty);
            }

                global::HuggingFace.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateSpacesByNamespaceByRepoCommitByRevRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    @namespace: @namespace!,
                    repo: repo!,
                    rev: rev!,
                    createPr: createPr,
                    hotReload: hotReload,
                    contentType: contentType);

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
                                operationId: "createSpacesByNamespaceByRepoCommitByRev",
                                methodName: "CreateSpacesByNamespaceByRepoCommitByRevAsync",
                                pathTemplate: "$\"/api/spaces/{@namespace}/{repo}/commit/{rev}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createSpacesByNamespaceByRepoCommitByRev",
                                methodName: "CreateSpacesByNamespaceByRepoCommitByRevAsync",
                                pathTemplate: "$\"/api/spaces/{@namespace}/{repo}/commit/{rev}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::HuggingFace.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::HuggingFace.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createSpacesByNamespaceByRepoCommitByRev",
                                methodName: "CreateSpacesByNamespaceByRepoCommitByRevAsync",
                                pathTemplate: "$\"/api/spaces/{@namespace}/{repo}/commit/{rev}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::HuggingFace.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessCreateSpacesByNamespaceByRepoCommitByRevResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createSpacesByNamespaceByRepoCommitByRev",
                                methodName: "CreateSpacesByNamespaceByRepoCommitByRevAsync",
                                pathTemplate: "$\"/api/spaces/{@namespace}/{repo}/commit/{rev}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createSpacesByNamespaceByRepoCommitByRev",
                                methodName: "CreateSpacesByNamespaceByRepoCommitByRevAsync",
                                pathTemplate: "$\"/api/spaces/{@namespace}/{repo}/commit/{rev}\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                                ProcessCreateSpacesByNamespaceByRepoCommitByRevResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::HuggingFace.CreateSpacesCommitResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::HuggingFace.CreateSpacesCommitResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}