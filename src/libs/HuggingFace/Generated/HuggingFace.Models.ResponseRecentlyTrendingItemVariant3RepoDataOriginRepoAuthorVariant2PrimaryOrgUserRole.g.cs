
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        Read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}