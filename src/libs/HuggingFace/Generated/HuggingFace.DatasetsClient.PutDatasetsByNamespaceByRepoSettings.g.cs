
#nullable enable

namespace HuggingFace
{
    public partial class DatasetsClient
    {
        partial void PreparePutDatasetsByNamespaceByRepoSettingsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace,
            ref string repo,
            global::HuggingFace.PutDatasetsSettingsRequest request);
        partial void PreparePutDatasetsByNamespaceByRepoSettingsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace,
            string repo,
            global::HuggingFace.PutDatasetsSettingsRequest request);
        partial void ProcessPutDatasetsByNamespaceByRepoSettingsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPutDatasetsByNamespaceByRepoSettingsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update repo settings<br/>
        /// Update the settings of a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.PutDatasetsSettingsResponse> PutDatasetsByNamespaceByRepoSettingsAsync(
            string @namespace,
            string repo,

            global::HuggingFace.PutDatasetsSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePutDatasetsByNamespaceByRepoSettingsArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace,
                repo: ref repo,
                request: request);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/datasets/{@namespace}/{repo}/settings",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePutDatasetsByNamespaceByRepoSettingsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                @namespace: @namespace,
                repo: repo,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPutDatasetsByNamespaceByRepoSettingsResponse(
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
                ProcessPutDatasetsByNamespaceByRepoSettingsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.PutDatasetsSettingsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::HuggingFace.PutDatasetsSettingsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// Update repo settings<br/>
        /// Update the settings of a repo
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="private"></param>
        /// <param name="visibility">
        /// Repository visibility. `protected` is only supported for Spaces.
        /// </param>
        /// <param name="discussionsDisabled"></param>
        /// <param name="discussionsSorting"></param>
        /// <param name="gated"></param>
        /// <param name="gatedNotificationsEmail"></param>
        /// <param name="gatedNotificationsMode"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.PutDatasetsSettingsResponse> PutDatasetsByNamespaceByRepoSettingsAsync(
            string @namespace,
            string repo,
            bool? @private = default,
            global::HuggingFace.PutDatasetsSettingsRequestVisibility? visibility = default,
            bool? discussionsDisabled = default,
            global::HuggingFace.PutDatasetsSettingsRequestDiscussionsSorting? discussionsSorting = default,
            global::HuggingFace.AnyOf<string, global::HuggingFace.PutDatasetsSettingsRequestGatedEnum2?>? gated = default,
            string? gatedNotificationsEmail = default,
            global::HuggingFace.PutDatasetsSettingsRequestGatedNotificationsMode? gatedNotificationsMode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.PutDatasetsSettingsRequest
            {
                Private = @private,
                Visibility = visibility,
                DiscussionsDisabled = discussionsDisabled,
                DiscussionsSorting = discussionsSorting,
                Gated = gated,
                GatedNotificationsEmail = gatedNotificationsEmail,
                GatedNotificationsMode = gatedNotificationsMode,
            };

            return await PutDatasetsByNamespaceByRepoSettingsAsync(
                @namespace: @namespace,
                repo: repo,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}