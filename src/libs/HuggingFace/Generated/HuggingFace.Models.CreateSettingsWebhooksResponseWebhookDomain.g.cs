
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksResponseWebhookDomain
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
    public static class CreateSettingsWebhooksResponseWebhookDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksResponseWebhookDomain value)
        {
            return value switch
            {
                CreateSettingsWebhooksResponseWebhookDomain.Discussion => "discussion",
                CreateSettingsWebhooksResponseWebhookDomain.Repo => "repo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksResponseWebhookDomain? ToEnum(string value)
        {
            return value switch
            {
                "discussion" => CreateSettingsWebhooksResponseWebhookDomain.Discussion,
                "repo" => CreateSettingsWebhooksResponseWebhookDomain.Repo,
                _ => null,
            };
        }
    }
}