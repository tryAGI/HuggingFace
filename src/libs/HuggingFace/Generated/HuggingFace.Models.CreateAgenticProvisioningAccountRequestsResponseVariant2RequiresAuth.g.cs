
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningAccountRequestsResponseVariant2RequiresAuth
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"redirect"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "redirect";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant2RequiresAuthRedirect Redirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsResponseVariant2RequiresAuth" /> class.
        /// </summary>
        /// <param name="redirect"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningAccountRequestsResponseVariant2RequiresAuth(
            global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant2RequiresAuthRedirect redirect,
            string type = "redirect")
        {
            this.Type = type;
            this.Redirect = redirect ?? throw new global::System.ArgumentNullException(nameof(redirect));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsResponseVariant2RequiresAuth" /> class.
        /// </summary>
        public CreateAgenticProvisioningAccountRequestsResponseVariant2RequiresAuth()
        {
        }
    }
}