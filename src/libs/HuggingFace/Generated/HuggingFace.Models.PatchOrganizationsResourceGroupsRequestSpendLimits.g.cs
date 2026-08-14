
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsResourceGroupsRequestSpendLimits
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferenceProviders")]
        public int? InferenceProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaces")]
        public int? Spaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public int? Jobs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        public int? Endpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsResourceGroupsRequestSpendLimits" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="inferenceProviders"></param>
        /// <param name="spaces"></param>
        /// <param name="jobs"></param>
        /// <param name="endpoints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsResourceGroupsRequestSpendLimits(
            int? total,
            int? inferenceProviders,
            int? spaces,
            int? jobs,
            int? endpoints)
        {
            this.Total = total;
            this.InferenceProviders = inferenceProviders;
            this.Spaces = spaces;
            this.Jobs = jobs;
            this.Endpoints = endpoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsResourceGroupsRequestSpendLimits" /> class.
        /// </summary>
        public PatchOrganizationsResourceGroupsRequestSpendLimits()
        {
        }

    }
}