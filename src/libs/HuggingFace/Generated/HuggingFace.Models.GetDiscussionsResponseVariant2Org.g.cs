
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDiscussionsResponseVariant2Org
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fullname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"org"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "org";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isHf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsHf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.GetDiscussionsResponseVariant2OrgPlanJsonConverter))]
        public global::HuggingFace.GetDiscussionsResponseVariant2OrgPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasPrivateMembersList")]
        public bool? HasPrivateMembersList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiresSSO")]
        public bool? RequiresSSO { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2Org" /> class.
        /// </summary>
        /// <param name="avatarUrl"></param>
        /// <param name="email"></param>
        /// <param name="fullname"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="isHf"></param>
        /// <param name="plan"></param>
        /// <param name="details"></param>
        /// <param name="hasPrivateMembersList"></param>
        /// <param name="requiresSSO"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDiscussionsResponseVariant2Org(
            string avatarUrl,
            string fullname,
            string name,
            bool isHf,
            string? email,
            global::HuggingFace.GetDiscussionsResponseVariant2OrgPlan? plan,
            string? details,
            bool? hasPrivateMembersList,
            bool? requiresSSO,
            string type = "org")
        {
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Fullname = fullname ?? throw new global::System.ArgumentNullException(nameof(fullname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsHf = isHf;
            this.Email = email;
            this.Type = type;
            this.Plan = plan;
            this.Details = details;
            this.HasPrivateMembersList = hasPrivateMembersList;
            this.RequiresSSO = requiresSSO;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDiscussionsResponseVariant2Org" /> class.
        /// </summary>
        public GetDiscussionsResponseVariant2Org()
        {
        }
    }
}