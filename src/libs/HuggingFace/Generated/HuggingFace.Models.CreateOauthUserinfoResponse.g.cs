
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOauthUserinfoResponse
    {
        /// <summary>
        /// ID of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sub { get; set; }

        /// <summary>
        /// Full name of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Username of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_username")]
        public string? PreferredUsername { get; set; }

        /// <summary>
        /// Profile URL of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public string? Profile { get; set; }

        /// <summary>
        /// Avatar URL of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture")]
        public string? Picture { get; set; }

        /// <summary>
        /// Website of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Email of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Whether the email is verified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// Whether the user is a Pro user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPro")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPro { get; set; }

        /// <summary>
        /// Whether the user has access to billing. You should check `canPay` first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canPay")]
        public bool? CanPay { get; set; }

        /// <summary>
        /// Whether the user is on prepaid or postpaid billing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateOauthUserinfoResponseBillingModeJsonConverter))]
        public global::HuggingFace.CreateOauthUserinfoResponseBillingMode? BillingMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrg> Orgs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthUserinfoResponse" /> class.
        /// </summary>
        /// <param name="sub">
        /// ID of the user
        /// </param>
        /// <param name="isPro">
        /// Whether the user is a Pro user
        /// </param>
        /// <param name="orgs"></param>
        /// <param name="name">
        /// Full name of the user
        /// </param>
        /// <param name="preferredUsername">
        /// Username of the user
        /// </param>
        /// <param name="profile">
        /// Profile URL of the user
        /// </param>
        /// <param name="picture">
        /// Avatar URL of the user
        /// </param>
        /// <param name="website">
        /// Website of the user
        /// </param>
        /// <param name="email">
        /// Email of the user
        /// </param>
        /// <param name="emailVerified">
        /// Whether the email is verified
        /// </param>
        /// <param name="canPay">
        /// Whether the user has access to billing. You should check `canPay` first.
        /// </param>
        /// <param name="billingMode">
        /// Whether the user is on prepaid or postpaid billing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOauthUserinfoResponse(
            string sub,
            bool isPro,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateOauthUserinfoResponseOrg> orgs,
            string? name,
            string? preferredUsername,
            string? profile,
            string? picture,
            string? website,
            string? email,
            bool? emailVerified,
            bool? canPay,
            global::HuggingFace.CreateOauthUserinfoResponseBillingMode? billingMode)
        {
            this.Sub = sub ?? throw new global::System.ArgumentNullException(nameof(sub));
            this.Name = name;
            this.PreferredUsername = preferredUsername;
            this.Profile = profile;
            this.Picture = picture;
            this.Website = website;
            this.Email = email;
            this.EmailVerified = emailVerified;
            this.IsPro = isPro;
            this.CanPay = canPay;
            this.BillingMode = billingMode;
            this.Orgs = orgs ?? throw new global::System.ArgumentNullException(nameof(orgs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthUserinfoResponse" /> class.
        /// </summary>
        public CreateOauthUserinfoResponse()
        {
        }
    }
}