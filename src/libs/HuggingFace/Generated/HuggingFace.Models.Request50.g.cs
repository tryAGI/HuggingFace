
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request50
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestVisibility2JsonConverter))]
        public global::HuggingFace.RequestVisibility2? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceGroupId")]
        public string? ResourceGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.RequestHardwareJsonConverter))]
        public global::HuggingFace.RequestHardware? Hardware { get; set; }

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
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestSecret>? Secrets { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        public global::System.Collections.Generic.IList<global::HuggingFace.RequestVariable>? Variables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request50" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request50(
            string repository,
            bool? @private,
            global::HuggingFace.RequestVisibility2? visibility,
            string? resourceGroupId,
            global::HuggingFace.RequestHardware? hardware,
            global::HuggingFace.AnyOf<int?, string>? sleepTimeSeconds,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestSecret>? secrets,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestVariable>? variables)
        {
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Private = @private;
            this.Visibility = visibility;
            this.ResourceGroupId = resourceGroupId;
            this.Hardware = hardware;
            this.SleepTimeSeconds = sleepTimeSeconds;
            this.Secrets = secrets;
            this.Variables = variables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request50" /> class.
        /// </summary>
        public Request50()
        {
        }
    }
}