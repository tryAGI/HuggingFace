
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Returned when `expand=followedAt` is set
    /// </summary>
    public sealed partial class GetUsersFollowersResponseItemVariant2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("followedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FollowedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersFollowersResponseItemVariant2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="followedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsersFollowersResponseItemVariant2(
            string id,
            global::System.DateTime followedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FollowedAt = followedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersFollowersResponseItemVariant2" /> class.
        /// </summary>
        public GetUsersFollowersResponseItemVariant2()
        {
        }

    }
}