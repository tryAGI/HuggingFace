
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesRequestVariant2Configuration
    {
        /// <summary>
        /// The name of the repository (defaults to a random name if not provided)<br/>
        /// Default Value: NOGuIDen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The visibility of the repository (defaults to private)<br/>
        /// Default Value: private
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibilityJsonConverter))]
        public global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibility? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant2Configuration" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the repository (defaults to a random name if not provided)<br/>
        /// Default Value: NOGuIDen
        /// </param>
        /// <param name="visibility">
        /// The visibility of the repository (defaults to private)<br/>
        /// Default Value: private
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesRequestVariant2Configuration(
            string? name,
            global::HuggingFace.CreateAgenticProvisioningResourcesRequestVariant2ConfigurationVisibility? visibility)
        {
            this.Name = name;
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesRequestVariant2Configuration" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesRequestVariant2Configuration()
        {
        }
    }
}