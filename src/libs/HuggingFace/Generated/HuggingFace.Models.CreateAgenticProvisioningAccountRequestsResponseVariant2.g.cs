
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningAccountRequestsResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"requires_auth"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "requires_auth";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant2RequiresAuth RequiresAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsResponseVariant2" /> class.
        /// </summary>
        /// <param name="requiresAuth"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningAccountRequestsResponseVariant2(
            global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant2RequiresAuth requiresAuth,
            string type = "requires_auth")
        {
            this.Type = type;
            this.RequiresAuth = requiresAuth ?? throw new global::System.ArgumentNullException(nameof(requiresAuth));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsResponseVariant2" /> class.
        /// </summary>
        public CreateAgenticProvisioningAccountRequestsResponseVariant2()
        {
        }
    }
}