
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestOperationVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestOperationVariant1ValueItem>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestOperationVariant1" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="path"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestOperationVariant1(
            string op,
            string path,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestOperationVariant1ValueItem>? value)
        {
            this.Op = op ?? throw new global::System.ArgumentNullException(nameof(op));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestOperationVariant1" /> class.
        /// </summary>
        public RequestOperationVariant1()
        {
        }
    }
}