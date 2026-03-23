
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "read" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}