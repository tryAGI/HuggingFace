
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateReposCreateRequestVariant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVariant2RegionJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestVariant2Region? Region { get; set; }

        /// <summary>
        /// The license of the repository. You can select 'Other' if your license is not in the list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVariant2LicenseJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestVariant2License? License { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVariant2VisibilityJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestVariant2Visibility? Visibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant2File>? Files { get; set; }

        /// <summary>
        /// Default Value: model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequestVariant2" /> class.
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
        /// <param name="type">
        /// Default Value: model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateReposCreateRequestVariant2(
            string name,
            string? organization,
            global::HuggingFace.CreateReposCreateRequestVariant2Region? region,
            global::HuggingFace.CreateReposCreateRequestVariant2License? license,
            string? licenseName,
            string? licenseLink,
            bool? @private,
            global::HuggingFace.CreateReposCreateRequestVariant2Visibility? visibility,
            string? resourceGroupId,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant2File>? files,
            string? type)
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
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequestVariant2" /> class.
        /// </summary>
        public CreateReposCreateRequestVariant2()
        {
        }

    }
}