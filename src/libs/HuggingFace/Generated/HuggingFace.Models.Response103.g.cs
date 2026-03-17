
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response103
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
        [global::System.Text.Json.Serialization.JsonPropertyName("repoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("views")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseView2> Views { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sql")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sql { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rating")]
        public double? Rating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("justification")]
        public string? Justification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response103" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="repoId"></param>
        /// <param name="views"></param>
        /// <param name="sql"></param>
        /// <param name="title"></param>
        /// <param name="userId"></param>
        /// <param name="createdAt"></param>
        /// <param name="slug"></param>
        /// <param name="private"></param>
        /// <param name="rating"></param>
        /// <param name="justification"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response103(
            string id,
            string repoId,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseView2> views,
            string sql,
            string title,
            string userId,
            global::System.DateTime createdAt,
            string slug,
            bool? @private,
            double? rating,
            string? justification)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RepoId = repoId ?? throw new global::System.ArgumentNullException(nameof(repoId));
            this.Views = views ?? throw new global::System.ArgumentNullException(nameof(views));
            this.Sql = sql ?? throw new global::System.ArgumentNullException(nameof(sql));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreatedAt = createdAt;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Private = @private;
            this.Rating = rating;
            this.Justification = justification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response103" /> class.
        /// </summary>
        public Response103()
        {
        }
    }
}