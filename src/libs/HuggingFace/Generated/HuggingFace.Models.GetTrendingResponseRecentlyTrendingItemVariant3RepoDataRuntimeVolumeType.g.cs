
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType
    {
        /// <summary>
        /// 
        /// </summary>
        Bucket,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType.Bucket => "bucket",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType.Dataset => "dataset",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType.Model => "model",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType.Bucket,
                "dataset" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType.Dataset,
                "model" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType.Model,
                "space" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeVolumeType.Space,
                _ => null,
            };
        }
    }
}