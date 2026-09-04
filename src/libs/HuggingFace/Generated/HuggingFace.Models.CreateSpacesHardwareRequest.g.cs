
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSpacesHardwareRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flavor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.CreateSpacesHardwareRequestFlavorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.CreateSpacesHardwareRequestFlavor Flavor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleepTimeSeconds")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<int?, string>))]
        public global::HuggingFace.AnyOf<int?, string>? SleepTimeSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesHardwareRequest" /> class.
        /// </summary>
        /// <param name="flavor"></param>
        /// <param name="sleepTimeSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpacesHardwareRequest(
            global::HuggingFace.CreateSpacesHardwareRequestFlavor flavor,
            global::HuggingFace.AnyOf<int?, string>? sleepTimeSeconds)
        {
            this.Flavor = flavor;
            this.SleepTimeSeconds = sleepTimeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpacesHardwareRequest" /> class.
        /// </summary>
        public CreateSpacesHardwareRequest()
        {
        }

    }
}