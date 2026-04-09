
#nullable enable

namespace HuggingFace
{
    public partial class AgenticProvisioningClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_CreateAgenticProvisioningResourcesSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_CreateAgenticProvisioningResourcesSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_CreateAgenticProvisioningResourcesSecurityRequirement0,
            };
        partial void PrepareCreateAgenticProvisioningResourcesArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3> request);
        partial void PrepareCreateAgenticProvisioningResourcesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3> request);
        partial void ProcessCreateAgenticProvisioningResourcesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAgenticProvisioningResourcesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Provision a resource
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant3>> CreateAgenticProvisioningResourcesAsync(

            global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateAgenticProvisioningResourcesArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAgenticProvisioningResourcesSecurityRequirements,
                operationName: "CreateAgenticProvisioningResourcesAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/api/agentic/provisioning/resources",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateAgenticProvisioningResourcesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateAgenticProvisioningResourcesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Resource provisioning error
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::HuggingFace.CreateAgenticProvisioningResourcesResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::HuggingFace.CreateAgenticProvisioningResourcesResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::HuggingFace.CreateAgenticProvisioningResourcesResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.CreateAgenticProvisioningResourcesResponse2>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessCreateAgenticProvisioningResourcesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant3>.FromJson(__content, JsonSerializerContext) ??
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
                        await global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant3>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Provision a resource
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant3>> CreateAgenticProvisioningResourcesAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.AnyOf<global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant1, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant2, global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant3>
            {
            };

            return await CreateAgenticProvisioningResourcesAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}