
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem21
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.ResponseItemAuthorVariant1, global::HuggingFace.ResponseItemAuthorVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<global::HuggingFace.ResponseItemAuthorVariant1, global::HuggingFace.ResponseItemAuthorVariant2> Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::HuggingFace.ResponseItemSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pullRequest")]
        public double? PullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem21" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="modelId"></param>
        /// <param name="author"></param>
        /// <param name="value"></param>
        /// <param name="verified"></param>
        /// <param name="source"></param>
        /// <param name="pullRequest"></param>
        /// <param name="filename"></param>
        /// <param name="notes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem21(
            double rank,
            string modelId,
            global::HuggingFace.AnyOf<global::HuggingFace.ResponseItemAuthorVariant1, global::HuggingFace.ResponseItemAuthorVariant2> author,
            double value,
            string filename,
            bool? verified,
            global::HuggingFace.ResponseItemSource? source,
            double? pullRequest,
            string? notes)
        {
            this.Rank = rank;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Author = author;
            this.Value = value;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Verified = verified;
            this.Source = source;
            this.PullRequest = pullRequest;
            this.Notes = notes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem21" /> class.
        /// </summary>
        public ResponseItem21()
        {
        }
    }
}