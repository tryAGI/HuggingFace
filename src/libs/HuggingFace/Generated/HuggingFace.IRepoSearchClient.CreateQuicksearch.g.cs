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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response121> CreateQuicksearchAsync(

            global::HuggingFace.Request57 request,
            string? q = default,
            int? limit = default,
            global::HuggingFace.AnyOf<global::HuggingFace.Lang5?, string>? lang = default,
            global::HuggingFace.AnyOf<global::HuggingFace.Library5?, string>? library = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.TypeVariant1Item2>, global::System.Collections.Generic.IList<string>>? type = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.OrgsFilterVariant1Item2>, global::System.Collections.Generic.IList<string>>? orgsFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.ReposFilterVariant1Item2>, global::System.Collections.Generic.IList<string>>? reposFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.PipelinesVariant1Item2>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            string? @namespace = default,
            global::HuggingFace.AnyOf<bool?, object>? includeInvitees = default,
            string? repoName = default,
            global::HuggingFace.AnyOf<global::HuggingFace.RepoType23?, string>? repoType = default,
            string? discussionId = default,
            string? discussionCollectionName = default,
            global::System.Collections.Generic.IList<string>? spacesTags = default,
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
        /// <param name="requestQ"></param>
        /// <param name="requestLimit"></param>
        /// <param name="requestLang"></param>
        /// <param name="requestLibrary"></param>
        /// <param name="requestType"></param>
        /// <param name="requestOrgsFilter"></param>
        /// <param name="requestReposFilter"></param>
        /// <param name="requestPipelines">
        /// Comma-separated or array of pipeline types
        /// </param>
        /// <param name="requestExclude">
        /// Array of excluded resources: spaces/repo, models/repo, datasets/repo, papers/paperId, collections/collectionId, users/username, orgs/orgName, buckets/bucketName<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestNamespace">
        /// Namespace to filter by
        /// </param>
        /// <param name="requestIncludeInvitees">
        /// Default Value: false
        /// </param>
        /// <param name="requestRepoName"></param>
        /// <param name="requestRepoType"></param>
        /// <param name="requestDiscussionId"></param>
        /// <param name="requestDiscussionCollectionName"></param>
        /// <param name="requestSpacesTags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::HuggingFace.Response121> CreateQuicksearchAsync(
            global::System.Collections.Generic.IList<string> requestExclude,
            string? q = default,
            int? limit = default,
            global::HuggingFace.AnyOf<global::HuggingFace.Lang5?, string>? lang = default,
            global::HuggingFace.AnyOf<global::HuggingFace.Library5?, string>? library = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.TypeVariant1Item2>, global::System.Collections.Generic.IList<string>>? type = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.OrgsFilterVariant1Item2>, global::System.Collections.Generic.IList<string>>? orgsFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.ReposFilterVariant1Item2>, global::System.Collections.Generic.IList<string>>? reposFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.PipelinesVariant1Item2>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines = default,
            global::System.Collections.Generic.IList<string>? exclude = default,
            string? @namespace = default,
            global::HuggingFace.AnyOf<bool?, object>? includeInvitees = default,
            string? repoName = default,
            global::HuggingFace.AnyOf<global::HuggingFace.RepoType23?, string>? repoType = default,
            string? discussionId = default,
            string? discussionCollectionName = default,
            global::System.Collections.Generic.IList<string>? spacesTags = default,
            string? requestQ = default,
            int? requestLimit = default,
            global::HuggingFace.AnyOf<global::HuggingFace.RequestLang?, string>? requestLang = default,
            global::HuggingFace.AnyOf<global::HuggingFace.RequestLibrary?, string>? requestLibrary = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? requestType = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? requestOrgsFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? requestReposFilter = default,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? requestPipelines = default,
            string? requestNamespace = default,
            global::HuggingFace.AnyOf<bool?, object>? requestIncludeInvitees = default,
            string? requestRepoName = default,
            global::HuggingFace.AnyOf<global::HuggingFace.RequestRepoType?, string>? requestRepoType = default,
            string? requestDiscussionId = default,
            string? requestDiscussionCollectionName = default,
            global::System.Collections.Generic.IList<string>? requestSpacesTags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}