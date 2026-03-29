
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::HuggingFace.CreateCollectionsRequestItem? Item { get; set; }

        /// <summary>
        /// If not provided, the collection will be public. This field will respect the organization's visibility setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsRequest" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="namespace"></param>
        /// <param name="description"></param>
        /// <param name="item"></param>
        /// <param name="private">
        /// If not provided, the collection will be public. This field will respect the organization's visibility setting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsRequest(
            string title,
            string @namespace,
            string? description,
            global::HuggingFace.CreateCollectionsRequestItem? item,
            bool? @private)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Item = item;
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsRequest" /> class.
        /// </summary>
        public CreateCollectionsRequest()
        {
        }
    }
}