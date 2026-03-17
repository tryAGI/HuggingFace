
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.RequestRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroups")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestResourceGroup>? ResourceGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request9" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="resourceGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request9(
            global::HuggingFace.RequestRole role,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestResourceGroup>? resourceGroups)
        {
            this.Role = role;
            this.ResourceGroups = resourceGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request9" /> class.
        /// </summary>
        public Request9()
        {
        }
    }
}