
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType24
    {
        /// <summary>
        /// 
        /// </summary>
        Spaces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType24Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType24 value)
        {
            return value switch
            {
                RepoType24.Spaces => "spaces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType24? ToEnum(string value)
        {
            return value switch
            {
                "spaces" => RepoType24.Spaces,
                _ => null,
            };
        }
    }
}