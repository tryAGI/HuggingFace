
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: trending
    /// </summary>
    public enum GetCollectionsSort
    {
        /// <summary>
        /// 
        /// </summary>
        LastModified,
        /// <summary>
        /// 
        /// </summary>
        Trending,
        /// <summary>
        /// 
        /// </summary>
        Upvotes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCollectionsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsSort value)
        {
            return value switch
            {
                GetCollectionsSort.LastModified => "lastModified",
                GetCollectionsSort.Trending => "trending",
                GetCollectionsSort.Upvotes => "upvotes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsSort? ToEnum(string value)
        {
            return value switch
            {
                "lastModified" => GetCollectionsSort.LastModified,
                "trending" => GetCollectionsSort.Trending,
                "upvotes" => GetCollectionsSort.Upvotes,
                _ => null,
            };
        }
    }
}