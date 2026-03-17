
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookDomain2
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
    public static class ResponseWebhookDomain2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookDomain2 value)
        {
            return value switch
            {
                ResponseWebhookDomain2.Repo => "repo",
                ResponseWebhookDomain2.Discussion => "discussion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookDomain2? ToEnum(string value)
        {
            return value switch
            {
                "repo" => ResponseWebhookDomain2.Repo,
                "discussion" => ResponseWebhookDomain2.Discussion,
                _ => null,
            };
        }
    }
}