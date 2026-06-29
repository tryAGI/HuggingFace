
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Sort field (e.g. downloads, likes, lastModified, trendingScore)<br/>
    /// Default Value: trendingScore
    /// </summary>
    public enum GetKernelsSort
    {
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Downloads,
        /// <summary>
        /// 
        /// </summary>
        Id2,
        /// <summary>
        /// 
        /// </summary>
        LastModified,
        /// <summary>
        /// 
        /// </summary>
        Likes,
        /// <summary>
        /// 
        /// </summary>
        Likes30d,
        /// <summary>
        /// 
        /// </summary>
        TrendingScore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsSort value)
        {
            return value switch
            {
                GetKernelsSort.Id => "_id",
                GetKernelsSort.Downloads => "downloads",
                GetKernelsSort.Id2 => "id",
                GetKernelsSort.LastModified => "lastModified",
                GetKernelsSort.Likes => "likes",
                GetKernelsSort.Likes30d => "likes30d",
                GetKernelsSort.TrendingScore => "trendingScore",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsSort? ToEnum(string value)
        {
            return value switch
            {
                "_id" => GetKernelsSort.Id,
                "downloads" => GetKernelsSort.Downloads,
                "id" => GetKernelsSort.Id2,
                "lastModified" => GetKernelsSort.LastModified,
                "likes" => GetKernelsSort.Likes,
                "likes30d" => GetKernelsSort.Likes30d,
                "trendingScore" => GetKernelsSort.TrendingScore,
                _ => null,
            };
        }
    }
}