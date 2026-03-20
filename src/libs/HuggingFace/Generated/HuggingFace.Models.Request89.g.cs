
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request89
    {
        /// <summary>
        /// CRON schedule expression (e.g., '0 9 * * 1' for 9 AM every Monday).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request89" /> class.
        /// </summary>
        /// <param name="schedule">
        /// CRON schedule expression (e.g., '0 9 * * 1' for 9 AM every Monday).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request89(
            string schedule)
        {
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request89" /> class.
        /// </summary>
        public Request89()
        {
        }
    }
}