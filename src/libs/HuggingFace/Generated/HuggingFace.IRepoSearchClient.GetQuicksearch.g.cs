#nullable enable

namespace HuggingFace
{
    public partial interface IRepoSearchClient
    {
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.GetQuicksearchResponse> GetQuicksearchAsync(
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
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.AutoSDKHttpResponse<global::HuggingFace.GetQuicksearchResponse>> GetQuicksearchAsResponseAsync(
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
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}