
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchOrganizationsSettingsNetworkSecurityResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforceAuth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnforceAuth { get; set; }

        /// <summary>
        /// Whether the declared ipRanges match the admin-validated CIDR ranges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areCidrRangesApproved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AreCidrRangesApproved { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HighRateLimits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipRanges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> IpRanges { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockedContents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent> BlockedContents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedContents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent> AllowedContents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepReposMetadataVisible")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool KeepReposMetadataVisible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsSettingsNetworkSecurityResponse" /> class.
        /// </summary>
        /// <param name="enforceAuth"></param>
        /// <param name="areCidrRangesApproved">
        /// Whether the declared ipRanges match the admin-validated CIDR ranges
        /// </param>
        /// <param name="enforceIpRestriction"></param>
        /// <param name="highRateLimits"></param>
        /// <param name="ipRanges"></param>
        /// <param name="blockedContents"></param>
        /// <param name="allowedContents"></param>
        /// <param name="keepReposMetadataVisible"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsSettingsNetworkSecurityResponse(
            bool enforceAuth,
            bool areCidrRangesApproved,
            bool enforceIpRestriction,
            bool highRateLimits,
            global::System.Collections.Generic.IList<string> ipRanges,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseBlockedContent> blockedContents,
            global::System.Collections.Generic.IList<global::HuggingFace.PatchOrganizationsSettingsNetworkSecurityResponseAllowedContent> allowedContents,
            bool keepReposMetadataVisible)
        {
            this.EnforceAuth = enforceAuth;
            this.AreCidrRangesApproved = areCidrRangesApproved;
            this.EnforceIpRestriction = enforceIpRestriction;
            this.HighRateLimits = highRateLimits;
            this.IpRanges = ipRanges ?? throw new global::System.ArgumentNullException(nameof(ipRanges));
            this.BlockedContents = blockedContents ?? throw new global::System.ArgumentNullException(nameof(blockedContents));
            this.AllowedContents = allowedContents ?? throw new global::System.ArgumentNullException(nameof(allowedContents));
            this.KeepReposMetadataVisible = keepReposMetadataVisible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsSettingsNetworkSecurityResponse" /> class.
        /// </summary>
        public PatchOrganizationsSettingsNetworkSecurityResponse()
        {
        }

    }
}