
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestItemData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gallery")]
        public global::System.Collections.Generic.IList<string>? Gallery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestItemData" /> class.
        /// </summary>
        /// <param name="gallery"></param>
        /// <param name="note"></param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestItemData(
            global::System.Collections.Generic.IList<string>? gallery,
            string? note,
            int? position)
        {
            this.Gallery = gallery;
            this.Note = note;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestItemData" /> class.
        /// </summary>
        public RequestItemData()
        {
        }
    }
}