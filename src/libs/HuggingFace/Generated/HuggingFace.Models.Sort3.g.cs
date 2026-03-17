
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: trending
    /// </summary>
    public enum Sort3
    {
        /// <summary>
        /// 
        /// </summary>
        Upvotes,
        /// <summary>
        /// 
        /// </summary>
        LastModified,
        /// <summary>
        /// 
        /// </summary>
        Trending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Sort3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sort3 value)
        {
            return value switch
            {
                Sort3.Upvotes => "upvotes",
                Sort3.LastModified => "lastModified",
                Sort3.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sort3? ToEnum(string value)
        {
            return value switch
            {
                "upvotes" => Sort3.Upvotes,
                "lastModified" => Sort3.LastModified,
                "trending" => Sort3.Trending,
                _ => null,
            };
        }
    }
}