
#nullable enable

namespace HuggingFace
{
    public partial class RepoSearchClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_GetQuicksearchSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_GetQuicksearchSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_GetQuicksearchSecurityRequirement0,
            };
        partial void PrepareGetQuicksearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? q,
            ref int? limit,
            ref global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLang2?, string>? lang,
            ref global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLibrary2?, string>? library,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? type,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? orgsFilter,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? reposFilter,
            ref global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines,
            global::System.Collections.Generic.IList<string>? exclude,
            ref string? @namespace,
            ref global::HuggingFace.AnyOf<bool?, object>? includeInvitees,
            ref string? repoName,
            ref global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchRepoType2?, string>? repoType,
            ref string? discussionId,
            ref string? discussionCollectionName,
            global::System.Collections.Generic.IList<string>? spacesTags);
        partial void PrepareGetQuicksearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? q,
            int? limit,
            global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLang2?, string>? lang,
            global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLibrary2?, string>? library,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? type,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? orgsFilter,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? reposFilter,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines,
            global::System.Collections.Generic.IList<string>? exclude,
            string? @namespace,
            global::HuggingFace.AnyOf<bool?, object>? includeInvitees,
            string? repoName,
            global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchRepoType2?, string>? repoType,
            string? discussionId,
            string? discussionCollectionName,
            global::System.Collections.Generic.IList<string>? spacesTags);
        partial void ProcessGetQuicksearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetQuicksearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Quick search<br/>
        /// Quick search for models, datasets, spaces, orgs, users, papers, collections, and buckets
        /// </summary>
        /// <param name="q"></param>
        /// <param name="limit"></param>
        /// <param name="lang"></param>
        /// <param name="library"></param>
        /// <param name="type"></param>
        /// <param name="orgsFilter"></param>
        /// <param name="reposFilter"></param>
        /// <param name="pipelines">
        /// Comma-separated or array of pipeline types
        /// </param>
        /// <param name="exclude">
        /// Array of excluded resources: spaces/repo, models/repo, datasets/repo, papers/paperId, collections/collectionId, users/username, orgs/orgName, buckets/bucketName<br/>
        /// Default Value: []
        /// </param>
        /// <param name="namespace">
        /// Namespace to filter by
        /// </param>
        /// <param name="includeInvitees">
        /// Default Value: false
        /// </param>
        /// <param name="repoName"></param>
        /// <param name="repoType"></param>
        /// <param name="discussionId"></param>
        /// <param name="discussionCollectionName"></param>
        /// <param name="spacesTags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.GetQuicksearchResponse> GetQuicksearchAsync(
            string? q = default,
            int? limit = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLang2?, string>? lang = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchLibrary2?, string>? library = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? type = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? orgsFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? reposFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.GetQuicksearchPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            string? @namespace = default,
            global::HuggingFace.AnyOf<bool?, object>? includeInvitees = default,
            string? repoName = default,
            global::HuggingFace.AnyOf<global::HuggingFace.GetQuicksearchRepoType2?, string>? repoType = default,
            string? discussionId = default,
            string? discussionCollectionName = default,
            global::System.Collections.Generic.IList<string>? spacesTags = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetQuicksearchArguments(
                httpClient: HttpClient,
                q: ref q,
                limit: ref limit,
                lang: ref lang,
                library: ref library,
                type: ref type,
                orgsFilter: ref orgsFilter,
                reposFilter: ref reposFilter,
                pipelines: ref pipelines,
                exclude: exclude,
                @namespace: ref @namespace,
                includeInvitees: ref includeInvitees,
                repoName: ref repoName,
                repoType: ref repoType,
                discussionId: ref discussionId,
                discussionCollectionName: ref discussionCollectionName,
                spacesTags: spacesTags);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetQuicksearchSecurityRequirements,
                operationName: "GetQuicksearchAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/api/quicksearch",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("q", q)
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("lang", lang?.ToString())
                .AddOptionalParameter("library", library?.ToString())
                .AddOptionalParameter("type", type?.ToString())
                .AddOptionalParameter("orgsFilter", orgsFilter?.ToString())
                .AddOptionalParameter("reposFilter", reposFilter?.ToString())
                .AddOptionalParameter("pipelines", pipelines?.ToString())
                .AddOptionalParameter("exclude", exclude, delimiter: ",", explode: true)
                .AddOptionalParameter("namespace", @namespace)
                .AddOptionalParameter("includeInvitees", includeInvitees?.ToString())
                .AddOptionalParameter("repoName", repoName)
                .AddOptionalParameter("repoType", repoType?.ToString())
                .AddOptionalParameter("discussionId", discussionId)
                .AddOptionalParameter("discussionCollectionName", discussionCollectionName)
                .AddOptionalParameter("spacesTags", spacesTags, delimiter: ",", explode: true) 
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
            PrepareGetQuicksearchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                q: q,
                limit: limit,
                lang: lang,
                library: library,
                type: type,
                orgsFilter: orgsFilter,
                reposFilter: reposFilter,
                pipelines: pipelines,
                exclude: exclude,
                @namespace: @namespace,
                includeInvitees: includeInvitees,
                repoName: repoName,
                repoType: repoType,
                discussionId: discussionId,
                discussionCollectionName: discussionCollectionName,
                spacesTags: spacesTags);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetQuicksearchResponse(
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
                ProcessGetQuicksearchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.GetQuicksearchResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::HuggingFace.GetQuicksearchResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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