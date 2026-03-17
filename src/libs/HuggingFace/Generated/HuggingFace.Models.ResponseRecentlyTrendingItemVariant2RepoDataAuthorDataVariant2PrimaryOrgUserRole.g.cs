
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole
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
    public static class ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}