
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsLeaderboardResponseItemAuthorVariant1Plan
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
    public static class GetDatasetsLeaderboardResponseItemAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLeaderboardResponseItemAuthorVariant1Plan value)
        {
            return value switch
            {
                GetDatasetsLeaderboardResponseItemAuthorVariant1Plan.Academia => "academia",
                GetDatasetsLeaderboardResponseItemAuthorVariant1Plan.Enterprise => "enterprise",
                GetDatasetsLeaderboardResponseItemAuthorVariant1Plan.Plus => "plus",
                GetDatasetsLeaderboardResponseItemAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLeaderboardResponseItemAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDatasetsLeaderboardResponseItemAuthorVariant1Plan.Academia,
                "enterprise" => GetDatasetsLeaderboardResponseItemAuthorVariant1Plan.Enterprise,
                "plus" => GetDatasetsLeaderboardResponseItemAuthorVariant1Plan.Plus,
                "team" => GetDatasetsLeaderboardResponseItemAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}