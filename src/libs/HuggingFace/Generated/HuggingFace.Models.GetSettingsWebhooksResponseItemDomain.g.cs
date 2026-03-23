
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSettingsWebhooksResponseItemDomain
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
    public static class GetSettingsWebhooksResponseItemDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsWebhooksResponseItemDomain value)
        {
            return value switch
            {
                GetSettingsWebhooksResponseItemDomain.Discussion => "discussion",
                GetSettingsWebhooksResponseItemDomain.Repo => "repo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsWebhooksResponseItemDomain? ToEnum(string value)
        {
            return value switch
            {
                "discussion" => GetSettingsWebhooksResponseItemDomain.Discussion,
                "repo" => GetSettingsWebhooksResponseItemDomain.Repo,
                _ => null,
            };
        }
    }
}