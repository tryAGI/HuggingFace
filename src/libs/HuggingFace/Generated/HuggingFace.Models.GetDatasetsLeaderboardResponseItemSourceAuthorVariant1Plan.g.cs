
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan
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
    public static class GetDatasetsLeaderboardResponseItemSourceAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan value)
        {
            return value switch
            {
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan.Academia => "academia",
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan.Enterprise => "enterprise",
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan.Plus => "plus",
                GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan.Academia,
                "enterprise" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan.Enterprise,
                "plus" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan.Plus,
                "team" => GetDatasetsLeaderboardResponseItemSourceAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}