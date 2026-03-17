
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request55
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("views")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.RequestView> Views { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request55" /> class.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="title"></param>
        /// <param name="private"></param>
        /// <param name="views"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request55(
            string sql,
            string title,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestView> views,
            bool? @private)
        {
            this.Sql = sql ?? throw new global::System.ArgumentNullException(nameof(sql));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Views = views ?? throw new global::System.ArgumentNullException(nameof(views));
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request55" /> class.
        /// </summary>
        public Request55()
        {
        }
    }
}