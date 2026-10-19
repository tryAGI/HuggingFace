
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant2
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>false</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public bool Username { get; set; } = false;

        /// <summary>
        ///
        /// </summary>
        /// <default>false</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public bool Email { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant2" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant2(
            bool username = false,
            bool email = false)
        {
            this.Username = username;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant2" /> class.
        /// </summary>
        public CreateCollectionsItemsResponseGatingVariant2Variant3ProfileSharingVariant2()
        {
        }

    }
}