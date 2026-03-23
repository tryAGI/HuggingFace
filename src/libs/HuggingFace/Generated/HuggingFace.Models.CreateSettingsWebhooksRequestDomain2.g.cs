
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksRequestDomain2
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
    public static class CreateSettingsWebhooksRequestDomain2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestDomain2 value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestDomain2.Discussion => "discussion",
                CreateSettingsWebhooksRequestDomain2.Repo => "repo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestDomain2? ToEnum(string value)
        {
            return value switch
            {
                "discussion" => CreateSettingsWebhooksRequestDomain2.Discussion,
                "repo" => CreateSettingsWebhooksRequestDomain2.Repo,
                _ => null,
            };
        }
    }
}