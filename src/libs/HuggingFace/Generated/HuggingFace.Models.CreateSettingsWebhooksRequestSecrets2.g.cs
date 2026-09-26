
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Secrets of the job started by the webhook, used together with `jobSourceId`: the source job's own secrets are never copied. On update, listed keys are replaced, an empty value removes a secret, and omitted keys keep their stored value.
    /// </summary>
    public sealed partial class CreateSettingsWebhooksRequestSecrets2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}