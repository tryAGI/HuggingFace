
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Resource provisioning error
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "error";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2Error Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesResponseVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="error"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesResponseVariant2(
            string id,
            global::HuggingFace.CreateAgenticProvisioningResourcesResponseVariant2Error error,
            string status = "error")
        {
            this.Status = status;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesResponseVariant2" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesResponseVariant2()
        {
        }
    }
}