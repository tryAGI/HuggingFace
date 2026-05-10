
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"pending"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "pending";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesResponseVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesResponseVariant2(
            string id,
            string status = "pending")
        {
            this.Status = status;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesResponseVariant2" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesResponseVariant2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateAgenticProvisioningResourcesResponseVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateAgenticProvisioningResourcesResponseVariant2 FromId(string id)
        {
            return new CreateAgenticProvisioningResourcesResponseVariant2
            {
                Id = id,
            };
        }

    }
}