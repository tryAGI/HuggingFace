
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteOrganizationsResourceGroupsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrganizationsResourceGroupsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteOrganizationsResourceGroupsResponse(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrganizationsResourceGroupsResponse" /> class.
        /// </summary>
        public DeleteOrganizationsResourceGroupsResponse()
        {
        }

    }
}