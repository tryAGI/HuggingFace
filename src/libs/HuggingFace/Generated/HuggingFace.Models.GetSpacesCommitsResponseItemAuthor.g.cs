
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSpacesCommitsResponseItemAuthor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesCommitsResponseItemAuthor" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="avatar"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSpacesCommitsResponseItemAuthor(
            string user,
            string? avatar)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Avatar = avatar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpacesCommitsResponseItemAuthor" /> class.
        /// </summary>
        public GetSpacesCommitsResponseItemAuthor()
        {
        }
    }
}