
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response23
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseSchema6> Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalResults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsPerPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ItemsPerPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startIndex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseResource2> Resources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response23" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="totalResults"></param>
        /// <param name="itemsPerPage"></param>
        /// <param name="startIndex"></param>
        /// <param name="resources"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response23(
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseSchema6> schemas,
            int totalResults,
            int itemsPerPage,
            int startIndex,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseResource2> resources)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.TotalResults = totalResults;
            this.ItemsPerPage = itemsPerPage;
            this.StartIndex = startIndex;
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response23" /> class.
        /// </summary>
        public Response23()
        {
        }
    }
}