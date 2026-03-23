
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateScheduledJobsScheduleResponseStatusLastJob2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime At { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledJobsScheduleResponseStatusLastJob2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="at"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateScheduledJobsScheduleResponseStatusLastJob2(
            string id,
            global::System.DateTime at)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.At = at;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduledJobsScheduleResponseStatusLastJob2" /> class.
        /// </summary>
        public CreateScheduledJobsScheduleResponseStatusLastJob2()
        {
        }
    }
}