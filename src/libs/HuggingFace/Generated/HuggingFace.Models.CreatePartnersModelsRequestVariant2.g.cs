
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePartnersModelsRequestVariant2
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"tag-filter"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tag-filter";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerModel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderModel { get; set; }

        /// <summary>
        /// Default Value: staging
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant2StatusJsonConverter))]
        public global::HuggingFace.CreatePartnersModelsRequestVariant2Status? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant2TaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreatePartnersModelsRequestVariant2Task Task { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"lora"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapterType")]
        public string AdapterType { get; set; } = "lora";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePartnersModelsRequestVariant2" /> class.
        /// </summary>
        /// <param name="providerModel"></param>
        /// <param name="task"></param>
        /// <param name="tags"></param>
        /// <param name="status">
        /// Default Value: staging
        /// </param>
        /// <param name="type"></param>
        /// <param name="adapterType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePartnersModelsRequestVariant2(
            string providerModel,
            global::HuggingFace.CreatePartnersModelsRequestVariant2Task task,
            global::System.Collections.Generic.IList<string> tags,
            global::HuggingFace.CreatePartnersModelsRequestVariant2Status? status,
            string type = "tag-filter",
            string adapterType = "lora")
        {
            this.Type = type;
            this.ProviderModel = providerModel ?? throw new global::System.ArgumentNullException(nameof(providerModel));
            this.Status = status;
            this.Task = task;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.AdapterType = adapterType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePartnersModelsRequestVariant2" /> class.
        /// </summary>
        public CreatePartnersModelsRequestVariant2()
        {
        }

    }
}