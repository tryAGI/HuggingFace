
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole
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
    public static class GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Read => "read",
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}