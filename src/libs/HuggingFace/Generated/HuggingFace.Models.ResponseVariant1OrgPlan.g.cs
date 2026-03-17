
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1OrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
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
        Academia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseVariant1OrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1OrgPlan value)
        {
            return value switch
            {
                ResponseVariant1OrgPlan.Team => "team",
                ResponseVariant1OrgPlan.Enterprise => "enterprise",
                ResponseVariant1OrgPlan.Plus => "plus",
                ResponseVariant1OrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1OrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant1OrgPlan.Team,
                "enterprise" => ResponseVariant1OrgPlan.Enterprise,
                "plus" => ResponseVariant1OrgPlan.Plus,
                "academia" => ResponseVariant1OrgPlan.Academia,
                _ => null,
            };
        }
    }
}