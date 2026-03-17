
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: recently-created
    /// </summary>
    public enum Sort
    {
        /// <summary>
        /// 
        /// </summary>
        RecentlyCreated,
        /// <summary>
        /// 
        /// </summary>
        Trending,
        /// <summary>
        /// 
        /// </summary>
        Reactions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sort value)
        {
            return value switch
            {
                Sort.RecentlyCreated => "recently-created",
                Sort.Trending => "trending",
                Sort.Reactions => "reactions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sort? ToEnum(string value)
        {
            return value switch
            {
                "recently-created" => Sort.RecentlyCreated,
                "trending" => Sort.Trending,
                "reactions" => Sort.Reactions,
                _ => null,
            };
        }
    }
}