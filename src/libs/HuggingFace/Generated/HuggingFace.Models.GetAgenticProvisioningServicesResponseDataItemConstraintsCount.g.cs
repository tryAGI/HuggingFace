
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemConstraintsCount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at_most")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AtMost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemConstraintsCount" /> class.
        /// </summary>
        /// <param name="atMost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemConstraintsCount(
            int atMost)
        {
            this.AtMost = atMost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemConstraintsCount" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemConstraintsCount()
        {
        }

    }
}