
#nullable enable

namespace HuggingFace
{
    public partial class JobsClient
    {
        partial void PrepareCreateJobsByNamespaceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace,
            global::HuggingFace.CreateJobsRequest request);
        partial void PrepareCreateJobsByNamespaceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace,
            global::HuggingFace.CreateJobsRequest request);
        partial void ProcessCreateJobsByNamespaceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateJobsByNamespaceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start a job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.CreateJobsResponse> CreateJobsByNamespaceAsync(
            string @namespace,

            global::HuggingFace.CreateJobsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateJobsByNamespaceArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace,
                request: request);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/jobs/{@namespace}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateJobsByNamespaceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                @namespace: @namespace,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateJobsByNamespaceResponse(
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
                ProcessCreateJobsByNamespaceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.CreateJobsResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::HuggingFace.CreateJobsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Start a job
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="spaceId"></param>
        /// <param name="dockerImage"></param>
        /// <param name="arguments"></param>
        /// <param name="command"></param>
        /// <param name="environment">
        /// Default Value: {}
        /// </param>
        /// <param name="secrets"></param>
        /// <param name="flavor"></param>
        /// <param name="arch"></param>
        /// <param name="timeoutSeconds">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="attempts">
        /// Max number of attempts to make. For example, if you set this to 3, the job will be retried up to 2 times if it fails.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="labels">
        /// Labels for the job as key-value pairs. Both keys and values must be max 100 characters and contain only alphanumeric characters, dots, dashes, and underscores.
        /// </param>
        /// <param name="volumes">
        /// HuggingFace Buckets or Repos to mount as volumes in the job container.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.CreateJobsResponse> CreateJobsByNamespaceAsync(
            string @namespace,
            global::HuggingFace.CreateJobsRequestFlavor flavor,
            string? spaceId = default,
            string? dockerImage = default,
            global::System.Collections.Generic.IList<string>? arguments = default,
            global::System.Collections.Generic.IList<string>? command = default,
            global::System.Collections.Generic.Dictionary<string, string>? environment = default,
            global::System.Collections.Generic.Dictionary<string, string>? secrets = default,
            global::HuggingFace.CreateJobsRequestArch? arch = default,
            int? timeoutSeconds = default,
            int? attempts = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateJobsRequestVolume>? volumes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.CreateJobsRequest
            {
                SpaceId = spaceId,
                DockerImage = dockerImage,
                Arguments = arguments,
                Command = command,
                Environment = environment,
                Secrets = secrets,
                Flavor = flavor,
                Arch = arch,
                TimeoutSeconds = timeoutSeconds,
                Attempts = attempts,
                Labels = labels,
                Volumes = volumes,
            };

            return await CreateJobsByNamespaceAsync(
                @namespace: @namespace,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}