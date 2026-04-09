
#nullable enable

namespace HuggingFace
{
    public partial class DiscussionsClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_DeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefSecurityRequirement0 =
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
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_DeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_DeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefSecurityRequirement0,
            };
        partial void PrepareDeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::HuggingFace.DeleteDiscussionsRefRepoType repoType,
            ref string @namespace,
            ref string repo,
            ref string num);
        partial void PrepareDeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.DeleteDiscussionsRefRepoType repoType,
            string @namespace,
            string repo,
            string num);
        partial void ProcessDeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete PR ref<br/>
        /// Deletes the git ref for a closed/merged pull request to free up storage. LFS files unique to this PR will be garbage collected. The PR page and diff will still be viewable using stored commit data.
        /// </summary>
        /// <param name="repoType"></param>
        /// <param name="namespace"></param>
        /// <param name="repo"></param>
        /// <param name="num"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task DeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefAsync(
            global::HuggingFace.DeleteDiscussionsRefRepoType repoType,
            string @namespace,
            string repo,
            string num,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefArguments(
                httpClient: HttpClient,
                repoType: ref repoType,
                @namespace: ref @namespace,
                repo: ref repo,
                num: ref num);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefSecurityRequirements,
                operationName: "DeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: $"/api/{repoType}/{@namespace}/{repo}/discussions/{num}/ref",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
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
            PrepareDeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                repoType: repoType,
                @namespace: @namespace,
                repo: repo,
                num: num);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDeleteByRepoTypeByNamespaceByRepoDiscussionsByNumRefResponse(
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