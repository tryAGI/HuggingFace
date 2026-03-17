
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseDiscussionRepoOwner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.ResponseDiscussionRepoOwnerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.ResponseDiscussionRepoOwnerType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isParticipating")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsParticipating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDiscussionAuthor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDiscussionAuthor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDiscussionRepoOwner" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="isParticipating"></param>
        /// <param name="isDiscussionAuthor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseDiscussionRepoOwner(
            string name,
            global::HuggingFace.ResponseDiscussionRepoOwnerType type,
            bool isParticipating,
            bool isDiscussionAuthor)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.IsParticipating = isParticipating;
            this.IsDiscussionAuthor = isDiscussionAuthor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDiscussionRepoOwner" /> class.
        /// </summary>
        public ResponseDiscussionRepoOwner()
        {
        }
    }
}