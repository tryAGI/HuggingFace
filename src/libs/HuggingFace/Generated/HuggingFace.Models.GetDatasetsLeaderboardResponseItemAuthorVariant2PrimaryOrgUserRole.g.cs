
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole
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
    public static class GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole.Read => "read",
                GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}