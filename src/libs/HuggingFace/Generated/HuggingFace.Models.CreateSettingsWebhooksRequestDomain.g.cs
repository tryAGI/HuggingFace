
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSettingsWebhooksRequestDomain
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
    public static class CreateSettingsWebhooksRequestDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsWebhooksRequestDomain value)
        {
            return value switch
            {
                CreateSettingsWebhooksRequestDomain.Discussion => "discussion",
                CreateSettingsWebhooksRequestDomain.Repo => "repo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsWebhooksRequestDomain? ToEnum(string value)
        {
            return value switch
            {
                "discussion" => CreateSettingsWebhooksRequestDomain.Discussion,
                "repo" => CreateSettingsWebhooksRequestDomain.Repo,
                _ => null,
            };
        }
    }
}