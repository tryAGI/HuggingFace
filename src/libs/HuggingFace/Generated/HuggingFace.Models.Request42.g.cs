
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request42
    {
        /// <summary>
        /// The commit to start from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startingPoint")]
        public string? StartingPoint { get; set; }

        /// <summary>
        /// Create an empty branch<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emptyBranch")]
        public bool? EmptyBranch { get; set; }

        /// <summary>
        /// Overwrite the branch if it already exists<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overwrite")]
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request42" /> class.
        /// </summary>
        /// <param name="startingPoint">
        /// The commit to start from
        /// </param>
        /// <param name="emptyBranch">
        /// Create an empty branch<br/>
        /// Default Value: false
        /// </param>
        /// <param name="overwrite">
        /// Overwrite the branch if it already exists<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request42(
            string? startingPoint,
            bool? emptyBranch,
            bool? overwrite)
        {
            this.StartingPoint = startingPoint;
            this.EmptyBranch = emptyBranch;
            this.Overwrite = overwrite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request42" /> class.
        /// </summary>
        public Request42()
        {
        }
    }
}