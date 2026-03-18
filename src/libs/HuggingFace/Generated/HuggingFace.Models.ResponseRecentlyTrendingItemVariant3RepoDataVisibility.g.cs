
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Protected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant3RepoDataVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataVisibility value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataVisibility.Public => "public",
                ResponseRecentlyTrendingItemVariant3RepoDataVisibility.Private => "private",
                ResponseRecentlyTrendingItemVariant3RepoDataVisibility.Protected => "protected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => ResponseRecentlyTrendingItemVariant3RepoDataVisibility.Public,
                "private" => ResponseRecentlyTrendingItemVariant3RepoDataVisibility.Private,
                "protected" => ResponseRecentlyTrendingItemVariant3RepoDataVisibility.Protected,
                _ => null,
            };
        }
    }
}