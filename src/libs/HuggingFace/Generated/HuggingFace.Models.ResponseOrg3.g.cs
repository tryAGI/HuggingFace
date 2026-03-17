
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseOrg3
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseOrgBillingMode3JsonConverter))]
        public global::HuggingFace.ResponseOrgBillingMode3? BillingMode { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseOrgPlan3JsonConverter))]
        public global::HuggingFace.ResponseOrgPlan3? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roleInOrg")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseOrgRoleInOrg3JsonConverter))]
        public global::HuggingFace.ResponseOrgRoleInOrg3? RoleInOrg { get; set; }

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
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseOrgSecurityRestriction3>? SecurityRestrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroups")]
        public global::System.Collections.Generic.IList<global::HuggingFace.ResponseOrgResourceGroup3>? ResourceGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOrg3" /> class.
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
        public ResponseOrg3(
            string id,
            string name,
            string fullname,
            string avatarUrl,
            string? email,
            bool? canPay,
            global::HuggingFace.ResponseOrgBillingMode3? billingMode,
            double? periodEnd,
            global::HuggingFace.ResponseOrgPlan3? plan,
            global::HuggingFace.ResponseOrgRoleInOrg3? roleInOrg,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseOrgSecurityRestriction3>? securityRestrictions,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseOrgResourceGroup3>? resourceGroups,
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
        /// Initializes a new instance of the <see cref="ResponseOrg3" /> class.
        /// </summary>
        public ResponseOrg3()
        {
        }
    }
}