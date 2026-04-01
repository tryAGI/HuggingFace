
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgenticProvisioningAccountRequestsRequestOrchestratorStripe
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public string? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Account { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsRequestOrchestratorStripe" /> class.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="organization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgenticProvisioningAccountRequestsRequestOrchestratorStripe(
            string account,
            string? organization)
        {
            this.Organization = organization;
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgenticProvisioningAccountRequestsRequestOrchestratorStripe" /> class.
        /// </summary>
        public CreateAgenticProvisioningAccountRequestsRequestOrchestratorStripe()
        {
        }
    }
}