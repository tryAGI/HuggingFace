
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchOrganizationsScimV2UsersResponseName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("givenName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GivenName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("familyName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FamilyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Formatted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimV2UsersResponseName" /> class.
        /// </summary>
        /// <param name="givenName"></param>
        /// <param name="familyName"></param>
        /// <param name="formatted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchOrganizationsScimV2UsersResponseName(
            string givenName,
            string familyName,
            string formatted)
        {
            this.GivenName = givenName ?? throw new global::System.ArgumentNullException(nameof(givenName));
            this.FamilyName = familyName ?? throw new global::System.ArgumentNullException(nameof(familyName));
            this.Formatted = formatted ?? throw new global::System.ArgumentNullException(nameof(formatted));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchOrganizationsScimV2UsersResponseName" /> class.
        /// </summary>
        public PatchOrganizationsScimV2UsersResponseName()
        {
        }
    }
}