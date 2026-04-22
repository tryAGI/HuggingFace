
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationsSettingsNetworkSecurityResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforceAuth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<bool?, string> EnforceAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforceIpRestriction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnforceIpRestriction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highRateLimits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<bool?, string> HighRateLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipRanges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> IpRanges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedUrls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> BlockedUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedUrls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsNetworkSecurityResponse" /> class.
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
        public GetOrganizationsSettingsNetworkSecurityResponse(
            global::HuggingFace.AnyOf<bool?, string> enforceAuth,
            bool enforceIpRestriction,
            global::HuggingFace.AnyOf<bool?, string> highRateLimits,
            global::System.Collections.Generic.IList<string> ipRanges,
            global::System.Collections.Generic.IList<string> blockedUrls,
            global::System.Collections.Generic.IList<string> allowedUrls)
        {
            this.EnforceAuth = enforceAuth;
            this.EnforceIpRestriction = enforceIpRestriction;
            this.HighRateLimits = highRateLimits;
            this.IpRanges = ipRanges ?? throw new global::System.ArgumentNullException(nameof(ipRanges));
            this.BlockedUrls = blockedUrls ?? throw new global::System.ArgumentNullException(nameof(blockedUrls));
            this.AllowedUrls = allowedUrls ?? throw new global::System.ArgumentNullException(nameof(allowedUrls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationsSettingsNetworkSecurityResponse" /> class.
        /// </summary>
        public GetOrganizationsSettingsNetworkSecurityResponse()
        {
        }
    }
}