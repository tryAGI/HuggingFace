
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType14
    {
        /// <summary>
        /// 
        /// </summary>
        Buckets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType14 value)
        {
            return value switch
            {
                RepoType14.Buckets => "buckets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType14? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => RepoType14.Buckets,
                _ => null,
            };
        }
    }
}