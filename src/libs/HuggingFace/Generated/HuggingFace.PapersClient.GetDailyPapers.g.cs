
#nullable enable

namespace HuggingFace
{
    public partial class PapersClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_GetDailyPapersSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_GetDailyPapersSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_GetDailyPapersSecurityRequirement0,
            };
        partial void PrepareGetDailyPapersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? p,
            ref int? limit,
            ref global::System.DateTime? date,
            ref string? week,
            ref string? month,
            ref string? submitter,
            ref global::HuggingFace.GetDailyPapersSort? sort);
        partial void PrepareGetDailyPapersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? p,
            int? limit,
            global::System.DateTime? date,
            string? week,
            string? month,
            string? submitter,
            global::HuggingFace.GetDailyPapersSort? sort);
        partial void ProcessGetDailyPapersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDailyPapersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Daily Papers
        /// </summary>
        /// <param name="p">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="date"></param>
        /// <param name="week"></param>
        /// <param name="month"></param>
        /// <param name="submitter"></param>
        /// <param name="sort">
        /// Default Value: publishedAt
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItem>> GetDailyPapersAsync(
            int? p = default,
            int? limit = default,
            global::System.DateTime? date = default,
            string? week = default,
            string? month = default,
            string? submitter = default,
            global::HuggingFace.GetDailyPapersSort? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDailyPapersArguments(
                httpClient: HttpClient,
                p: ref p,
                limit: ref limit,
                date: ref date,
                week: ref week,
                month: ref month,
                submitter: ref submitter,
                sort: ref sort);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetDailyPapersSecurityRequirements,
                operationName: "GetDailyPapersAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/api/daily_papers",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("p", p?.ToString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("date", date?.ToString("yyyy-MM-dd"))
                .AddOptionalParameter("week", week)
                .AddOptionalParameter("month", month)
                .AddOptionalParameter("submitter", submitter)
                .AddOptionalParameter("sort", sort?.ToValueString()) 
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
            PrepareGetDailyPapersRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                p: p,
                limit: limit,
                date: date,
                week: week,
                month: month,
                submitter: submitter,
                sort: sort);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetDailyPapersResponse(
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
                ProcessGetDailyPapersResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItem>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItem>), JsonSerializerContext) ??
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
                        (global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItem>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::HuggingFace.GetDailyPapersResponseItem>), JsonSerializerContext).ConfigureAwait(false) ??
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