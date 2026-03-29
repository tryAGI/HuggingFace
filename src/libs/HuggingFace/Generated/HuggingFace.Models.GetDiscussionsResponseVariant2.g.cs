
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDiscussionsResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num")]
        public double? Num { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2>? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public global::HuggingFace.GetDiscussionsResponseVariant2Org? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        public global::HuggingFace.RepoId? Repo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDiscussionsResponseVariant2StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDiscussionsResponseVariant2Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8>> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Pinned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Locked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"discussions"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string Collection { get; set; } = "discussions";

        /// <summary>
        /// 
        /// </summary>
        /// <default>"True"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPullRequest")]
        public string IsPullRequest { get; set; } = "True";

        /// <summary>
        /// The list of files with conflicts. `true` means there are conflicts but we cannot list them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filesWithConflicts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string> FilesWithConflicts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDiscussionsResponseVariant2Changes Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="status"></param>
        /// <param name="events"></param>
        /// <param name="pinned"></param>
        /// <param name="locked"></param>
        /// <param name="filesWithConflicts">
        /// The list of files with conflicts. `true` means there are conflicts but we cannot list them.
        /// </param>
        /// <param name="changes"></param>
        /// <param name="num"></param>
        /// <param name="author"></param>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="createdAt"></param>
        /// <param name="collection"></param>
        /// <param name="isPullRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponseVariant2(
            string id,
            string title,
            global::HuggingFace.GetDiscussionsResponseVariant2Status status,
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.GetDiscussionsResponseVariant2EventVariant1, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant2, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant3, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant4, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant5, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant6, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant7, global::HuggingFace.GetDiscussionsResponseVariant2EventVariant8>> events,
            bool pinned,
            bool locked,
            global::HuggingFace.AnyOf<global::System.Collections.Generic.IList<string>, string> filesWithConflicts,
            global::HuggingFace.GetDiscussionsResponseVariant2Changes changes,
            double? num,
            global::HuggingFace.AnyOf<global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant2AuthorVariant2>? author,
            global::HuggingFace.GetDiscussionsResponseVariant2Org? org,
            global::HuggingFace.RepoId? repo,
            global::System.DateTime? createdAt,
            string collection = "discussions",
            string isPullRequest = "True")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Num = num;
            this.Author = author;
            this.Org = org;
            this.Repo = repo;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Pinned = pinned;
            this.Locked = locked;
            this.Collection = collection;
            this.IsPullRequest = isPullRequest;
            this.FilesWithConflicts = filesWithConflicts;
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2" /> class.
        /// </summary>
        public GetDiscussionsResponseVariant2()
        {
        }
    }
}