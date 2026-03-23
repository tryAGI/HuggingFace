
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsWebhooksResponseWebhookDomain
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
    public static class GetSettingsWebhooksResponseWebhookDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsWebhooksResponseWebhookDomain value)
        {
            return value switch
            {
                GetSettingsWebhooksResponseWebhookDomain.Discussion => "discussion",
                GetSettingsWebhooksResponseWebhookDomain.Repo => "repo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsWebhooksResponseWebhookDomain? ToEnum(string value)
        {
            return value switch
            {
                "discussion" => GetSettingsWebhooksResponseWebhookDomain.Discussion,
                "repo" => GetSettingsWebhooksResponseWebhookDomain.Repo,
                _ => null,
            };
        }
    }
}