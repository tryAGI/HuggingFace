
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant1OrgPlan
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
    public static class GetDiscussionsResponseVariant1OrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant1OrgPlan value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant1OrgPlan.Academia => "academia",
                GetDiscussionsResponseVariant1OrgPlan.Enterprise => "enterprise",
                GetDiscussionsResponseVariant1OrgPlan.Plus => "plus",
                GetDiscussionsResponseVariant1OrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant1OrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDiscussionsResponseVariant1OrgPlan.Academia,
                "enterprise" => GetDiscussionsResponseVariant1OrgPlan.Enterprise,
                "plus" => GetDiscussionsResponseVariant1OrgPlan.Plus,
                "team" => GetDiscussionsResponseVariant1OrgPlan.Team,
                _ => null,
            };
        }
    }
}