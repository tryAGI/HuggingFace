
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetDiscussionsResponseVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diffUrl")]
        public string? DiffUrl { get; set; }

        /// <summary>
        /// A hex string of 24 characters representing an ObjectId.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2>))]
        public global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2>? Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public global::HuggingFace.GetDiscussionsResponseVariant1Org? Org { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDiscussionsResponseVariant1StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDiscussionsResponseVariant1Status Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9>> Events { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDiscussionsResponseVariant1CollectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetDiscussionsResponseVariant1Collection Collection { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>false</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPullRequest")]
        public bool IsPullRequest { get; set; } = false;

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
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// A hex string of 24 characters representing an ObjectId.
        /// </param>
        /// <param name="title"></param>
        /// <param name="status"></param>
        /// <param name="events"></param>
        /// <param name="pinned"></param>
        /// <param name="locked"></param>
        /// <param name="collection"></param>
        /// <param name="isReport"></param>
        /// <param name="diffUrl"></param>
        /// <param name="num"></param>
        /// <param name="author"></param>
        /// <param name="org"></param>
        /// <param name="repo"></param>
        /// <param name="createdAt"></param>
        /// <param name="isPullRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponseVariant1(
            string id,
            string title,
            global::HuggingFace.GetDiscussionsResponseVariant1Status status,
            global::System.Collections.Generic.IList<global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant1EventVariant1, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant2, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant3, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant4, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant5, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant6, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant7, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant8, global::HuggingFace.GetDiscussionsResponseVariant1EventVariant9>> events,
            bool pinned,
            bool locked,
            global::HuggingFace.GetDiscussionsResponseVariant1Collection collection,
            bool isReport,
            string? diffUrl,
            double? num,
            global::HuggingFace.OneOf<global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant1, global::HuggingFace.GetDiscussionsResponseVariant1AuthorVariant2>? author,
            global::HuggingFace.GetDiscussionsResponseVariant1Org? org,
            global::HuggingFace.RepoId? repo,
            global::System.DateTime? createdAt,
            bool isPullRequest = false)
        {
            this.DiffUrl = diffUrl;
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
            this.IsReport = isReport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant1" /> class.
        /// </summary>
        public GetDiscussionsResponseVariant1()
        {
        }

    }
}