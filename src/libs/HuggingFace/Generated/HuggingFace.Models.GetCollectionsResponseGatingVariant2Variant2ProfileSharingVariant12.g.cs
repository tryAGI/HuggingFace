
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant12
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public bool Username { get; set; } = true;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant12" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant12(
            bool email,
            bool username = true)
        {
            this.Username = username;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant12" /> class.
        /// </summary>
        public GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant12()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant12"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant12 FromEmail(bool email)
        {
            return new GetCollectionsResponseGatingVariant2Variant2ProfileSharingVariant12
            {
                Email = email,
            };
        }

    }
}