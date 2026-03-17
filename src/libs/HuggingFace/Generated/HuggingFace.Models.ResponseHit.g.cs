
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseHit
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
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy_lvl0")]
        public string? HierarchyLvl0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy_lvl1")]
        public string? HierarchyLvl1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy_lvl2")]
        public string? HierarchyLvl2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy_lvl3")]
        public string? HierarchyLvl3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy_lvl4")]
        public string? HierarchyLvl4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy_lvl5")]
        public string? HierarchyLvl5 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy_lvl6")]
        public string? HierarchyLvl6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        public string? Anchor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_formatted")]
        public global::HuggingFace.ResponseHitFormatted? Formatted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHit" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="hierarchyLvl0"></param>
        /// <param name="hierarchyLvl1"></param>
        /// <param name="hierarchyLvl2"></param>
        /// <param name="hierarchyLvl3"></param>
        /// <param name="hierarchyLvl4"></param>
        /// <param name="hierarchyLvl5"></param>
        /// <param name="hierarchyLvl6"></param>
        /// <param name="content"></param>
        /// <param name="anchor"></param>
        /// <param name="formatted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseHit(
            string url,
            string? hierarchyLvl0,
            string? hierarchyLvl1,
            string? hierarchyLvl2,
            string? hierarchyLvl3,
            string? hierarchyLvl4,
            string? hierarchyLvl5,
            string? hierarchyLvl6,
            string? content,
            string? anchor,
            global::HuggingFace.ResponseHitFormatted? formatted)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.HierarchyLvl0 = hierarchyLvl0;
            this.HierarchyLvl1 = hierarchyLvl1;
            this.HierarchyLvl2 = hierarchyLvl2;
            this.HierarchyLvl3 = hierarchyLvl3;
            this.HierarchyLvl4 = hierarchyLvl4;
            this.HierarchyLvl5 = hierarchyLvl5;
            this.HierarchyLvl6 = hierarchyLvl6;
            this.Content = content;
            this.Anchor = anchor;
            this.Formatted = formatted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseHit" /> class.
        /// </summary>
        public ResponseHit()
        {
        }
    }
}