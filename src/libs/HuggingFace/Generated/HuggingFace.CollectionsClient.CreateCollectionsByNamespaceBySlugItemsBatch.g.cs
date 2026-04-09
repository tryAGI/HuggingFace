
#nullable enable

namespace HuggingFace
{
    public partial class CollectionsClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_CreateCollectionsByNamespaceBySlugItemsBatchSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_CreateCollectionsByNamespaceBySlugItemsBatchSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_CreateCollectionsByNamespaceBySlugItemsBatchSecurityRequirement0,
            };
        partial void PrepareCreateCollectionsByNamespaceBySlugItemsBatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace,
            ref string slug,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsBatchRequestItem2> request);
        partial void PrepareCreateCollectionsByNamespaceBySlugItemsBatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace,
            string slug,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsBatchRequestItem2> request);
        partial void ProcessCreateCollectionsByNamespaceBySlugItemsBatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Batch update items<br/>
        /// Batch update items in a collection
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CreateCollectionsByNamespaceBySlugItemsBatchAsync(
            string @namespace,
            string slug,

            global::System.Collections.Generic.IList<global::HuggingFace.CreateCollectionsItemsBatchRequestItem2> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateCollectionsByNamespaceBySlugItemsBatchArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace,
                slug: ref slug,
                request: request);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateCollectionsByNamespaceBySlugItemsBatchSecurityRequirements,
                operationName: "CreateCollectionsByNamespaceBySlugItemsBatchAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/collections/{@namespace}/{slug}/items/batch",
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
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateCollectionsByNamespaceBySlugItemsBatchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                @namespace: @namespace,
                slug: slug,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateCollectionsByNamespaceBySlugItemsBatchResponse(
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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