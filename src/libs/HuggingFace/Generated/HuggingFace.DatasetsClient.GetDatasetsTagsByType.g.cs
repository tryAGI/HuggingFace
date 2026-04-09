
#nullable enable

namespace HuggingFace
{
    public partial class DatasetsClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_GetDatasetsTagsByTypeSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_GetDatasetsTagsByTypeSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_GetDatasetsTagsByTypeSecurityRequirement0,
            };
        partial void PrepareGetDatasetsTagsByTypeArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::HuggingFace.GetDatasetsTagsByTypeType? type);
        partial void PrepareGetDatasetsTagsByTypeRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.GetDatasetsTagsByTypeType? type);
        partial void ProcessGetDatasetsTagsByTypeResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDatasetsTagsByTypeResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get dataset tags<br/>
        /// Get all possible tags used for datasets, grouped by tag type. Optionally restrict to only one tag type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>>> GetDatasetsTagsByTypeAsync(
            global::HuggingFace.GetDatasetsTagsByTypeType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDatasetsTagsByTypeArguments(
                httpClient: HttpClient,
                type: ref type);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetDatasetsTagsByTypeSecurityRequirements,
                operationName: "GetDatasetsTagsByTypeAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/api/datasets-tags-by-type",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("type", type?.ToValueString()) 
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
            PrepareGetDatasetsTagsByTypeRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                type: type);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetDatasetsTagsByTypeResponse(
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
                ProcessGetDatasetsTagsByTypeResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>>), JsonSerializerContext) ??
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
                        (global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::HuggingFace.GetDatasetsTagsByTypeResponseItem>>), JsonSerializerContext).ConfigureAwait(false) ??
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