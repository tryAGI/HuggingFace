
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Labels for the job as key-value pairs. Both keys and values must be max 100 characters and contain only alphanumeric characters, dots, dashes, and underscores.
    /// </summary>
    public sealed partial class RequestJobSpecLabels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}