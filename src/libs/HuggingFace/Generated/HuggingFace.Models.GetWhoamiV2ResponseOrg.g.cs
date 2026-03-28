
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWhoamiV2ResponseOrg
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"org"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "org";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fullname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canPay")]
        public bool? CanPay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgBillingModeJsonConverter))]
        public global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode? BillingMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("periodEnd")]
        public double? PeriodEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgPlanJsonConverter))]
        public global::HuggingFace.GetWhoamiV2ResponseOrgPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roleInOrg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetWhoamiV2ResponseOrgRoleInOrgJsonConverter))]
        public global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg? RoleInOrg { get; set; }

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
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction>? SecurityRestrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroups")]
        public global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup>? ResourceGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhoamiV2ResponseOrg" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="fullname"></param>
        /// <param name="email"></param>
        /// <param name="canPay"></param>
        /// <param name="billingMode"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="periodEnd"></param>
        /// <param name="plan"></param>
        /// <param name="roleInOrg"></param>
        /// <param name="securityRestrictions">
        /// Current security restrictions for accessing data in this organization with current authentication method
        /// </param>
        /// <param name="resourceGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWhoamiV2ResponseOrg(
            string id,
            string name,
            string fullname,
            string avatarUrl,
            string? email,
            bool? canPay,
            global::HuggingFace.GetWhoamiV2ResponseOrgBillingMode? billingMode,
            double? periodEnd,
            global::HuggingFace.GetWhoamiV2ResponseOrgPlan? plan,
            global::HuggingFace.GetWhoamiV2ResponseOrgRoleInOrg? roleInOrg,
            global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgSecurityRestriction>? securityRestrictions,
            global::System.Collections.Generic.IList<global::HuggingFace.GetWhoamiV2ResponseOrgResourceGroup>? resourceGroups,
            string type = "org")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Type = type;
            this.Email = email;
            this.CanPay = canPay;
            this.BillingMode = billingMode;
            this.PeriodEnd = periodEnd;
            this.Plan = plan;
            this.RoleInOrg = roleInOrg;
            this.SecurityRestrictions = securityRestrictions;
            this.ResourceGroups = resourceGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWhoamiV2ResponseOrg" /> class.
        /// </summary>
        public GetWhoamiV2ResponseOrg()
        {
        }
    }
}