
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// The user to grant access to either by userId or user
    /// </summary>
    public sealed partial class Request59
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request59" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="user"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request59(
            string? userId,
            string? user)
        {
            this.UserId = userId;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request59" /> class.
        /// </summary>
        public Request59()
        {
        }
    }
}