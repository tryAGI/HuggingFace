
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksResponseWebhookDomain2
    {
        /// <summary>
        /// 
        /// </summary>
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        Repo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSettingsWebhooksResponseWebhookDomain2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksResponseWebhookDomain2 value)
        {
            return value switch
            {
                CreateSettingsWebhooksResponseWebhookDomain2.Discussion => "discussion",
                CreateSettingsWebhooksResponseWebhookDomain2.Repo => "repo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksResponseWebhookDomain2? ToEnum(string value)
        {
            return value switch
            {
                "discussion" => CreateSettingsWebhooksResponseWebhookDomain2.Discussion,
                "repo" => CreateSettingsWebhooksResponseWebhookDomain2.Repo,
                _ => null,
            };
        }
    }
}