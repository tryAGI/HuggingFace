
#nullable enable

namespace HuggingFace
{
    public partial class SpacesClient
    {
        partial void PrepareGetSpacesByNamespaceByRepoJwtArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace,
            ref string repo,
            object? write,
            ref global::System.DateTime? expiration,
            object? encrypted,
            object? inferenceApi,
            object? includeProStatus,
            object? billingDetails);
        partial void PrepareGetSpacesByNamespaceByRepoJwtRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace,
            string repo,
            object? write,
            global::System.DateTime? expiration,
            object? encrypted,
            object? inferenceApi,
            object? includeProStatus,
            object? billingDetails);
        partial void ProcessGetSpacesByNamespaceByRepoJwtResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSpacesByNamespaceByRepoJwtResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate JWT<br/>
        /// Generate a JWT token for accessing a repository. Supports optional write access for spaces in dev mode, custom expiration, and encryption.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="write"></param>
        /// <param name="expiration"></param>
        /// <param name="encrypted"></param>
        /// <param name="inferenceApi"></param>
        /// <param name="includeProStatus"></param>
        /// <param name="billingDetails"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.GetSpacesJwtResponse> GetSpacesByNamespaceByRepoJwtAsync(
            string @namespace,
            string repo,
            object? write = default,
            global::System.DateTime? expiration = default,
            object? encrypted = default,
            object? inferenceApi = default,
            object? includeProStatus = default,
            object? billingDetails = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSpacesByNamespaceByRepoJwtArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace,
                repo: ref repo,
                write: write,
                expiration: ref expiration,
                encrypted: encrypted,
                inferenceApi: inferenceApi,
                includeProStatus: includeProStatus,
                billingDetails: billingDetails);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/spaces/{@namespace}/{repo}/jwt",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("write", write?.ToString())
                .AddOptionalParameter("expiration", expiration?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("encrypted", encrypted?.ToString())
                .AddOptionalParameter("inference_api", inferenceApi?.ToString())
                .AddOptionalParameter("include_pro_status", includeProStatus?.ToString())
                .AddOptionalParameter("billing_details", billingDetails?.ToString()) 
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
            PrepareGetSpacesByNamespaceByRepoJwtRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                @namespace: @namespace,
                repo: repo,
                write: write,
                expiration: expiration,
                encrypted: encrypted,
                inferenceApi: inferenceApi,
                includeProStatus: includeProStatus,
                billingDetails: billingDetails);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSpacesByNamespaceByRepoJwtResponse(
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
                ProcessGetSpacesByNamespaceByRepoJwtResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.GetSpacesJwtResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::HuggingFace.GetSpacesJwtResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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