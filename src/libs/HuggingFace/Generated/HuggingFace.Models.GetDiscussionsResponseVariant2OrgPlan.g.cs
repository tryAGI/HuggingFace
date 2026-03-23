
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant2OrgPlan
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
    public static class GetDiscussionsResponseVariant2OrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant2OrgPlan value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant2OrgPlan.Academia => "academia",
                GetDiscussionsResponseVariant2OrgPlan.Enterprise => "enterprise",
                GetDiscussionsResponseVariant2OrgPlan.Plus => "plus",
                GetDiscussionsResponseVariant2OrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant2OrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDiscussionsResponseVariant2OrgPlan.Academia,
                "enterprise" => GetDiscussionsResponseVariant2OrgPlan.Enterprise,
                "plus" => GetDiscussionsResponseVariant2OrgPlan.Plus,
                "team" => GetDiscussionsResponseVariant2OrgPlan.Team,
                _ => null,
            };
        }
    }
}