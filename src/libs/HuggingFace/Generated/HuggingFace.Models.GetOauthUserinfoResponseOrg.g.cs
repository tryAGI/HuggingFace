
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOauthUserinfoResponseOrg
    {
        /// <summary>
        /// ID of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sub { get; set; }

        /// <summary>
        /// Name of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Avatar URL of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Picture { get; set; }

        /// <summary>
        /// Username of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreferredUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgPlanJsonConverter))]
        public global::HuggingFace.GetOauthUserinfoResponseOrgPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canPay")]
        public bool? CanPay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgBillingModeJsonConverter))]
        public global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode? BillingMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roleInOrg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetOauthUserinfoResponseOrgRoleInOrgJsonConverter))]
        public global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg? RoleInOrg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pendingSSO")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? PendingSSO { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missingMFA")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? MissingMFA { get; set; }

        /// <summary>
        /// Current security restrictions for accessing data in this organization with current authentication method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securityRestrictions")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction>? SecurityRestrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroups")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup>? ResourceGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOauthUserinfoResponseOrg" /> class.
        /// </summary>
        /// <param name="sub">
        /// ID of the organization
        /// </param>
        /// <param name="name">
        /// Name of the organization
        /// </param>
        /// <param name="picture">
        /// Avatar URL of the organization
        /// </param>
        /// <param name="preferredUsername">
        /// Username of the organization
        /// </param>
        /// <param name="plan"></param>
        /// <param name="canPay"></param>
        /// <param name="billingMode"></param>
        /// <param name="roleInOrg"></param>
        /// <param name="securityRestrictions">
        /// Current security restrictions for accessing data in this organization with current authentication method
        /// </param>
        /// <param name="resourceGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOauthUserinfoResponseOrg(
            string sub,
            string name,
            string picture,
            string preferredUsername,
            global::HuggingFace.GetOauthUserinfoResponseOrgPlan? plan,
            bool? canPay,
            global::HuggingFace.GetOauthUserinfoResponseOrgBillingMode? billingMode,
            global::HuggingFace.GetOauthUserinfoResponseOrgRoleInOrg? roleInOrg,
            global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgSecurityRestriction>? securityRestrictions,
            global::System.Collections.Generic.IList<global::HuggingFace.GetOauthUserinfoResponseOrgResourceGroup>? resourceGroups)
        {
            this.Sub = sub ?? throw new global::System.ArgumentNullException(nameof(sub));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Picture = picture ?? throw new global::System.ArgumentNullException(nameof(picture));
            this.PreferredUsername = preferredUsername ?? throw new global::System.ArgumentNullException(nameof(preferredUsername));
            this.Plan = plan;
            this.CanPay = canPay;
            this.BillingMode = billingMode;
            this.RoleInOrg = roleInOrg;
            this.SecurityRestrictions = securityRestrictions;
            this.ResourceGroups = resourceGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOauthUserinfoResponseOrg" /> class.
        /// </summary>
        public GetOauthUserinfoResponseOrg()
        {
        }
    }
}