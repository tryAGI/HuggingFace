
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseVariant15
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.ResponseVariant1AuthorVariant1, global::HuggingFace.ResponseVariant1AuthorVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.ResponseVariant1AuthorVariant1, global::HuggingFace.ResponseVariant1AuthorVariant2>? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public global::HuggingFace.ResponseVariant1Org? Org { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseVariant1StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseVariant1Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.ResponseVariant1EventVariant1, global::HuggingFace.ResponseVariant1EventVariant2, global::HuggingFace.ResponseVariant1EventVariant3, global::HuggingFace.ResponseVariant1EventVariant4, global::HuggingFace.ResponseVariant1EventVariant5, global::HuggingFace.ResponseVariant1EventVariant6, global::HuggingFace.ResponseVariant1EventVariant7, global::HuggingFace.ResponseVariant1EventVariant8>> Events { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseVariant1CollectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseVariant1Collection Collection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"False"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPullRequest")]
        public string IsPullRequest { get; set; } = "False";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isReport")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsReport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant15" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="num"></param>
        /// <param name="author"></param>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="title"></param>
        /// <param name="createdAt"></param>
        /// <param name="status"></param>
        /// <param name="events"></param>
        /// <param name="pinned"></param>
        /// <param name="locked"></param>
        /// <param name="collection"></param>
        /// <param name="isPullRequest"></param>
        /// <param name="isReport"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseVariant15(
            string id,
            string title,
            global::HuggingFace.ResponseVariant1Status status,
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.ResponseVariant1EventVariant1, global::HuggingFace.ResponseVariant1EventVariant2, global::HuggingFace.ResponseVariant1EventVariant3, global::HuggingFace.ResponseVariant1EventVariant4, global::HuggingFace.ResponseVariant1EventVariant5, global::HuggingFace.ResponseVariant1EventVariant6, global::HuggingFace.ResponseVariant1EventVariant7, global::HuggingFace.ResponseVariant1EventVariant8>> events,
            bool pinned,
            bool locked,
            global::HuggingFace.ResponseVariant1Collection collection,
            bool isReport,
            double? num,
            global::HuggingFace.AnyOf<global::HuggingFace.ResponseVariant1AuthorVariant1, global::HuggingFace.ResponseVariant1AuthorVariant2>? author,
            global::HuggingFace.ResponseVariant1Org? org,
            global::HuggingFace.RepoId? repo,
            global::System.DateTime? createdAt,
            string isPullRequest = "False")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Status = status;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.Pinned = pinned;
            this.Locked = locked;
            this.Collection = collection;
            this.IsReport = isReport;
            this.Num = num;
            this.Author = author;
            this.Org = org;
            this.Repo = repo;
            this.CreatedAt = createdAt;
            this.IsPullRequest = isPullRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant15" /> class.
        /// </summary>
        public ResponseVariant15()
        {
        }
    }
}