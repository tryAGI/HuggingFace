
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookDomain
    {
        /// <summary>
        /// 
        /// </summary>
        Repo,
        /// <summary>
        /// 
        /// </summary>
        Discussion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseWebhookDomainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookDomain value)
        {
            return value switch
            {
                ResponseWebhookDomain.Repo => "repo",
                ResponseWebhookDomain.Discussion => "discussion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookDomain? ToEnum(string value)
        {
            return value switch
            {
                "repo" => ResponseWebhookDomain.Repo,
                "discussion" => ResponseWebhookDomain.Discussion,
                _ => null,
            };
        }
    }
}