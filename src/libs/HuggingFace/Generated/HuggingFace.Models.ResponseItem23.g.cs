
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseItem23
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
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public global::HuggingFace.ResponseItemNote2? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gallery")]
        public global::System.Collections.Generic.IList<string>? Gallery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem23" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="note"></param>
        /// <param name="gallery"></param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseItem23(
            string id,
            double position,
            global::HuggingFace.ResponseItemNote2? note,
            global::System.Collections.Generic.IList<string>? gallery)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Position = position;
            this.Note = note;
            this.Gallery = gallery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseItem23" /> class.
        /// </summary>
        public ResponseItem23()
        {
        }
    }
}