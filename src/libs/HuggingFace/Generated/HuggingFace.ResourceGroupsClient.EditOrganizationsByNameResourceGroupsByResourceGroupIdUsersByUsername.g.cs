
#nullable enable

namespace HuggingFace
{
    public partial class ResourceGroupsClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameSecurityRequirement0,
            };
        partial void PrepareEditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string name,
            ref string resourceGroupId,
            ref string username,
            global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequest request);
        partial void PrepareEditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string name,
            string resourceGroupId,
            string username,
            global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequest request);
        partial void ProcessEditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Change user role<br/>
        /// Change the role of a user in a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse> EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync(
            string name,
            string resourceGroupId,
            string username,

            global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsResponseAsync(
                name: name,
                resourceGroupId: resourceGroupId,
                username: username,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Change user role<br/>
        /// Change the role of a user in a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse>> EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsResponseAsync(
            string name,
            string resourceGroupId,
            string username,

            global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameArguments(
                httpClient: HttpClient,
                name: ref name,
                resourceGroupId: ref resourceGroupId,
                username: ref username,
                request: request);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameSecurityRequirements,
                operationName: "EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync");

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
                                path: $"/api/organizations/{name}/resource-groups/{resourceGroupId}/users/{username}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::HuggingFace.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: new global::System.Net.Http.HttpMethod("PATCH"),
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
                PrepareEditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    name: name!,
                    resourceGroupId: resourceGroupId!,
                    username: username!,
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
                                operationId: "editOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsername",
                                methodName: "EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync",
                                pathTemplate: "$\"/api/organizations/{name}/resource-groups/{resourceGroupId}/users/{username}\"",
                                httpMethod: "PATCH",
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
                                operationId: "editOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsername",
                                methodName: "EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync",
                                pathTemplate: "$\"/api/organizations/{name}/resource-groups/{resourceGroupId}/users/{username}\"",
                                httpMethod: "PATCH",
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
                                operationId: "editOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsername",
                                methodName: "EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync",
                                pathTemplate: "$\"/api/organizations/{name}/resource-groups/{resourceGroupId}/users/{username}\"",
                                httpMethod: "PATCH",
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
                ProcessEditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::HuggingFace.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::HuggingFace.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "editOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsername",
                                methodName: "EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync",
                                pathTemplate: "$\"/api/organizations/{name}/resource-groups/{resourceGroupId}/users/{username}\"",
                                httpMethod: "PATCH",
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
                                operationId: "editOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsername",
                                methodName: "EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync",
                                pathTemplate: "$\"/api/organizations/{name}/resource-groups/{resourceGroupId}/users/{username}\"",
                                httpMethod: "PATCH",
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
                                ProcessEditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse>(
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

                                    var __value = await global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse>(
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
        /// <summary>
        /// Change user role<br/>
        /// Change the role of a user in a resource group.<br/>
        /// Requires the org to have a Team plan or higher.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="username"></param>
        /// <param name="role"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsResourceGroupsUsersResponse> EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync(
            string name,
            string resourceGroupId,
            string username,
            global::HuggingFace.AnyOf<global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequestRole?, string> role,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.PatchOrganizationsResourceGroupsUsersRequest
            {
                Role = role,
            };

            return await EditOrganizationsByNameResourceGroupsByResourceGroupIdUsersByUsernameAsync(
                name: name,
                resourceGroupId: resourceGroupId,
                username: username,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}