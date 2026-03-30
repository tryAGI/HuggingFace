
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningAccountRequestsResponseVariant1Credentials
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"bearer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "bearer";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant1CredentialsBearer Bearer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsResponseVariant1Credentials" /> class.
        /// </summary>
        /// <param name="bearer"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningAccountRequestsResponseVariant1Credentials(
            global::HuggingFace.CreateAgenticProvisioningAccountRequestsResponseVariant1CredentialsBearer bearer,
            string type = "bearer")
        {
            this.Type = type;
            this.Bearer = bearer ?? throw new global::System.ArgumentNullException(nameof(bearer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsResponseVariant1Credentials" /> class.
        /// </summary>
        public CreateAgenticProvisioningAccountRequestsResponseVariant1Credentials()
        {
        }
    }
}