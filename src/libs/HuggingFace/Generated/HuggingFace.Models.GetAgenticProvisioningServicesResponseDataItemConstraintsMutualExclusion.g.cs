
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgenticProvisioningServicesResponseDataItemConstraintsMutualExclusion
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"True"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_updates")]
        public string AllowedUpdates { get; set; } = "True";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemConstraintsMutualExclusion" /> class.
        /// </summary>
        /// <param name="allowedUpdates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgenticProvisioningServicesResponseDataItemConstraintsMutualExclusion(
            string allowedUpdates = "True")
        {
            this.AllowedUpdates = allowedUpdates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgenticProvisioningServicesResponseDataItemConstraintsMutualExclusion" /> class.
        /// </summary>
        public GetAgenticProvisioningServicesResponseDataItemConstraintsMutualExclusion()
        {
        }

    }
}