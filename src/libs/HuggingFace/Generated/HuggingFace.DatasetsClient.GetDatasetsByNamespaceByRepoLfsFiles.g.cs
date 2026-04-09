
#nullable enable

namespace HuggingFace
{
    public partial class DatasetsClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_GetDatasetsByNamespaceByRepoLfsFilesSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_GetDatasetsByNamespaceByRepoLfsFilesSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_GetDatasetsByNamespaceByRepoLfsFilesSecurityRequirement0,
            };
        partial void PrepareGetDatasetsByNamespaceByRepoLfsFilesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace,
            ref string repo,
            ref string? cursor,
            ref int? limit,
            object? xet);
        partial void PrepareGetDatasetsByNamespaceByRepoLfsFilesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace,
            string repo,
            string? cursor,
            int? limit,
            object? xet);
        partial void ProcessGetDatasetsByNamespaceByRepoLfsFilesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDatasetsByNamespaceByRepoLfsFilesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Large files<br/>
        /// List Xet/LFS files for a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="xet"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>> GetDatasetsByNamespaceByRepoLfsFilesAsync(
            string @namespace,
            string repo,
            string? cursor = default,
            int? limit = default,
            object? xet = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetDatasetsByNamespaceByRepoLfsFilesAsResponseAsync(
                @namespace: @namespace,
                repo: repo,
                cursor: cursor,
                limit: limit,
                xet: xet,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Large files<br/>
        /// List Xet/LFS files for a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="xet"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>>> GetDatasetsByNamespaceByRepoLfsFilesAsResponseAsync(
            string @namespace,
            string repo,
            string? cursor = default,
            int? limit = default,
            object? xet = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDatasetsByNamespaceByRepoLfsFilesArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace,
                repo: ref repo,
                cursor: ref cursor,
                limit: ref limit,
                xet: xet);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetDatasetsByNamespaceByRepoLfsFilesSecurityRequirements,
                operationName: "GetDatasetsByNamespaceByRepoLfsFilesAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/datasets/{@namespace}/{repo}/lfs-files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("xet", xet?.ToString()) 
                ;
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
            PrepareGetDatasetsByNamespaceByRepoLfsFilesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                @namespace: @namespace,
                repo: repo,
                cursor: cursor,
                limit: limit,
                xet: xet);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetDatasetsByNamespaceByRepoLfsFilesResponse(
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
                ProcessGetDatasetsByNamespaceByRepoLfsFilesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = (global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>), JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>>(
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

                    var __value = (global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>), JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::HuggingFace.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsLfsFilesResponseItem>>(
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