
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType45
    {
        /// <summary>
        /// 
        /// </summary>
        Spaces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType45Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType45 value)
        {
            return value switch
            {
                RepoType45.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType45? ToEnum(string value)
        {
            return value switch
            {
                "spaces" => RepoType45.Spaces,
                _ => null,
            };
        }
    }
}