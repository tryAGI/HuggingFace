
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request21
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
        public required global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.RequestOperationVariant12, global::HuggingFace.RequestOperationVariant22>> Operations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request21" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="operations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request21(
            global::System.Collections.Generic.IList<string> schemas,
            global::System.Collections.Generic.IList<global::HuggingFace.AnyOf<global::HuggingFace.RequestOperationVariant12, global::HuggingFace.RequestOperationVariant22>> operations)
        {
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Operations = operations ?? throw new global::System.ArgumentNullException(nameof(operations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request21" /> class.
        /// </summary>
        public Request21()
        {
        }
    }
}