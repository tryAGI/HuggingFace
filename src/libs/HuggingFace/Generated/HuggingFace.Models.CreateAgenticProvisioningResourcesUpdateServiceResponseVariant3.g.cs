
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Service update error
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3
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
        public required global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3Error Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="error"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3(
            string id,
            global::HuggingFace.CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3Error error,
            string status = "error")
        {
            this.Status = status;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesUpdateServiceResponseVariant3()
        {
        }
    }
}