
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDiscussionsTitleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newTitle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDiscussionsTitleResponseNewTitle NewTitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsTitleResponse" /> class.
        /// </summary>
        /// <param name="newTitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDiscussionsTitleResponse(
            global::HuggingFace.CreateDiscussionsTitleResponseNewTitle newTitle)
        {
            this.NewTitle = newTitle ?? throw new global::System.ArgumentNullException(nameof(newTitle));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsTitleResponse" /> class.
        /// </summary>
        public CreateDiscussionsTitleResponse()
        {
        }
    }
}