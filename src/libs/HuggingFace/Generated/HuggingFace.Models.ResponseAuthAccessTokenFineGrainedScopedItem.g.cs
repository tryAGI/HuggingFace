
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseAuthAccessTokenFineGrainedScopedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseAuthAccessTokenFineGrainedScopedItemEntity Entity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAuthAccessTokenFineGrainedScopedItem" /> class.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="permissions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseAuthAccessTokenFineGrainedScopedItem(
            global::HuggingFace.ResponseAuthAccessTokenFineGrainedScopedItemEntity entity,
            global::System.Collections.Generic.IList<string> permissions)
        {
            this.Entity = entity ?? throw new global::System.ArgumentNullException(nameof(entity));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAuthAccessTokenFineGrainedScopedItem" /> class.
        /// </summary>
        public ResponseAuthAccessTokenFineGrainedScopedItem()
        {
        }
    }
}