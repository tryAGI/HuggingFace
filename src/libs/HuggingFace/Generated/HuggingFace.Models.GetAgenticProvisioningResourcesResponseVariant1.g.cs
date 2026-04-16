
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningResourcesResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"complete"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "complete";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.GetAgenticProvisioningResourcesResponseVariant1Complete Complete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningResourcesResponseVariant1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="complete"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningResourcesResponseVariant1(
            string id,
            global::HuggingFace.GetAgenticProvisioningResourcesResponseVariant1Complete complete,
            string status = "complete")
        {
            this.Status = status;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Complete = complete ?? throw new global::System.ArgumentNullException(nameof(complete));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningResourcesResponseVariant1" /> class.
        /// </summary>
        public GetAgenticProvisioningResourcesResponseVariant1()
        {
        }
    }
}