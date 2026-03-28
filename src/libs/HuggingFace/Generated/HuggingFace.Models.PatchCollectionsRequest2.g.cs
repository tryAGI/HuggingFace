
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchCollectionsRequestTheme2JsonConverter))]
        public global::HuggingFace.PatchCollectionsRequestTheme2? Theme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gating")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.PatchCollectionsRequestGatingVariant22, global::HuggingFace.PatchCollectionsRequestGatingVariant32>))]
        public global::HuggingFace.AnyOf<string, global::HuggingFace.PatchCollectionsRequestGatingVariant22, global::HuggingFace.PatchCollectionsRequestGatingVariant32>? Gating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsRequest2" /> class.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="private"></param>
        /// <param name="theme"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="gating"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsRequest2(
            int? position,
            bool? @private,
            global::HuggingFace.PatchCollectionsRequestTheme2? theme,
            string? title,
            string? description,
            global::HuggingFace.AnyOf<string, global::HuggingFace.PatchCollectionsRequestGatingVariant22, global::HuggingFace.PatchCollectionsRequestGatingVariant32>? gating)
        {
            this.Position = position;
            this.Private = @private;
            this.Theme = theme;
            this.Title = title;
            this.Description = description;
            this.Gating = gating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsRequest2" /> class.
        /// </summary>
        public PatchCollectionsRequest2()
        {
        }
    }
}