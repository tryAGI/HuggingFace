
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request3
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestDeleteItem>? Delete { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestAddItem>? Add { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request3" /> class.
        /// </summary>
        /// <param name="delete">
        /// Default Value: []
        /// </param>
        /// <param name="add">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request3(
            global::System.Collections.Generic.IList<global::HuggingFace.RequestDeleteItem>? delete,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestAddItem>? add)
        {
            this.Delete = delete;
            this.Add = add;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request3" /> class.
        /// </summary>
        public Request3()
        {
        }
    }
}