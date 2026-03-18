
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Repository visibility. Defaults to public. Cannot be specified along with visibility.
    /// </summary>
    public sealed partial class RequestPrivate
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}