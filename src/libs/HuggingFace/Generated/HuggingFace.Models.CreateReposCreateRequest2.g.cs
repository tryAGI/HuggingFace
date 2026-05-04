
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateReposCreateRequest2
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
        /// The region where the repository is hosted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestRegionJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestRegion? Region { get; set; }

        /// <summary>
        /// The license of the repository. You can select 'Other' if your license is not in the list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestLicenseJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestLicense? License { get; set; }

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
        /// Repository visibility. Defaults to public. Cannot be specified along with visibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Repository visibility. `protected` is only supported for Spaces. Cannot be specified along with private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVisibilityJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestFile>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequest2" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="organization"></param>
        /// <param name="region">
        /// The region where the repository is hosted.
        /// </param>
        /// <param name="license">
        /// The license of the repository. You can select 'Other' if your license is not in the list
        /// </param>
        /// <param name="licenseName"></param>
        /// <param name="licenseLink"></param>
        /// <param name="private">
        /// Repository visibility. Defaults to public. Cannot be specified along with visibility.
        /// </param>
        /// <param name="visibility">
        /// Repository visibility. `protected` is only supported for Spaces. Cannot be specified along with private.
        /// </param>
        /// <param name="resourceGroupId"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateReposCreateRequest2(
            string name,
            string? organization,
            global::HuggingFace.CreateReposCreateRequestRegion? region,
            global::HuggingFace.CreateReposCreateRequestLicense? license,
            string? licenseName,
            string? licenseLink,
            bool? @private,
            global::HuggingFace.CreateReposCreateRequestVisibility? visibility,
            string? resourceGroupId,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestFile>? files)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Organization = organization;
            this.Region = region;
            this.License = license;
            this.LicenseName = licenseName;
            this.LicenseLink = licenseLink;
            this.Private = @private;
            this.Visibility = visibility;
            this.ResourceGroupId = resourceGroupId;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequest2" /> class.
        /// </summary>
        public CreateReposCreateRequest2()
        {
        }
    }
}