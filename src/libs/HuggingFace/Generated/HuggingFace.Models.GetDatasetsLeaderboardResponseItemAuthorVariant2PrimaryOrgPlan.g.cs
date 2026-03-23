
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan
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
    public static class GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => GetDatasetsLeaderboardResponseItemAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}