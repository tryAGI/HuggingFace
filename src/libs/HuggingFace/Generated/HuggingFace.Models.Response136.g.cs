
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response136
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"Another job is already running at the same time, set `concurrency` to allow multiple instances of scheduled jobs to run concurrently"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string Error { get; set; } = "Another job is already running at the same time, set `concurrency` to allow multiple instances of scheduled jobs to run concurrently";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response136" /> class.
        /// </summary>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response136(
            string error = "Another job is already running at the same time, set `concurrency` to allow multiple instances of scheduled jobs to run concurrently")
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response136" /> class.
        /// </summary>
        public Response136()
        {
        }
    }
}