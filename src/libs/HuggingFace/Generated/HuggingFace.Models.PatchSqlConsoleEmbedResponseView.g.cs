
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchSqlConsoleEmbedResponseView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ViewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSqlConsoleEmbedResponseView" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="displayName"></param>
        /// <param name="viewName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchSqlConsoleEmbedResponseView(
            string key,
            string displayName,
            string viewName)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.ViewName = viewName ?? throw new global::System.ArgumentNullException(nameof(viewName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchSqlConsoleEmbedResponseView" /> class.
        /// </summary>
        public PatchSqlConsoleEmbedResponseView()
        {
        }
    }
}