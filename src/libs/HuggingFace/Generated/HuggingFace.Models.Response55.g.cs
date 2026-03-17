
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response55
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseAuth Auth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "user";

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseBillingMode3JsonConverter))]
        public global::HuggingFace.ResponseBillingMode3? BillingMode { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("emailVerified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPro")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.ResponseOrg3> Orgs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response55" /> class.
        /// </summary>
        /// <param name="auth"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="fullname"></param>
        /// <param name="email"></param>
        /// <param name="canPay"></param>
        /// <param name="billingMode"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="periodEnd"></param>
        /// <param name="emailVerified"></param>
        /// <param name="isPro"></param>
        /// <param name="orgs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response55(
            global::HuggingFace.ResponseAuth auth,
            string id,
            string name,
            string fullname,
            string avatarUrl,
            bool isPro,
            global::System.Collections.Generic.IList<global::HuggingFace.ResponseOrg3> orgs,
            string? email,
            bool? canPay,
            global::HuggingFace.ResponseBillingMode3? billingMode,
            double? periodEnd,
            bool? emailVerified,
            string type = "user")
        {
            this.Auth = auth ?? throw new global::System.ArgumentNullException(nameof(auth));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.IsPro = isPro;
            this.Orgs = orgs ?? throw new global::System.ArgumentNullException(nameof(orgs));
            this.Type = type;
            this.Email = email;
            this.CanPay = canPay;
            this.BillingMode = billingMode;
            this.PeriodEnd = periodEnd;
            this.EmailVerified = emailVerified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response55" /> class.
        /// </summary>
        public Response55()
        {
        }
    }
}