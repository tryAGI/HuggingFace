
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestDomain2
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
    public static class RequestDomain2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestDomain2 value)
        {
            return value switch
            {
                RequestDomain2.Repo => "repo",
                RequestDomain2.Discussion => "discussion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestDomain2? ToEnum(string value)
        {
            return value switch
            {
                "repo" => RequestDomain2.Repo,
                "discussion" => RequestDomain2.Discussion,
                _ => null,
            };
        }
    }
}