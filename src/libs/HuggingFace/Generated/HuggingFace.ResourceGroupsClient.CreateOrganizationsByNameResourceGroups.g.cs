
#nullable enable

namespace HuggingFace
{
    public partial class ResourceGroupsClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_CreateOrganizationsByNameResourceGroupsSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_CreateOrganizationsByNameResourceGroupsSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_CreateOrganizationsByNameResourceGroupsSecurityRequirement0,
            };
        partial void PrepareCreateOrganizationsByNameResourceGroupsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string name,
            global::HuggingFace.CreateOrganizationsResourceGroupsRequest request);
        partial void PrepareCreateOrganizationsByNameResourceGroupsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string name,
            global::HuggingFace.CreateOrganizationsResourceGroupsRequest request);
        partial void ProcessCreateOrganizationsByNameResourceGroupsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateOrganizationsByNameResourceGroupsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a resource group<br/>
        /// Create a new resource group in the organization.<br/>
        /// Requires the org to be Enterprise
        /// </summary>
        /// <param name="name"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsResponse> CreateOrganizationsByNameResourceGroupsAsync(
            string name,

            global::HuggingFace.CreateOrganizationsResourceGroupsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateOrganizationsByNameResourceGroupsArguments(
                httpClient: HttpClient,
                name: ref name,
                request: request);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateOrganizationsByNameResourceGroupsSecurityRequirements,
                operationName: "CreateOrganizationsByNameResourceGroupsAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/organizations/{name}/resource-groups",
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
            PrepareCreateOrganizationsByNameResourceGroupsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateOrganizationsByNameResourceGroupsResponse(
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
                ProcessCreateOrganizationsByNameResourceGroupsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.CreateOrganizationsResourceGroupsResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::HuggingFace.CreateOrganizationsResourceGroupsResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create a resource group<br/>
        /// Create a new resource group in the organization.<br/>
        /// Requires the org to be Enterprise
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestName"></param>
        /// <param name="description"></param>
        /// <param name="users">
        /// Default Value: []
        /// </param>
        /// <param name="repos">
        /// Default Value: []
        /// </param>
        /// <param name="autoJoin"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.CreateOrganizationsResourceGroupsResponse> CreateOrganizationsByNameResourceGroupsAsync(
            string name,
            string requestName,
            string? description = default,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOrganizationsResourceGroupsRequestUser>? users = default,
            global::System.Collections.Generic.IList<global::HuggingFace.RepoId>? repos = default,
            global::HuggingFace.AnyOf<global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant1, global::HuggingFace.CreateOrganizationsResourceGroupsRequestAutoJoinVariant2>? autoJoin = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.CreateOrganizationsResourceGroupsRequest
            {
                Name = requestName,
                Description = description,
                Users = users,
                Repos = repos,
                AutoJoin = autoJoin,
            };

            return await CreateOrganizationsByNameResourceGroupsAsync(
                name: name,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}