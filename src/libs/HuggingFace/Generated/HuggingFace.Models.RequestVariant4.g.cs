
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestVariant4
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestVariant4HardwareJsonConverter))]
        public global::HuggingFace.RequestVariant4Hardware? Hardware { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storageTier")]
        public global::HuggingFace.RequestVariant4StorageTier2? StorageTier { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestVariant4Secret>? Secrets { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestVariant4Variable>? Variables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleepTimeSeconds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::HuggingFace.AnyOf<int?, string>? SleepTimeSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestVariant4SdkJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.RequestVariant4Sdk Sdk { get; set; }

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
        /// Initializes a new instance of the <see cref="RequestVariant4" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="template"></param>
        /// <param name="shortDescription"></param>
        /// <param name="hardware">
        /// The hardware flavor of the space. If you select 'zero-a10g' or 'zerogpu', the SDK must be Gradio.
        /// </param>
        /// <param name="storageTier"></param>
        /// <param name="secrets">
        /// Default Value: []
        /// </param>
        /// <param name="variables">
        /// Default Value: []
        /// </param>
        /// <param name="sleepTimeSeconds"></param>
        /// <param name="sdk"></param>
        /// <param name="sdkVersion"></param>
        /// <param name="devModeEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestVariant4(
            global::HuggingFace.RequestVariant4Sdk sdk,
            string? template,
            string? shortDescription,
            global::HuggingFace.RequestVariant4Hardware? hardware,
            global::HuggingFace.RequestVariant4StorageTier2? storageTier,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestVariant4Secret>? secrets,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestVariant4Variable>? variables,
            global::HuggingFace.AnyOf<int?, string>? sleepTimeSeconds,
            string? sdkVersion,
            bool? devModeEnabled,
            string type = "space")
        {
            this.Sdk = sdk;
            this.Type = type;
            this.Template = template;
            this.ShortDescription = shortDescription;
            this.Hardware = hardware;
            this.StorageTier = storageTier;
            this.Secrets = secrets;
            this.Variables = variables;
            this.SleepTimeSeconds = sleepTimeSeconds;
            this.SdkVersion = sdkVersion;
            this.DevModeEnabled = devModeEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestVariant4" /> class.
        /// </summary>
        public RequestVariant4()
        {
        }
    }
}