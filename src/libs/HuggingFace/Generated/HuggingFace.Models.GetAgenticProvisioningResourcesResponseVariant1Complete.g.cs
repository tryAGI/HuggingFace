
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningResourcesResponseVariant1Complete
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_configuration")]
        public object? AccessConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningResourcesResponseVariant1Complete" /> class.
        /// </summary>
        /// <param name="accessConfiguration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningResourcesResponseVariant1Complete(
            object? accessConfiguration)
        {
            this.AccessConfiguration = accessConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningResourcesResponseVariant1Complete" /> class.
        /// </summary>
        public GetAgenticProvisioningResourcesResponseVariant1Complete()
        {
        }
    }
}