
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookDomain4
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
    public static class ResponseWebhookDomain4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookDomain4 value)
        {
            return value switch
            {
                ResponseWebhookDomain4.Repo => "repo",
                ResponseWebhookDomain4.Discussion => "discussion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookDomain4? ToEnum(string value)
        {
            return value switch
            {
                "repo" => ResponseWebhookDomain4.Repo,
                "discussion" => ResponseWebhookDomain4.Discussion,
                _ => null,
            };
        }
    }
}