
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response60
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("socialHandles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseSocialHandles SocialHandles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response60" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <param name="socialHandles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response60(
            string id,
            string user,
            global::HuggingFace.ResponseSocialHandles socialHandles)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.SocialHandles = socialHandles ?? throw new global::System.ArgumentNullException(nameof(socialHandles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response60" /> class.
        /// </summary>
        public Response60()
        {
        }
    }
}