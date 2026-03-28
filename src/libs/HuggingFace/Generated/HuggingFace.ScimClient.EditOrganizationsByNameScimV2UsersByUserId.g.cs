
#nullable enable

namespace HuggingFace
{
    public partial class ScimClient
    {
        partial void PrepareEditOrganizationsByNameScimV2UsersByUserIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string name,
            ref string userId,
            global::HuggingFace.PatchOrganizationsScimV2UsersRequest request);
        partial void PrepareEditOrganizationsByNameScimV2UsersByUserIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string name,
            string userId,
            global::HuggingFace.PatchOrganizationsScimV2UsersRequest request);
        partial void ProcessEditOrganizationsByNameScimV2UsersByUserIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditOrganizationsByNameScimV2UsersByUserIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update SCIM user<br/>
        /// Update an attribute of a SCIM user. Modify individual attributes using Operations format. Just provide the changes you want to make using add, remove (only `externalId` is supported), or replace operations.<br/>
        ///  If you set `active` to `false`, the user will be deprovisioned from the organization. <br/>
        /// Complicated SCIM `path` values are not supported like `emails[type eq 'work'].value`.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsScimV2UsersResponse> EditOrganizationsByNameScimV2UsersByUserIdAsync(
            string name,
            string userId,

            global::HuggingFace.PatchOrganizationsScimV2UsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditOrganizationsByNameScimV2UsersByUserIdArguments(
                httpClient: HttpClient,
                name: ref name,
                userId: ref userId,
                request: request);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/organizations/{name}/scim/v2/Users/{userId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareEditOrganizationsByNameScimV2UsersByUserIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                name: name,
                userId: userId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEditOrganizationsByNameScimV2UsersByUserIdResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // User already exists
            if ((int)__response.StatusCode == 409)
            {
                string? __content_409 = null;
                global::System.Exception? __exception_409 = null;
                string? __value_409 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_409 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_409, typeof(string), JsonSerializerContext);
                    }
                    else
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_409 = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content_409, typeof(string), JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_409 = __ex;
                }

                throw new global::HuggingFace.ApiException<string>(
                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_409,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_409,
                    ResponseObject = __value_409,
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
                ProcessEditOrganizationsByNameScimV2UsersByUserIdResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.PatchOrganizationsScimV2UsersResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::HuggingFace.PatchOrganizationsScimV2UsersResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Update SCIM user<br/>
        /// Update an attribute of a SCIM user. Modify individual attributes using Operations format. Just provide the changes you want to make using add, remove (only `externalId` is supported), or replace operations.<br/>
        ///  If you set `active` to `false`, the user will be deprovisioned from the organization. <br/>
        /// Complicated SCIM `path` values are not supported like `emails[type eq 'work'].value`.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="schemas"></param>
        /// <param name="operations"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.PatchOrganizationsScimV2UsersResponse> EditOrganizationsByNameScimV2UsersByUserIdAsync(
            string name,
            string userId,
            global::System.Collections.Generic.IList<string> schemas,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperation> operations,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.PatchOrganizationsScimV2UsersRequest
            {
                Schemas = schemas,
                Operations = operations,
            };

            return await EditOrganizationsByNameScimV2UsersByUserIdAsync(
                name: name,
                userId: userId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}