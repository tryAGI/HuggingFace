
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDuplicateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateDuplicateRequestVisibilityJsonConverter))]
        public global::HuggingFace.CreateDuplicateRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateDuplicateRequestHardwareJsonConverter))]
        public global::HuggingFace.CreateDuplicateRequestHardware? Hardware { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleepTimeSeconds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::HuggingFace.AnyOf<int?, string>? SleepTimeSeconds { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestSecret>? Secrets { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestVariable>? Variables { get; set; }

        /// <summary>
        /// HuggingFace Buckets or Repos to mount as volumes in the duplicated Space.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestVolume>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDuplicateRequest" /> class.
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="private"></param>
        /// <param name="visibility"></param>
        /// <param name="resourceGroupId"></param>
        /// <param name="hardware"></param>
        /// <param name="sleepTimeSeconds"></param>
        /// <param name="secrets">
        /// Default Value: []
        /// </param>
        /// <param name="variables">
        /// Default Value: []
        /// </param>
        /// <param name="volumes">
        /// HuggingFace Buckets or Repos to mount as volumes in the duplicated Space.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDuplicateRequest(
            string repository,
            bool? @private,
            global::HuggingFace.CreateDuplicateRequestVisibility? visibility,
            string? resourceGroupId,
            global::HuggingFace.CreateDuplicateRequestHardware? hardware,
            global::HuggingFace.AnyOf<int?, string>? sleepTimeSeconds,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestSecret>? secrets,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestVariable>? variables,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateDuplicateRequestVolume>? volumes)
        {
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Private = @private;
            this.Visibility = visibility;
            this.ResourceGroupId = resourceGroupId;
            this.Hardware = hardware;
            this.SleepTimeSeconds = sleepTimeSeconds;
            this.Secrets = secrets;
            this.Variables = variables;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDuplicateRequest" /> class.
        /// </summary>
        public CreateDuplicateRequest()
        {
        }
    }
}