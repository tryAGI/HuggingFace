
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDiscussionsStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateDiscussionsStatusResponseNewStatus NewStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsStatusResponse" /> class.
        /// </summary>
        /// <param name="newStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDiscussionsStatusResponse(
            global::HuggingFace.CreateDiscussionsStatusResponseNewStatus newStatus)
        {
            this.NewStatus = newStatus ?? throw new global::System.ArgumentNullException(nameof(newStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiscussionsStatusResponse" /> class.
        /// </summary>
        public CreateDiscussionsStatusResponse()
        {
        }
    }
}