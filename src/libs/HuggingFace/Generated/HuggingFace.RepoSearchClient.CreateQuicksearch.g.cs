
#nullable enable

namespace HuggingFace
{
    public partial class RepoSearchClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_CreateQuicksearchSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_CreateQuicksearchSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_CreateQuicksearchSecurityRequirement0,
            };
        partial void PrepareCreateQuicksearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? q,
            ref int? limit,
            ref global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLang2?, string>? lang,
            ref global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLibrary2?, string>? library,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? type,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? orgsFilter,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? reposFilter,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines,
            global::System.Collections.Generic.IList<string>? exclude,
            ref string? @namespace,
            ref global::HuggingFace.AnyOf<bool?, object>? includeInvitees,
            ref string? repoName,
            ref global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRepoType2?, string>? repoType,
            ref string? discussionId,
            ref string? discussionCollectionName,
            global::System.Collections.Generic.IList<string>? spacesTags,
            global::HuggingFace.CreateQuicksearchRequest request);
        partial void PrepareCreateQuicksearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? q,
            int? limit,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLang2?, string>? lang,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLibrary2?, string>? library,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? type,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? orgsFilter,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? reposFilter,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines,
            global::System.Collections.Generic.IList<string>? exclude,
            string? @namespace,
            global::HuggingFace.AnyOf<bool?, object>? includeInvitees,
            string? repoName,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRepoType2?, string>? repoType,
            string? discussionId,
            string? discussionCollectionName,
            global::System.Collections.Generic.IList<string>? spacesTags,
            global::HuggingFace.CreateQuicksearchRequest request);
        partial void ProcessCreateQuicksearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateQuicksearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Quick search<br/>
        /// Quick search for models, datasets, spaces, orgs, users, papers, collections, and buckets
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <param name="lang"></param>
        /// <param name="library"></param>
        /// <param name="type"></param>
        /// <param name="orgsFilter"></param>
        /// <param name="reposFilter"></param>
        /// <param name="pipelines">
        /// Comma-separated or array of pipeline types
        /// </param>
        /// <param name="exclude">
        /// Array of excluded resources: spaces/repo, models/repo, datasets/repo, papers/paperId, collections/collectionId, users/username, orgs/orgName, buckets/bucketName<br/>
        /// Default Value: []
        /// </param>
        /// <param name="namespace">
        /// Namespace to filter by
        /// </param>
        /// <param name="includeInvitees">
        /// Default Value: false
        /// </param>
        /// <param name="repoName"></param>
        /// <param name="repoType"></param>
        /// <param name="discussionId"></param>
        /// <param name="discussionCollectionName"></param>
        /// <param name="spacesTags"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.CreateQuicksearchResponse> CreateQuicksearchAsync(

            global::HuggingFace.CreateQuicksearchRequest request,
            string? q = default,
            int? limit = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLang2?, string>? lang = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLibrary2?, string>? library = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? type = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? orgsFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? reposFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            string? @namespace = default,
            global::HuggingFace.AnyOf<bool?, object>? includeInvitees = default,
            string? repoName = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRepoType2?, string>? repoType = default,
            string? discussionId = default,
            string? discussionCollectionName = default,
            global::System.Collections.Generic.IList<string>? spacesTags = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateQuicksearchAsResponseAsync(

                request: request,
                q: q,
                limit: limit,
                lang: lang,
                library: library,
                type: type,
                orgsFilter: orgsFilter,
                reposFilter: reposFilter,
                pipelines: pipelines,
                exclude: exclude,
                @namespace: @namespace,
                includeInvitees: includeInvitees,
                repoName: repoName,
                repoType: repoType,
                discussionId: discussionId,
                discussionCollectionName: discussionCollectionName,
                spacesTags: spacesTags,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Quick search<br/>
        /// Quick search for models, datasets, spaces, orgs, users, papers, collections, and buckets
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <param name="lang"></param>
        /// <param name="library"></param>
        /// <param name="type"></param>
        /// <param name="orgsFilter"></param>
        /// <param name="reposFilter"></param>
        /// <param name="pipelines">
        /// Comma-separated or array of pipeline types
        /// </param>
        /// <param name="exclude">
        /// Array of excluded resources: spaces/repo, models/repo, datasets/repo, papers/paperId, collections/collectionId, users/username, orgs/orgName, buckets/bucketName<br/>
        /// Default Value: []
        /// </param>
        /// <param name="namespace">
        /// Namespace to filter by
        /// </param>
        /// <param name="includeInvitees">
        /// Default Value: false
        /// </param>
        /// <param name="repoName"></param>
        /// <param name="repoType"></param>
        /// <param name="discussionId"></param>
        /// <param name="discussionCollectionName"></param>
        /// <param name="spacesTags"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateQuicksearchResponse>> CreateQuicksearchAsResponseAsync(

            global::HuggingFace.CreateQuicksearchRequest request,
            string? q = default,
            int? limit = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLang2?, string>? lang = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLibrary2?, string>? library = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? type = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? orgsFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? reposFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            string? @namespace = default,
            global::HuggingFace.AnyOf<bool?, object>? includeInvitees = default,
            string? repoName = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRepoType2?, string>? repoType = default,
            string? discussionId = default,
            string? discussionCollectionName = default,
            global::System.Collections.Generic.IList<string>? spacesTags = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateQuicksearchArguments(
                httpClient: HttpClient,
                q: ref q,
                limit: ref limit,
                lang: ref lang,
                library: ref library,
                type: ref type,
                orgsFilter: ref orgsFilter,
                reposFilter: ref reposFilter,
                pipelines: ref pipelines,
                exclude: exclude,
                @namespace: ref @namespace,
                includeInvitees: ref includeInvitees,
                repoName: ref repoName,
                repoType: ref repoType,
                discussionId: ref discussionId,
                discussionCollectionName: ref discussionCollectionName,
                spacesTags: spacesTags,
                request: request);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateQuicksearchSecurityRequirements,
                operationName: "CreateQuicksearchAsync");

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
                                path: "/api/quicksearch",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("q", q)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("lang", lang?.ToString())
                                .AddOptionalParameter("library", library?.ToString())
                                .AddOptionalParameter("type", type?.ToString())
                                .AddOptionalParameter("orgsFilter", orgsFilter?.ToString())
                                .AddOptionalParameter("reposFilter", reposFilter?.ToString())
                                .AddOptionalParameter("pipelines", pipelines?.ToString())
                                .AddOptionalParameter("exclude", exclude, delimiter: ",", explode: true)
                                .AddOptionalParameter("namespace", @namespace)
                                .AddOptionalParameter("includeInvitees", includeInvitees?.ToString())
                                .AddOptionalParameter("repoName", repoName)
                                .AddOptionalParameter("repoType", repoType?.ToString())
                                .AddOptionalParameter("discussionId", discussionId)
                                .AddOptionalParameter("discussionCollectionName", discussionCollectionName)
                                .AddOptionalParameter("spacesTags", spacesTags, delimiter: ",", explode: true)
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::HuggingFace.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateQuicksearchRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    q: q,
                    limit: limit,
                    lang: lang,
                    library: library,
                    type: type,
                    orgsFilter: orgsFilter,
                    reposFilter: reposFilter,
                    pipelines: pipelines,
                    exclude: exclude,
                    @namespace: @namespace,
                    includeInvitees: includeInvitees,
                    repoName: repoName,
                    repoType: repoType,
                    discussionId: discussionId,
                    discussionCollectionName: discussionCollectionName,
                    spacesTags: spacesTags,
                    request: request);

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
                                operationId: "createQuicksearch",
                                methodName: "CreateQuicksearchAsync",
                                pathTemplate: "\"/api/quicksearch\"",
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
                                operationId: "createQuicksearch",
                                methodName: "CreateQuicksearchAsync",
                                pathTemplate: "\"/api/quicksearch\"",
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
                                operationId: "createQuicksearch",
                                methodName: "CreateQuicksearchAsync",
                                pathTemplate: "\"/api/quicksearch\"",
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
                ProcessCreateQuicksearchResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createQuicksearch",
                                methodName: "CreateQuicksearchAsync",
                                pathTemplate: "\"/api/quicksearch\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createQuicksearch",
                                methodName: "CreateQuicksearchAsync",
                                pathTemplate: "\"/api/quicksearch\"",
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
                                ProcessCreateQuicksearchResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::HuggingFace.CreateQuicksearchResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateQuicksearchResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::HuggingFace.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    var __value = await global::HuggingFace.CreateQuicksearchResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.CreateQuicksearchResponse>(
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
        /// <summary>
        /// Quick search<br/>
        /// Quick search for models, datasets, spaces, orgs, users, papers, collections, and buckets
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <param name="lang"></param>
        /// <param name="library"></param>
        /// <param name="type"></param>
        /// <param name="orgsFilter"></param>
        /// <param name="reposFilter"></param>
        /// <param name="pipelines">
        /// Comma-separated or array of pipeline types
        /// </param>
        /// <param name="exclude">
        /// Array of excluded resources: spaces/repo, models/repo, datasets/repo, papers/paperId, collections/collectionId, users/username, orgs/orgName, buckets/bucketName<br/>
        /// Default Value: []
        /// </param>
        /// <param name="namespace">
        /// Namespace to filter by
        /// </param>
        /// <param name="includeInvitees">
        /// Default Value: false
        /// </param>
        /// <param name="repoName"></param>
        /// <param name="repoType"></param>
        /// <param name="discussionId"></param>
        /// <param name="discussionCollectionName"></param>
        /// <param name="spacesTags"></param>
        /// <param name="requestQ"></param>
        /// <param name="requestLimit"></param>
        /// <param name="requestLang"></param>
        /// <param name="requestLibrary"></param>
        /// <param name="requestType"></param>
        /// <param name="requestOrgsFilter"></param>
        /// <param name="requestReposFilter"></param>
        /// <param name="requestPipelines">
        /// Comma-separated or array of pipeline types
        /// </param>
        /// <param name="requestExclude">
        /// Array of excluded resources: spaces/repo, models/repo, datasets/repo, papers/paperId, collections/collectionId, users/username, orgs/orgName, buckets/bucketName<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestNamespace">
        /// Namespace to filter by
        /// </param>
        /// <param name="requestIncludeInvitees">
        /// Default Value: false
        /// </param>
        /// <param name="requestRepoName"></param>
        /// <param name="requestRepoType"></param>
        /// <param name="requestDiscussionId"></param>
        /// <param name="requestDiscussionCollectionName"></param>
        /// <param name="requestSpacesTags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.CreateQuicksearchResponse> CreateQuicksearchAsync(
            global::System.Collections.Generic.IList<string> requestExclude,
            string? q = default,
            int? limit = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLang2?, string>? lang = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchLibrary2?, string>? library = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? type = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? orgsFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? reposFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            string? @namespace = default,
            global::HuggingFace.AnyOf<bool?, object>? includeInvitees = default,
            string? repoName = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRepoType2?, string>? repoType = default,
            string? discussionId = default,
            string? discussionCollectionName = default,
            global::System.Collections.Generic.IList<string>? spacesTags = default,
            string? requestQ = default,
            int? requestLimit = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLang?, string>? requestLang = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestLibrary?, string>? requestLibrary = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? requestType = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? requestOrgsFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? requestReposFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.CreateQuicksearchRequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? requestPipelines = default,
            string? requestNamespace = default,
            global::HuggingFace.AnyOf<bool?, object>? requestIncludeInvitees = default,
            string? requestRepoName = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateQuicksearchRequestRepoType?, string>? requestRepoType = default,
            string? requestDiscussionId = default,
            string? requestDiscussionCollectionName = default,
            global::System.Collections.Generic.IList<string>? requestSpacesTags = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.CreateQuicksearchRequest
            {
                Q = requestQ,
                Limit = requestLimit,
                Lang = requestLang,
                Library = requestLibrary,
                Type = requestType,
                OrgsFilter = requestOrgsFilter,
                ReposFilter = requestReposFilter,
                Pipelines = requestPipelines,
                Exclude = requestExclude,
                Namespace = requestNamespace,
                IncludeInvitees = requestIncludeInvitees,
                RepoName = requestRepoName,
                RepoType = requestRepoType,
                DiscussionId = requestDiscussionId,
                DiscussionCollectionName = requestDiscussionCollectionName,
                SpacesTags = requestSpacesTags,
            };

            return await CreateQuicksearchAsync(
                q: q,
                limit: limit,
                lang: lang,
                library: library,
                type: type,
                orgsFilter: orgsFilter,
                reposFilter: reposFilter,
                pipelines: pipelines,
                exclude: exclude,
                @namespace: @namespace,
                includeInvitees: includeInvitees,
                repoName: repoName,
                repoType: repoType,
                discussionId: discussionId,
                discussionCollectionName: discussionCollectionName,
                spacesTags: spacesTags,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}