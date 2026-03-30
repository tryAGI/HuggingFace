
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningResourcesResponseVariant2Complete
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object AccessConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesResponseVariant2Complete" /> class.
        /// </summary>
        /// <param name="accessConfiguration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningResourcesResponseVariant2Complete(
            object accessConfiguration)
        {
            this.AccessConfiguration = accessConfiguration ?? throw new global::System.ArgumentNullException(nameof(accessConfiguration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningResourcesResponseVariant2Complete" /> class.
        /// </summary>
        public CreateAgenticProvisioningResourcesResponseVariant2Complete()
        {
        }
    }
}