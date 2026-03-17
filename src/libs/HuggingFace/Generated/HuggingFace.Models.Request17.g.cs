
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request17
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.RequestOperation2> Operations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request17" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="operations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request17(
            global::System.Collections.Generic.IList<string> schemas,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestOperation2> operations)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Operations = operations ?? throw new global::System.ArgumentNullException(nameof(operations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request17" /> class.
        /// </summary>
        public Request17()
        {
        }
    }
}