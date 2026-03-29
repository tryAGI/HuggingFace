
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsScimProvisioningV2UsersRequestOperation
    {
        /// <summary>
        /// `remove` operation is not supported for non-managed organizations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchOrganizationsScimProvisioningV2UsersRequestOperationOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperationOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchOrganizationsScimProvisioningV2UsersRequestOperationPathJsonConverter))]
        public global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperationPath? Path { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimProvisioningV2UsersRequestOperation" /> class.
        /// </summary>
        /// <param name="op">
        /// `remove` operation is not supported for non-managed organizations
        /// </param>
        /// <param name="value"></param>
        /// <param name="path"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsScimProvisioningV2UsersRequestOperation(
            global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperationOp op,
            object value,
            global::HuggingFace.PatchOrganizationsScimProvisioningV2UsersRequestOperationPath? path)
        {
            this.Op = op;
            this.Path = path;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimProvisioningV2UsersRequestOperation" /> class.
        /// </summary>
        public PatchOrganizationsScimProvisioningV2UsersRequestOperation()
        {
        }
    }
}