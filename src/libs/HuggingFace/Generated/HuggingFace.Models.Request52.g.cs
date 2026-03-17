
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request52
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
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public string? Organization { get; set; }

        /// <summary>
        /// The license of the repository. You can select 'Other' if your license is not in the list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestLicenseJsonConverter))]
        public global::HuggingFace.RequestLicense? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_name")]
        public string? LicenseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license_link")]
        public string? LicenseLink { get; set; }

        /// <summary>
        /// Repository visibility. Defaults to public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestFile2>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request52" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="organization"></param>
        /// <param name="license">
        /// The license of the repository. You can select 'Other' if your license is not in the list
        /// </param>
        /// <param name="licenseName"></param>
        /// <param name="licenseLink"></param>
        /// <param name="private">
        /// Repository visibility. Defaults to public
        /// </param>
        /// <param name="resourceGroupId"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request52(
            string name,
            string? organization,
            global::HuggingFace.RequestLicense? license,
            string? licenseName,
            string? licenseLink,
            bool? @private,
            string? resourceGroupId,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestFile2>? files)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Organization = organization;
            this.License = license;
            this.LicenseName = licenseName;
            this.LicenseLink = licenseLink;
            this.Private = @private;
            this.ResourceGroupId = resourceGroupId;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request52" /> class.
        /// </summary>
        public Request52()
        {
        }
    }
}