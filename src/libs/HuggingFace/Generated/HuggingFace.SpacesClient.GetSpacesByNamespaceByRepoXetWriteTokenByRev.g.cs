
#nullable enable

namespace HuggingFace
{
    public partial class SpacesClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_GetSpacesByNamespaceByRepoXetWriteTokenByRevSecurityRequirement0 =
            new global::HuggingFace.EndPointSecurityRequirement
            {
                Authorizations = new global::HuggingFace.EndPointAuthorizationRequirement[]
                {                    new global::HuggingFace.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_GetSpacesByNamespaceByRepoXetWriteTokenByRevSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_GetSpacesByNamespaceByRepoXetWriteTokenByRevSecurityRequirement0,
            };
        partial void PrepareGetSpacesByNamespaceByRepoXetWriteTokenByRevArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace,
            ref string repo,
            ref string rev);
        partial void PrepareGetSpacesByNamespaceByRepoXetWriteTokenByRevRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace,
            string repo,
            string rev);
        partial void ProcessGetSpacesByNamespaceByRepoXetWriteTokenByRevResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSpacesByNamespaceByRepoXetWriteTokenByRevResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Xet write token<br/>
        /// Get a write short-lived access token for XET upload
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.GetSpacesXetWriteTokenResponse> GetSpacesByNamespaceByRepoXetWriteTokenByRevAsync(
            string @namespace,
            string repo,
            string rev,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetSpacesByNamespaceByRepoXetWriteTokenByRevAsResponseAsync(
                @namespace: @namespace,
                repo: repo,
                rev: rev,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Xet write token<br/>
        /// Get a write short-lived access token for XET upload
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="rev"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetSpacesXetWriteTokenResponse>> GetSpacesByNamespaceByRepoXetWriteTokenByRevAsResponseAsync(
            string @namespace,
            string repo,
            string rev,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSpacesByNamespaceByRepoXetWriteTokenByRevArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace,
                repo: ref repo,
                rev: ref rev);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetSpacesByNamespaceByRepoXetWriteTokenByRevSecurityRequirements,
                operationName: "GetSpacesByNamespaceByRepoXetWriteTokenByRevAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/spaces/{@namespace}/{repo}/xet-write-token/{rev}",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareGetSpacesByNamespaceByRepoXetWriteTokenByRevRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                @namespace: @namespace,
                repo: repo,
                rev: rev);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSpacesByNamespaceByRepoXetWriteTokenByRevResponse(
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
                ProcessGetSpacesByNamespaceByRepoXetWriteTokenByRevResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = global::HuggingFace.GetSpacesXetWriteTokenResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetSpacesXetWriteTokenResponse>(
                        statusCode: __response.StatusCode,
                        headers: global::HuggingFace.AutoSDKHttpResponse.CreateHeaders(__response),
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    var __value = await global::HuggingFace.GetSpacesXetWriteTokenResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetSpacesXetWriteTokenResponse>(
                        statusCode: __response.StatusCode,
                        headers: global::HuggingFace.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __value);
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