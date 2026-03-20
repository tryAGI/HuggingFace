
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request44
    {
        /// <summary>
        /// The resource group to add the repository to, if null, the repository will be removed from the resource group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request44" /> class.
        /// </summary>
        /// <param name="resourceGroupId">
        /// The resource group to add the repository to, if null, the repository will be removed from the resource group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request44(
            string? resourceGroupId)
        {
            this.ResourceGroupId = resourceGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request44" /> class.
        /// </summary>
        public Request44()
        {
        }
    }
}