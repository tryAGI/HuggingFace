
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request45
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        public string? Q { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.RequestLang?, string>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.RequestLang?, string>? Lang { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.RequestLibrary?, string>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.RequestLibrary?, string>? Library { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.RequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>))]
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgsFilter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.RequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>))]
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? OrgsFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reposFilter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.RequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>))]
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? ReposFilter { get; set; }

        /// <summary>
        /// Comma-separated or array of pipeline types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelines")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::HuggingFace.RequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>))]
        public global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? Pipelines { get; set; }

        /// <summary>
        /// Array of excluded resources: spaces/repo, models/repo, datasets/repo, papers/paperId, collections/collectionId, users/username, orgs/orgName, buckets/bucketName<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Exclude { get; set; }

        /// <summary>
        /// Namespace to filter by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeInvitees")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, object>))]
        public global::HuggingFace.AnyOf<bool?, object>? IncludeInvitees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoName")]
        public string? RepoName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repoType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.RequestRepoType?, string>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.RequestRepoType?, string>? RepoType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionId")]
        public string? DiscussionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussionCollectionName")]
        public string? DiscussionCollectionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spacesTags")]
        public global::System.Collections.Generic.IList<string>? SpacesTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request45" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request45(
            global::System.Collections.Generic.IList<string> exclude,
            string? q,
            int? limit,
            global::HuggingFace.AnyOf<global::HuggingFace.RequestLang?, string>? lang,
            global::HuggingFace.AnyOf<global::HuggingFace.RequestLibrary?, string>? library,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestTypeVariant1Item>, global::System.Collections.Generic.IList<string>>? type,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestOrgsFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? orgsFilter,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestReposFilterVariant1Item>, global::System.Collections.Generic.IList<string>>? reposFilter,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<global::HuggingFace.RequestPipelinesVariant1Item>, global::HuggingFace.AnyOf<string, global::System.Collections.Generic.IList<string>>?>? pipelines,
            string? @namespace,
            global::HuggingFace.AnyOf<bool?, object>? includeInvitees,
            string? repoName,
            global::HuggingFace.AnyOf<global::HuggingFace.RequestRepoType?, string>? repoType,
            string? discussionId,
            string? discussionCollectionName,
            global::System.Collections.Generic.IList<string>? spacesTags)
        {
            this.Exclude = exclude ?? throw new global::System.ArgumentNullException(nameof(exclude));
            this.Q = q;
            this.Limit = limit;
            this.Lang = lang;
            this.Library = library;
            this.Type = type;
            this.OrgsFilter = orgsFilter;
            this.ReposFilter = reposFilter;
            this.Pipelines = pipelines;
            this.Namespace = @namespace;
            this.IncludeInvitees = includeInvitees;
            this.RepoName = repoName;
            this.RepoType = repoType;
            this.DiscussionId = discussionId;
            this.DiscussionCollectionName = discussionCollectionName;
            this.SpacesTags = spacesTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request45" /> class.
        /// </summary>
        public Request45()
        {
        }
    }
}