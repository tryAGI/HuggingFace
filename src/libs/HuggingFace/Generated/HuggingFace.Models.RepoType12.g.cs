
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepoType12
    {
        /// <summary>
        /// 
        /// </summary>
        Buckets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepoType12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepoType12 value)
        {
            return value switch
            {
                RepoType12.Buckets => "buckets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepoType12? ToEnum(string value)
        {
            return value switch
            {
                "buckets" => RepoType12.Buckets,
                _ => null,
            };
        }
    }
}