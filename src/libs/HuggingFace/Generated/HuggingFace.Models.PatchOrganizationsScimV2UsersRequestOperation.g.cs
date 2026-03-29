
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsScimV2UsersRequestOperation
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.PatchOrganizationsScimV2UsersRequestOperationPathJsonConverter))]
        public global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperationPath? Path { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimV2UsersRequestOperation" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="value"></param>
        /// <param name="path"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsScimV2UsersRequestOperation(
            string op,
            object value,
            global::HuggingFace.PatchOrganizationsScimV2UsersRequestOperationPath? path)
        {
            this.Op = op ?? throw new global::System.ArgumentNullException(nameof(op));
            this.Path = path;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimV2UsersRequestOperation" /> class.
        /// </summary>
        public PatchOrganizationsScimV2UsersRequestOperation()
        {
        }
    }
}