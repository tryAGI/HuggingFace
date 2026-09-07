
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateReposCreateRequestVariant4
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVariant4RegionJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestVariant4Region? Region { get; set; }

        /// <summary>
        /// The license of the repository. You can select 'Other' if your license is not in the list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVariant4LicenseJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestVariant4License? License { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVariant4VisibilityJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestVariant4Visibility? Visibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4File>? Files { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"space"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "space";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public string? Template { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_description")]
        public string? ShortDescription { get; set; }

        /// <summary>
        /// The hardware flavor of the space. If you select 'zero-a10g' or 'zerogpu', the SDK must be Gradio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVariant4HardwareJsonConverter))]
        public global::HuggingFace.CreateReposCreateRequestVariant4Hardware? Hardware { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Secret>? Secrets { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Variable>? Variables { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleepTimeSeconds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, double?>))]
        public global::HuggingFace.AnyOf<int?, double?>? SleepTimeSeconds { get; set; }

        /// <summary>
        /// HuggingFace Buckets or Repos to mount as volumes in the Space container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Volume>? Volumes { get; set; }

        /// <summary>
        /// The Space SDK. `static` is free for everyone. `gradio` and `docker` run on compute: on the free `cpu-basic` flavor they require a subscription (PRO for users, Team/Enterprise for orgs), while paid hardware only requires billing (a payment method and prepaid credits).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateReposCreateRequestVariant4SdkJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateReposCreateRequestVariant4Sdk Sdk { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdkVersion")]
        public string? SdkVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devModeEnabled")]
        public bool? DevModeEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequestVariant4" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sdk">
        /// The Space SDK. `static` is free for everyone. `gradio` and `docker` run on compute: on the free `cpu-basic` flavor they require a subscription (PRO for users, Team/Enterprise for orgs), while paid hardware only requires billing (a payment method and prepaid credits).
        /// </param>
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
        /// <param name="template"></param>
        /// <param name="shortDescription"></param>
        /// <param name="hardware">
        /// The hardware flavor of the space. If you select 'zero-a10g' or 'zerogpu', the SDK must be Gradio.
        /// </param>
        /// <param name="secrets">
        /// Default Value: []
        /// </param>
        /// <param name="variables">
        /// Default Value: []
        /// </param>
        /// <param name="sleepTimeSeconds"></param>
        /// <param name="volumes">
        /// HuggingFace Buckets or Repos to mount as volumes in the Space container.
        /// </param>
        /// <param name="sdkVersion"></param>
        /// <param name="devModeEnabled"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateReposCreateRequestVariant4(
            string name,
            global::HuggingFace.CreateReposCreateRequestVariant4Sdk sdk,
            string? organization,
            global::HuggingFace.CreateReposCreateRequestVariant4Region? region,
            global::HuggingFace.CreateReposCreateRequestVariant4License? license,
            string? licenseName,
            string? licenseLink,
            bool? @private,
            global::HuggingFace.CreateReposCreateRequestVariant4Visibility? visibility,
            string? resourceGroupId,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4File>? files,
            string? template,
            string? shortDescription,
            global::HuggingFace.CreateReposCreateRequestVariant4Hardware? hardware,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Secret>? secrets,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Variable>? variables,
            global::HuggingFace.AnyOf<int?, double?>? sleepTimeSeconds,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateReposCreateRequestVariant4Volume>? volumes,
            string? sdkVersion,
            bool? devModeEnabled,
            string type = "space")
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
            this.Template = template;
            this.ShortDescription = shortDescription;
            this.Hardware = hardware;
            this.Secrets = secrets;
            this.Variables = variables;
            this.SleepTimeSeconds = sleepTimeSeconds;
            this.Volumes = volumes;
            this.Sdk = sdk;
            this.SdkVersion = sdkVersion;
            this.DevModeEnabled = devModeEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReposCreateRequestVariant4" /> class.
        /// </summary>
        public CreateReposCreateRequestVariant4()
        {
        }

    }
}