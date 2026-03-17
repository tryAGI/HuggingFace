
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.RequestWatchedItem> Watched { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public global::HuggingFace.RequestJob? Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobSourceId")]
        public string? JobSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.RequestDomain> Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request4" /> class.
        /// </summary>
        /// <param name="watched"></param>
        /// <param name="url"></param>
        /// <param name="job"></param>
        /// <param name="jobSourceId"></param>
        /// <param name="domains"></param>
        /// <param name="secret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Request4(
            global::System.Collections.Generic.IList<global::HuggingFace.RequestWatchedItem> watched,
            global::System.Collections.Generic.IList<global::HuggingFace.RequestDomain> domains,
            string? url,
            global::HuggingFace.RequestJob? job,
            string? jobSourceId,
            string? secret)
        {
            this.Watched = watched ?? throw new global::System.ArgumentNullException(nameof(watched));
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
            this.Url = url;
            this.Job = job;
            this.JobSourceId = jobSourceId;
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request4" /> class.
        /// </summary>
        public Request4()
        {
        }
    }
}