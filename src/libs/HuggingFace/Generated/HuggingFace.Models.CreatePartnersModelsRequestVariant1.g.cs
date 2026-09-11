
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePartnersModelsRequestVariant1
    {
        /// <summary>
        /// Default Value: single-model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hfModel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HfModel { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant1StatusJsonConverter))]
        public global::HuggingFace.CreatePartnersModelsRequestVariant1Status? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreatePartnersModelsRequestVariant1TaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreatePartnersModelsRequestVariant1Task Task { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePartnersModelsRequestVariant1" /> class.
        /// </summary>
        /// <param name="hfModel"></param>
        /// <param name="providerModel"></param>
        /// <param name="task"></param>
        /// <param name="type">
        /// Default Value: single-model
        /// </param>
        /// <param name="status">
        /// Default Value: staging
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePartnersModelsRequestVariant1(
            string hfModel,
            string providerModel,
            global::HuggingFace.CreatePartnersModelsRequestVariant1Task task,
            string? type,
            global::HuggingFace.CreatePartnersModelsRequestVariant1Status? status)
        {
            this.Type = type;
            this.HfModel = hfModel ?? throw new global::System.ArgumentNullException(nameof(hfModel));
            this.ProviderModel = providerModel ?? throw new global::System.ArgumentNullException(nameof(providerModel));
            this.Status = status;
            this.Task = task;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePartnersModelsRequestVariant1" /> class.
        /// </summary>
        public CreatePartnersModelsRequestVariant1()
        {
        }

    }
}