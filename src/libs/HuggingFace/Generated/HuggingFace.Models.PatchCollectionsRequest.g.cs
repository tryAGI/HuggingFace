
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchCollectionsRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchCollectionsRequestThemeJsonConverter))]
        public global::HuggingFace.PatchCollectionsRequestTheme? Theme { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<string, global::HuggingFace.PatchCollectionsRequestGatingVariant2, global::HuggingFace.PatchCollectionsRequestGatingVariant3>))]
        public global::HuggingFace.AnyOf<string, global::HuggingFace.PatchCollectionsRequestGatingVariant2, global::HuggingFace.PatchCollectionsRequestGatingVariant3>? Gating { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsRequest" /> class.
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
        public PatchCollectionsRequest(
            int? position,
            bool? @private,
            global::HuggingFace.PatchCollectionsRequestTheme? theme,
            string? title,
            string? description,
            global::HuggingFace.AnyOf<string, global::HuggingFace.PatchCollectionsRequestGatingVariant2, global::HuggingFace.PatchCollectionsRequestGatingVariant3>? gating)
        {
            this.Position = position;
            this.Private = @private;
            this.Theme = theme;
            this.Title = title;
            this.Description = description;
            this.Gating = gating;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsRequest" /> class.
        /// </summary>
        public PatchCollectionsRequest()
        {
        }
    }
}