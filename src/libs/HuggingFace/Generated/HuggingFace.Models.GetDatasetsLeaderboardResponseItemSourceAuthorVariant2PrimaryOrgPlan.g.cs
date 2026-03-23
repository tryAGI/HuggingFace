
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}