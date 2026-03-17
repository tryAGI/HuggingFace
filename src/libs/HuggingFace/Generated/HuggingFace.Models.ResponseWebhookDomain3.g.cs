
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseWebhookDomain3
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
    public static class ResponseWebhookDomain3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseWebhookDomain3 value)
        {
            return value switch
            {
                ResponseWebhookDomain3.Repo => "repo",
                ResponseWebhookDomain3.Discussion => "discussion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseWebhookDomain3? ToEnum(string value)
        {
            return value switch
            {
                "repo" => ResponseWebhookDomain3.Repo,
                "discussion" => ResponseWebhookDomain3.Discussion,
                _ => null,
            };
        }
    }
}