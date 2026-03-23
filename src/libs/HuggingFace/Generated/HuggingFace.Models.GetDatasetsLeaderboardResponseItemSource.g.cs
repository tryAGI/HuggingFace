
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDatasetsLeaderboardResponseItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isExternal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsExternal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant1, global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2>))]
        public global::HuggingFace.AnyOf<global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant1, global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2>? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsLeaderboardResponseItemSource" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="isExternal"></param>
        /// <param name="author"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDatasetsLeaderboardResponseItemSource(
            string url,
            bool isExternal,
            string? name,
            global::HuggingFace.AnyOf<global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant1, global::HuggingFace.GetDatasetsLeaderboardResponseItemSourceAuthorVariant2>? author)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.IsExternal = isExternal;
            this.Name = name;
            this.Author = author;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetsLeaderboardResponseItemSource" /> class.
        /// </summary>
        public GetDatasetsLeaderboardResponseItemSource()
        {
        }
    }
}