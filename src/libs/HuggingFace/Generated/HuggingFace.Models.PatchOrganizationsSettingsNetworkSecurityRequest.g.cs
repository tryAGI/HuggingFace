
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsSettingsNetworkSecurityRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforceAuth")]
        public bool? EnforceAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforceIpRestriction")]
        public bool? EnforceIpRestriction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highRateLimits")]
        public bool? HighRateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipRanges")]
        public global::System.Collections.Generic.IList<string>? IpRanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedUrls")]
        public global::System.Collections.Generic.IList<string>? BlockedUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedUrls")]
        public global::System.Collections.Generic.IList<string>? AllowedUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsSettingsNetworkSecurityRequest" /> class.
        /// </summary>
        /// <param name="enforceAuth"></param>
        /// <param name="enforceIpRestriction"></param>
        /// <param name="highRateLimits"></param>
        /// <param name="ipRanges"></param>
        /// <param name="blockedUrls"></param>
        /// <param name="allowedUrls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsSettingsNetworkSecurityRequest(
            bool? enforceAuth,
            bool? enforceIpRestriction,
            bool? highRateLimits,
            global::System.Collections.Generic.IList<string>? ipRanges,
            global::System.Collections.Generic.IList<string>? blockedUrls,
            global::System.Collections.Generic.IList<string>? allowedUrls)
        {
            this.EnforceAuth = enforceAuth;
            this.EnforceIpRestriction = enforceIpRestriction;
            this.HighRateLimits = highRateLimits;
            this.IpRanges = ipRanges;
            this.BlockedUrls = blockedUrls;
            this.AllowedUrls = allowedUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsSettingsNetworkSecurityRequest" /> class.
        /// </summary>
        public PatchOrganizationsSettingsNetworkSecurityRequest()
        {
        }
    }
}