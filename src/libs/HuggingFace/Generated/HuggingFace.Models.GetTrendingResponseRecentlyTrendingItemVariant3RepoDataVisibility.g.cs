
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Protected,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility.Private => "private",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility.Protected => "protected",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility.Private,
                "protected" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility.Protected,
                "public" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataVisibility.Public,
                _ => null,
            };
        }
    }
}