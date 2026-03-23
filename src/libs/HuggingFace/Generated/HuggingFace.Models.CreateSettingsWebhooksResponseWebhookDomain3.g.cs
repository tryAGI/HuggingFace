
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksResponseWebhookDomain3
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
    public static class CreateSettingsWebhooksResponseWebhookDomain3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksResponseWebhookDomain3 value)
        {
            return value switch
            {
                CreateSettingsWebhooksResponseWebhookDomain3.Discussion => "discussion",
                CreateSettingsWebhooksResponseWebhookDomain3.Repo => "repo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksResponseWebhookDomain3? ToEnum(string value)
        {
            return value switch
            {
                "discussion" => CreateSettingsWebhooksResponseWebhookDomain3.Discussion,
                "repo" => CreateSettingsWebhooksResponseWebhookDomain3.Repo,
                _ => null,
            };
        }
    }
}