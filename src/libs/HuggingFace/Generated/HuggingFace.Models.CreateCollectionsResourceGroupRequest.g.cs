
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionsResourceGroupRequest
    {
        /// <summary>
        /// The resource group to assign the collection to. If null, the collection is removed from any resource group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResourceGroupRequest" /> class.
        /// </summary>
        /// <param name="resourceGroupId">
        /// The resource group to assign the collection to. If null, the collection is removed from any resource group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsResourceGroupRequest(
            string? resourceGroupId)
        {
            this.ResourceGroupId = resourceGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsResourceGroupRequest" /> class.
        /// </summary>
        public CreateCollectionsResourceGroupRequest()
        {
        }

    }
}