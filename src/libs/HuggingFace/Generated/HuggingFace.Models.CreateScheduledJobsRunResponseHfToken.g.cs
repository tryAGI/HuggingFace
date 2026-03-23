
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateScheduledJobsRunResponseHfToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgName")]
        public string? OrgName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenRole")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateScheduledJobsRunResponseHfTokenTokenRoleJsonConverter))]
        public global::HuggingFace.CreateScheduledJobsRunResponseHfTokenTokenRole? TokenRole { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenId")]
        public string? TokenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settingsUrl")]
        public string? SettingsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledJobsRunResponseHfToken" /> class.
        /// </summary>
        /// <param name="ownerName"></param>
        /// <param name="orgName"></param>
        /// <param name="tokenRole"></param>
        /// <param name="tokenId"></param>
        /// <param name="settingsUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateScheduledJobsRunResponseHfToken(
            string ownerName,
            string? orgName,
            global::HuggingFace.CreateScheduledJobsRunResponseHfTokenTokenRole? tokenRole,
            string? tokenId,
            string? settingsUrl)
        {
            this.OwnerName = ownerName ?? throw new global::System.ArgumentNullException(nameof(ownerName));
            this.OrgName = orgName;
            this.TokenRole = tokenRole;
            this.TokenId = tokenId;
            this.SettingsUrl = settingsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledJobsRunResponseHfToken" /> class.
        /// </summary>
        public CreateScheduledJobsRunResponseHfToken()
        {
        }
    }
}