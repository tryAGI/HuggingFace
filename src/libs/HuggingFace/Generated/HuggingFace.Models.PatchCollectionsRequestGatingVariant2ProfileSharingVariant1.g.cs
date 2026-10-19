
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchCollectionsRequestGatingVariant2ProfileSharingVariant1
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
        /// Initializes a new instance of the <see cref="PatchCollectionsRequestGatingVariant2ProfileSharingVariant1" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchCollectionsRequestGatingVariant2ProfileSharingVariant1(
            bool email,
            bool username = true)
        {
            this.Username = username;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchCollectionsRequestGatingVariant2ProfileSharingVariant1" /> class.
        /// </summary>
        public PatchCollectionsRequestGatingVariant2ProfileSharingVariant1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PatchCollectionsRequestGatingVariant2ProfileSharingVariant1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PatchCollectionsRequestGatingVariant2ProfileSharingVariant1 FromEmail(bool email)
        {
            return new PatchCollectionsRequestGatingVariant2ProfileSharingVariant1
            {
                Email = email,
            };
        }

    }
}