
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSettingsWebhooksResponseWebhook
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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public global::HuggingFace.CreateSettingsWebhooksResponseWebhookJob? Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobSourceId")]
        public string? JobSourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.AnyOfJsonConverter<bool?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::HuggingFace.AnyOf<bool?, string> Disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem> Watched { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain> Domains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastTriggerAt")]
        public global::System.DateTime? LastTriggerAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksResponseWebhook" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="job"></param>
        /// <param name="jobSourceId"></param>
        /// <param name="disabled"></param>
        /// <param name="watched"></param>
        /// <param name="secret"></param>
        /// <param name="domains"></param>
        /// <param name="lastTriggerAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsWebhooksResponseWebhook(
            string id,
            global::HuggingFace.AnyOf<bool?, string> disabled,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookWatchedItem> watched,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksResponseWebhookDomain> domains,
            string? url,
            global::HuggingFace.CreateSettingsWebhooksResponseWebhookJob? job,
            string? jobSourceId,
            string? secret,
            global::System.DateTime? lastTriggerAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Disabled = disabled;
            this.Watched = watched ?? throw new global::System.ArgumentNullException(nameof(watched));
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
            this.Url = url;
            this.Job = job;
            this.JobSourceId = jobSourceId;
            this.Secret = secret;
            this.LastTriggerAt = lastTriggerAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksResponseWebhook" /> class.
        /// </summary>
        public CreateSettingsWebhooksResponseWebhook()
        {
        }
    }
}