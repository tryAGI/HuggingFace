
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningAccountRequestsRequestKyc
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField> VerifiedFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsRequestKyc" /> class.
        /// </summary>
        /// <param name="verifiedFields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningAccountRequestsRequestKyc(
            global::System.Collections.Generic.IList<global::HuggingFace.CreateAgenticProvisioningAccountRequestsRequestKycVerifiedField> verifiedFields)
        {
            this.VerifiedFields = verifiedFields ?? throw new global::System.ArgumentNullException(nameof(verifiedFields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsRequestKyc" /> class.
        /// </summary>
        public CreateAgenticProvisioningAccountRequestsRequestKyc()
        {
        }
    }
}