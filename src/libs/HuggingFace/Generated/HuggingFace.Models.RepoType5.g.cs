
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType5
    {
        /// <summary>
        /// 
        /// </summary>
        Buckets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType5 value)
        {
            return value switch
            {
                RepoType5.Buckets => "buckets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType5? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => RepoType5.Buckets,
                _ => null,
            };
        }
    }
}