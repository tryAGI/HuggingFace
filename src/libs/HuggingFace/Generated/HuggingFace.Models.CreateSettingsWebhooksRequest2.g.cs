
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateSettingsWebhooksRequest2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2> Watched { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::HuggingFace.JsonConverters.OneOfJsonConverter<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22>))]
        public global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22>? Job { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobSourceId")]
        public string? JobSourceId { get; set; }

        /// <summary>
        /// Secrets of the job started by the webhook, used together with `jobSourceId`: the source job's own secrets are never copied. On update, listed keys are replaced, an empty value removes a secret, and omitted keys keep their stored value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.Dictionary<string, string>? Secrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain2> Domains { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequest2" /> class.
        /// </summary>
        /// <param name="watched"></param>
        /// <param name="domains"></param>
        /// <param name="url"></param>
        /// <param name="job"></param>
        /// <param name="jobSourceId"></param>
        /// <param name="secrets">
        /// Secrets of the job started by the webhook, used together with `jobSourceId`: the source job's own secrets are never copied. On update, listed keys are replaced, an empty value removes a secret, and omitted keys keep their stored value.
        /// </param>
        /// <param name="secret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSettingsWebhooksRequest2(
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestWatchedItem2> watched,
            global::System.Collections.Generic.IList<global::HuggingFace.CreateSettingsWebhooksRequestDomain2> domains,
            string? url,
            global::HuggingFace.OneOf<global::HuggingFace.CreateSettingsWebhooksRequestJobVariant12, global::HuggingFace.CreateSettingsWebhooksRequestJobVariant22>? job,
            string? jobSourceId,
            global::System.Collections.Generic.Dictionary<string, string>? secrets,
            string? secret)
        {
            this.Watched = watched ?? throw new global::System.ArgumentNullException(nameof(watched));
            this.Url = url;
            this.Job = job;
            this.JobSourceId = jobSourceId;
            this.Secrets = secrets;
            this.Domains = domains ?? throw new global::System.ArgumentNullException(nameof(domains));
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSettingsWebhooksRequest2" /> class.
        /// </summary>
        public CreateSettingsWebhooksRequest2()
        {
        }

    }
}