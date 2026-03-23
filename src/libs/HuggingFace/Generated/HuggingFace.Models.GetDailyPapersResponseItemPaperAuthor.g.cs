
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Paper author information
    /// </summary>
    public sealed partial class GetDailyPapersResponseItemPaperAuthor
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusLastChangedAt")]
        public global::System.DateTime? StatusLastChangedAt { get; set; }

        /// <summary>
        /// User overview information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::HuggingFace.GetDailyPapersResponseItemPaperAuthorUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Hidden { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDailyPapersResponseItemPaperAuthor" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="statusLastChangedAt"></param>
        /// <param name="user">
        /// User overview information
        /// </param>
        /// <param name="hidden"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDailyPapersResponseItemPaperAuthor(
            string id,
            string name,
            bool hidden,
            string? status,
            global::System.DateTime? statusLastChangedAt,
            global::HuggingFace.GetDailyPapersResponseItemPaperAuthorUser? user)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Hidden = hidden;
            this.Status = status;
            this.StatusLastChangedAt = statusLastChangedAt;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDailyPapersResponseItemPaperAuthor" /> class.
        /// </summary>
        public GetDailyPapersResponseItemPaperAuthor()
        {
        }
    }
}