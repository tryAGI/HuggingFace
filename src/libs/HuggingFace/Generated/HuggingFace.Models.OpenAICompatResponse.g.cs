
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAICompatResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.OpenAICompatEmbedding> Data { get; set; }

        /// <summary>
        /// Example: thenlper/gte-base
        /// </summary>
        /// <example>thenlper/gte-base</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Example: list
        /// </summary>
        /// <example>list</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.OpenAICompatUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="model">
        /// Example: thenlper/gte-base
        /// </param>
        /// <param name="object">
        /// Example: list
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAICompatResponse(
            global::System.Collections.Generic.IList<global::HuggingFace.OpenAICompatEmbedding> data,
            string model,
            string @object,
            global::HuggingFace.OpenAICompatUsage usage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAICompatResponse" /> class.
        /// </summary>
        public OpenAICompatResponse()
        {
        }
    }
}