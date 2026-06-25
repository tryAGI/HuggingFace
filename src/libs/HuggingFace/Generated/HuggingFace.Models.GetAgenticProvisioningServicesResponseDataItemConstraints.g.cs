
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemConstraints
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemConstraintsCount? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mutual_exclusion")]
        public global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemConstraintsMutualExclusion? MutualExclusion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemConstraints" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="mutualExclusion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemConstraints(
            global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemConstraintsCount? count,
            global::HuggingFace.GetAgenticProvisioningServicesResponseDataItemConstraintsMutualExclusion? mutualExclusion)
        {
            this.Count = count;
            this.MutualExclusion = mutualExclusion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemConstraints" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemConstraints()
        {
        }

    }
}