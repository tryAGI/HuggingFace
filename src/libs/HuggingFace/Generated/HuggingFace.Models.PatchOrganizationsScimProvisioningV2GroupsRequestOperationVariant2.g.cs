
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant2
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
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant2" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="path"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant2(
            string op,
            object value,
            string? path)
        {
            this.Op = op ?? throw new global::System.ArgumentNullException(nameof(op));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant2" /> class.
        /// </summary>
        public PatchOrganizationsScimProvisioningV2GroupsRequestOperationVariant2()
        {
        }
    }
}