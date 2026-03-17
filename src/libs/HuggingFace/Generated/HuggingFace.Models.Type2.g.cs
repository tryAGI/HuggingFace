
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum Type2
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Discussion,
        /// <summary>
        /// 
        /// </summary>
        PullRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Type2 value)
        {
            return value switch
            {
                Type2.All => "all",
                Type2.Discussion => "discussion",
                Type2.PullRequest => "pull_request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Type2? ToEnum(string value)
        {
            return value switch
            {
                "all" => Type2.All,
                "discussion" => Type2.Discussion,
                "pull_request" => Type2.PullRequest,
                _ => null,
            };
        }
    }
}