
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsersFollowingOrgsResponseItemPlan
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
    public static class GetUsersFollowingOrgsResponseItemPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsersFollowingOrgsResponseItemPlan value)
        {
            return value switch
            {
                GetUsersFollowingOrgsResponseItemPlan.Academia => "academia",
                GetUsersFollowingOrgsResponseItemPlan.Enterprise => "enterprise",
                GetUsersFollowingOrgsResponseItemPlan.Plus => "plus",
                GetUsersFollowingOrgsResponseItemPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsersFollowingOrgsResponseItemPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetUsersFollowingOrgsResponseItemPlan.Academia,
                "enterprise" => GetUsersFollowingOrgsResponseItemPlan.Enterprise,
                "plus" => GetUsersFollowingOrgsResponseItemPlan.Plus,
                "team" => GetUsersFollowingOrgsResponseItemPlan.Team,
                _ => null,
            };
        }
    }
}