
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsersFollowingOrgsResponseItemEmailDomain
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        public bool? Verified { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersFollowingOrgsResponseItemEmailDomain" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="verified"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsersFollowingOrgsResponseItemEmailDomain(
            string domain,
            bool? verified)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Verified = verified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersFollowingOrgsResponseItemEmailDomain" /> class.
        /// </summary>
        public GetUsersFollowingOrgsResponseItemEmailDomain()
        {
        }

    }
}